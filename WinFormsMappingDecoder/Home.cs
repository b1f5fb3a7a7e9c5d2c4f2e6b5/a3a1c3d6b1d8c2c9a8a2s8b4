using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMappingDecoder.Properties;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsMappingDecoder
{
    public partial class Home : Form
    {
        private Dictionary<char, int> _alphabet = new Dictionary<char, int>();
        private Dictionary<char, int> _text = new Dictionary<char, int>();
        private List<string> _bufferList = new List<string>();
        private int _indexList = -1;

        public Home()
        {
            InitializeComponent();

            foreach (var letter in "абвгдеёжзийклмнопрстуфхцчшщъыьэюя")
            {
                _alphabet.Add(letter, 0);
                _text.Add(letter, 0);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown ||
                MessageBox.Show(string.Format(Resources.Home_OnFormClosing_, base.Text),
                    @"Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes) return;

            e.Cancel = true;
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            textBox.Text = OpenFile();

            if (_alphabet.Count < 1 || textBox.Text.Replace(" ", "") == "") return;

            _text = Analysis(textBox.Text.ToLower(), _text);

            textBoxInfo.Text += "-------\n";

            foreach (var letter in _text)
            {
                textBoxInfo.Text += $"key: {letter.Key}\t - value: {letter.Value}\n";
            }

            BufferListAdd();
        }

        private void menuAlphabet_Click(object sender, EventArgs e)
        {
            var textFile = OpenFile();
            if (textFile == string.Empty) return;

            _alphabet = Analysis(textFile, _alphabet);

            textBoxInfo.Text = "";
            foreach (var letter in _alphabet)
            {
                textBoxInfo.Text += $"key: {letter.Key}\t - value: {letter.Value}\n";
            }
        }

        private static Dictionary<char, int> Analysis(string text, Dictionary<char, int> dictionary)
        {
            foreach (var symbol in text.ToLower())
            {
                if (dictionary.ContainsKey(symbol))
                    dictionary[symbol] = dictionary[symbol] + 1;
            }

            var sum = dictionary.Values.Sum();
            for (var i = 0; i < dictionary.Count; i++)
            {
                dictionary[dictionary.Keys.ToArray()[i]] =
                    dictionary[dictionary.Keys.ToArray()[i]] * 100000 / sum;
            }

            return dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        private void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox.SelectionLength != 1) return;

            var dlgReplace = new Replace
            {
                textBox1 = {Text = textBox.SelectedText},
                textBox2 = {Text = textBox.SelectedText.ToLower()}
            };

            if (dlgReplace.ShowDialog() != DialogResult.OK || dlgReplace.textBox2.Text == "") return;

            textBox.Text = textBox.Text.Replace(dlgReplace.textBox1.Text[0], dlgReplace.textBox2.Text[0]);
            textBoxInfo.Text = $"{dlgReplace.textBox1.Text[0]}\t-> {dlgReplace.textBox2.Text[0]}\n{textBoxInfo.Text}";

            BufferListAdd();
        }

        private void BufferListAdd()
        {
            _bufferList.Add(textBox.Text);
            _indexList = _bufferList.Count - 1;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            statusLabel.Text = "...";

            if ((e.KeyCode & Keys.Escape) == Keys.Escape) Close();

            if ((e.KeyCode & Keys.Left) == Keys.Left && _indexList > 0)
            {
                _indexList--;
                statusLabel.Text = $"Left: {_indexList}";
                textBox.Text = _bufferList[_indexList];
            }

            if ((e.KeyCode & Keys.Right) == Keys.Right && _indexList < _bufferList.Count)
            {
                _indexList++;
                statusLabel.Text = $"Right: {_indexList}";
                textBox.Text = _bufferList[_indexList];
            }
        }

        private string OpenFile()
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return new StreamReader(openFileDialog.FileName).ReadToEnd();

            }
            catch (Exception)
            {
                // ignored
            }

            return textBox.Text;
        }

        private void menuSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}