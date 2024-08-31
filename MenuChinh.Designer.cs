namespace MyForm
{
    partial class frmChinh
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
            this.khangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmTrungTam = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // khangToolStripMenuItem
            // 
            this.khangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmTrungTam,
            this.bai2ToolStripMenuItem});
            this.khangToolStripMenuItem.Name = "khangToolStripMenuItem";
            this.khangToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.khangToolStripMenuItem.Text = "DANG NGUYEN PHUC KHANG";
            // 
            // frmTrungTam
            // 
            this.frmTrungTam.Name = "frmTrungTam";
            this.frmTrungTam.Size = new System.Drawing.Size(180, 22);
            this.frmTrungTam.Text = "Bai1";
            this.frmTrungTam.Click += new System.EventHandler(this.bai1ToolStripMenuItem_Click);
            // 
            // bai2ToolStripMenuItem
            // 
            this.bai2ToolStripMenuItem.Name = "bai2ToolStripMenuItem";
            this.bai2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bai2ToolStripMenuItem.Text = "Bai2";
            this.bai2ToolStripMenuItem.Click += new System.EventHandler(this.bai2ToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Menu Chinh";
            this.Load += new System.EventHandler(this.Vidu2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmTrungTam;
        private System.Windows.Forms.ToolStripMenuItem bai2ToolStripMenuItem;
    }
}