namespace ablak2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elrendezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lépcsőzetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mozaikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.elrendezésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.megnyitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.újToolStripMenuItem.Text = "új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // megnyitToolStripMenuItem
            // 
            this.megnyitToolStripMenuItem.Name = "megnyitToolStripMenuItem";
            this.megnyitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.megnyitToolStripMenuItem.Text = "megnyit";
            this.megnyitToolStripMenuItem.Click += new System.EventHandler(this.megnyitToolStripMenuItem_Click);
            // 
            // elrendezésToolStripMenuItem
            // 
            this.elrendezésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lépcsőzetesToolStripMenuItem,
            this.mozaikToolStripMenuItem});
            this.elrendezésToolStripMenuItem.Name = "elrendezésToolStripMenuItem";
            this.elrendezésToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.elrendezésToolStripMenuItem.Text = "Elrendezés";
            // 
            // lépcsőzetesToolStripMenuItem
            // 
            this.lépcsőzetesToolStripMenuItem.Name = "lépcsőzetesToolStripMenuItem";
            this.lépcsőzetesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lépcsőzetesToolStripMenuItem.Text = "lépcsőzetes";
            this.lépcsőzetesToolStripMenuItem.Click += new System.EventHandler(this.lépcsőzetesToolStripMenuItem_Click);
            // 
            // mozaikToolStripMenuItem
            // 
            this.mozaikToolStripMenuItem.Name = "mozaikToolStripMenuItem";
            this.mozaikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mozaikToolStripMenuItem.Text = "mozaik";
            this.mozaikToolStripMenuItem.Click += new System.EventHandler(this.mozaikToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 372);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elrendezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lépcsőzetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mozaikToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

