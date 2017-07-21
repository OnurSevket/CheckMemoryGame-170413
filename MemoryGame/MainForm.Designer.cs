namespace MemoryGame
{
    partial class MainForm
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
            this.BrainStormToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunaBaşlaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrainStormToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1074, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BrainStormToolStrip
            // 
            this.BrainStormToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunaBaşlaMenuItem,
            this.closeMenuItem});
            this.BrainStormToolStrip.Name = "BrainStormToolStrip";
            this.BrainStormToolStrip.Size = new System.Drawing.Size(110, 24);
            this.BrainStormToolStrip.Text = "Hafıza Oyunu";
            // 
            // oyunaBaşlaMenuItem
            // 
            this.oyunaBaşlaMenuItem.Name = "oyunaBaşlaMenuItem";
            this.oyunaBaşlaMenuItem.Size = new System.Drawing.Size(181, 26);
            this.oyunaBaşlaMenuItem.Text = "Oyuna Başla";
            this.oyunaBaşlaMenuItem.Click += new System.EventHandler(this.oyunaBaşlaMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeMenuItem.Text = "Çıkış";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 727);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BrainStormToolStrip;
        private System.Windows.Forms.ToolStripMenuItem oyunaBaşlaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
    }
}

