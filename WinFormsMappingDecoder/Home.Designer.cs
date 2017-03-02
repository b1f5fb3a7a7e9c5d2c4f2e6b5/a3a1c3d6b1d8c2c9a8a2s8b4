namespace WinFormsMappingDecoder
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlphabet = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuAlphabet});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(769, 24);
            this.menu.TabIndex = 0;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFile,
            this.menuSaveFile,
            this.separator,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Enabled = false;
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(152, 22);
            this.menuOpenFile.Text = "Open File";
            this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(152, 22);
            this.menuSaveFile.Text = "Save File";
            this.menuSaveFile.Click += new System.EventHandler(this.menuSaveFile_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuAlphabet
            // 
            this.menuAlphabet.Name = "menuAlphabet";
            this.menuAlphabet.Size = new System.Drawing.Size(67, 20);
            this.menuAlphabet.Text = "Alphabet";
            this.menuAlphabet.Click += new System.EventHandler(this.menuAlphabet_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 413);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(769, 22);
            this.status.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.DetectUrls = false;
            this.textBox.HideSelection = false;
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Name = "textBox";
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(593, 377);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "";
            this.textBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.89337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.10663F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 383);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Location = new System.Drawing.Point(602, 3);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(164, 377);
            this.textBoxInfo.TabIndex = 3;
            this.textBoxInfo.Text = "";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(769, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Mapping Decoder ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuAlphabet;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.MenuStrip menu;
        
    }
}