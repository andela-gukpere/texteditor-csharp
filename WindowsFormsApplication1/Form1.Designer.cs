namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecmascriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleSheetcssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSS20inHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSS21incssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSPNETCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.documentTemplatesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // documentTemplatesToolStripMenuItem
            // 
            this.documentTemplatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLTemplatesToolStripMenuItem,
            this.styleSheetcssToolStripMenuItem,
            this.aSPNETCToolStripMenuItem});
            this.documentTemplatesToolStripMenuItem.Name = "documentTemplatesToolStripMenuItem";
            this.documentTemplatesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.documentTemplatesToolStripMenuItem.Text = "&Document Templates";
            // 
            // hTMLTemplatesToolStripMenuItem
            // 
            this.hTMLTemplatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.javaScriptToolStripMenuItem,
            this.ecmascriptToolStripMenuItem,
            this.vBScriptToolStripMenuItem,
            this.jScriptToolStripMenuItem});
            this.hTMLTemplatesToolStripMenuItem.Name = "hTMLTemplatesToolStripMenuItem";
            this.hTMLTemplatesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hTMLTemplatesToolStripMenuItem.Text = "HTML Templates (.html)";
            this.hTMLTemplatesToolStripMenuItem.Click += new System.EventHandler(this.hTMLTemplatesToolStripMenuItem_Click);
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.javaScriptToolStripMenuItem.Text = "JavaScript";
            this.javaScriptToolStripMenuItem.Click += new System.EventHandler(this.javaScriptToolStripMenuItem_Click);
            // 
            // ecmascriptToolStripMenuItem
            // 
            this.ecmascriptToolStripMenuItem.Name = "ecmascriptToolStripMenuItem";
            this.ecmascriptToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ecmascriptToolStripMenuItem.Text = "Ecmascript";
            this.ecmascriptToolStripMenuItem.Click += new System.EventHandler(this.ecmascriptToolStripMenuItem_Click);
            // 
            // vBScriptToolStripMenuItem
            // 
            this.vBScriptToolStripMenuItem.Name = "vBScriptToolStripMenuItem";
            this.vBScriptToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.vBScriptToolStripMenuItem.Text = "VBScript";
            this.vBScriptToolStripMenuItem.Click += new System.EventHandler(this.vBScriptToolStripMenuItem_Click);
            // 
            // jScriptToolStripMenuItem
            // 
            this.jScriptToolStripMenuItem.Name = "jScriptToolStripMenuItem";
            this.jScriptToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.jScriptToolStripMenuItem.Text = "JScript";
            this.jScriptToolStripMenuItem.Click += new System.EventHandler(this.jScriptToolStripMenuItem_Click);
            // 
            // styleSheetcssToolStripMenuItem
            // 
            this.styleSheetcssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSS20inHtmlToolStripMenuItem,
            this.cSS21incssToolStripMenuItem});
            this.styleSheetcssToolStripMenuItem.Name = "styleSheetcssToolStripMenuItem";
            this.styleSheetcssToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.styleSheetcssToolStripMenuItem.Text = "CSS Style Sheet";
            // 
            // cSS20inHtmlToolStripMenuItem
            // 
            this.cSS20inHtmlToolStripMenuItem.Name = "cSS20inHtmlToolStripMenuItem";
            this.cSS20inHtmlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cSS20inHtmlToolStripMenuItem.Text = "CSS 2.0 (in .html)";
            this.cSS20inHtmlToolStripMenuItem.Click += new System.EventHandler(this.cSS20inHtmlToolStripMenuItem_Click);
            // 
            // cSS21incssToolStripMenuItem
            // 
            this.cSS21incssToolStripMenuItem.Name = "cSS21incssToolStripMenuItem";
            this.cSS21incssToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cSS21incssToolStripMenuItem.Text = "CSS 2.1 (in .css)";
            this.cSS21incssToolStripMenuItem.Click += new System.EventHandler(this.cSS21incssToolStripMenuItem_Click);
            // 
            // aSPNETCToolStripMenuItem
            // 
            this.aSPNETCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vBNETToolStripMenuItem,
            this.cNETToolStripMenuItem});
            this.aSPNETCToolStripMenuItem.Name = "aSPNETCToolStripMenuItem";
            this.aSPNETCToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aSPNETCToolStripMenuItem.Text = "ASP.NET 2.0";
            // 
            // vBNETToolStripMenuItem
            // 
            this.vBNETToolStripMenuItem.Name = "vBNETToolStripMenuItem";
            this.vBNETToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.vBNETToolStripMenuItem.Text = "VB.NET";
            this.vBNETToolStripMenuItem.Click += new System.EventHandler(this.vBNETToolStripMenuItem_Click);
            // 
            // cNETToolStripMenuItem
            // 
            this.cNETToolStripMenuItem.Name = "cNETToolStripMenuItem";
            this.cNETToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cNETToolStripMenuItem.Text = "C#.NET";
            this.cNETToolStripMenuItem.Click += new System.EventHandler(this.cNETToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.EnableAutoDragDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(662, 419);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEXT EDITOR PRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecmascriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleSheetcssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSS20inHtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSS21incssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSPNETCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBNETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cNETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}

