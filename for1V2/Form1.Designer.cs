namespace for1V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            lbAd = new ListBox();
            txtEkle = new TextBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Location = new Point(180, 75);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 41);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lbAd
            // 
            lbAd.BackColor = SystemColors.Menu;
            lbAd.FormattingEnabled = true;
            lbAd.ItemHeight = 20;
            lbAd.Location = new Point(12, 12);
            lbAd.Name = "lbAd";
            lbAd.Size = new Size(150, 304);
            lbAd.TabIndex = 1;
            // 
            // txtEkle
            // 
            txtEkle.Location = new Point(180, 12);
            txtEkle.Name = "txtEkle";
            txtEkle.Size = new Size(125, 27);
            txtEkle.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(325, 332);
            Controls.Add(txtEkle);
            Controls.Add(lbAd);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private ListBox lbAd;
        private TextBox txtEkle;
    }
}