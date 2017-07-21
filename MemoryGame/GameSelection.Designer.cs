namespace MemoryGame
{
    partial class GameSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSelection));
            this.cmbDifficultyLevelSelect = new System.Windows.Forms.ComboBox();
            this.cmbBoxNumberSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSelection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDifficultyLevelSelect
            // 
            this.cmbDifficultyLevelSelect.FormattingEnabled = true;
            this.cmbDifficultyLevelSelect.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbDifficultyLevelSelect.Location = new System.Drawing.Point(410, 163);
            this.cmbDifficultyLevelSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDifficultyLevelSelect.Name = "cmbDifficultyLevelSelect";
            this.cmbDifficultyLevelSelect.Size = new System.Drawing.Size(160, 24);
            this.cmbDifficultyLevelSelect.TabIndex = 4;
            // 
            // cmbBoxNumberSelect
            // 
            this.cmbBoxNumberSelect.FormattingEnabled = true;
            this.cmbBoxNumberSelect.Items.AddRange(new object[] {
            "5x5",
            "10x10",
            "20x20"});
            this.cmbBoxNumberSelect.Location = new System.Drawing.Point(207, 163);
            this.cmbBoxNumberSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxNumberSelect.Name = "cmbBoxNumberSelect";
            this.cmbBoxNumberSelect.Size = new System.Drawing.Size(160, 24);
            this.cmbBoxNumberSelect.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kutu Sayısı Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zorluk Seviyesi Seçimi";
            // 
            // btnSaveSelection
            // 
            this.btnSaveSelection.Location = new System.Drawing.Point(320, 241);
            this.btnSaveSelection.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSelection.Name = "btnSaveSelection";
            this.btnSaveSelection.Size = new System.Drawing.Size(123, 52);
            this.btnSaveSelection.TabIndex = 7;
            this.btnSaveSelection.Text = "Kaydet";
            this.btnSaveSelection.UseVisualStyleBackColor = true;
            this.btnSaveSelection.Click += new System.EventHandler(this.btnSaveSelection_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GameSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 387);
            this.Controls.Add(this.btnSaveSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDifficultyLevelSelect);
            this.Controls.Add(this.cmbBoxNumberSelect);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameSelection";
            this.Text = "Form2";
          
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDifficultyLevelSelect;
        private System.Windows.Forms.ComboBox cmbBoxNumberSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSelection;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}