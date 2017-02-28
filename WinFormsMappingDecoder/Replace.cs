using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMappingDecoder
{
    public partial class Replace : Form
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void Replace_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.Escape) == Keys.Escape) Close();
        }
    }
}
