using System;
using System.IO;
using System.Windows.Forms;
using WinFormsMappingDecoder.Properties;

namespace WinFormsMappingDecoder
{
    public partial class Home : Form
    {
        private readonly HomeData _data = new HomeData(); 

        public Home()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown ||
                MessageBox.Show(string.Format(Resources.Home_OnFormClosing_, Text), //Text - base.Text
                    @"Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes) return;

            e.Cancel = true;
        }

        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            textBox.Text = OpenFile();
            textBoxInfo.Text += _data.SetAlphabet(textBox.Text);
        }

        private void menuAlphabet_Click(object sender, EventArgs e)
        {
            var textFile = OpenFile();
            textBoxInfo.Text = _data.SetAnalyzedText(textFile);
            menuOpenFile.Enabled = true;
        }

        private void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox.SelectionLength != 1) return;

            var dlgReplace = new Replace(textBox.SelectedText, textBox.SelectedText.ToLower());

            if (dlgReplace.ShowDialog() != DialogResult.OK) return;

            TextBoxAdd(dlgReplace.TextReplace(textBox.Text));

            textBoxInfo.Text = dlgReplace.TextBoxInfoAdd(textBoxInfo.Text);
        }

        private void TextBoxAdd(string text)
        {
            textBox.Text = text;
            _data.SetBufferList(text);
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
            if (textBox.Text.Trim().Equals(string.Empty)) return;
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

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape) Close();
            if ((e.KeyCode & Keys.Left) == Keys.Left)
                textBox.Text = _data.Сancel_CtrlZ() ?? textBox.Text;
            if ((e.KeyCode & Keys.Right) == Keys.Right)
                textBox.Text = _data.Return_CtrlY() ?? textBox.Text;
        }
    }
}