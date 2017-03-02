using System;
using System.Windows.Forms;

namespace WinFormsMappingDecoder
{
    public partial class Replace : Form
    {
        public Replace(string left, string right)
        {
            InitializeComponent();
            textBox1.Text = left;
            textBox2.Text = right;
        }

        private void Replace_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape) Close();
        }

        private void Replace_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        internal string TextReplace(string text)
        {
            return text.Replace(textBox1.Text[0], textBox2.Text[0]);
        }

        internal string TextBoxInfoAdd(string text)
        {
            return $"{textBox1.Text[0]}\t-> {textBox2.Text[0]}\n{text}";
        }
    }
}
