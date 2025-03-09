namespace HastaneRandevuSistemi.UI
{
    partial class Form4
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
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            lvZRaporu = new ListView();
            btnDokuman = new Button();
            SuspendLayout();
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Font = new Font("Verdana", 12F);
            dtpBaslangicTarihi.Location = new Point(49, 46);
            dtpBaslangicTarihi.Margin = new Padding(5, 4, 5, 4);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(337, 32);
            dtpBaslangicTarihi.TabIndex = 0;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Font = new Font("Verdana", 12F);
            dtpBitisTarihi.Location = new Point(773, 46);
            dtpBitisTarihi.Margin = new Padding(5, 4, 5, 4);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(337, 32);
            dtpBitisTarihi.TabIndex = 0;
            // 
            // lvZRaporu
            // 
            lvZRaporu.Location = new Point(49, 113);
            lvZRaporu.Name = "lvZRaporu";
            lvZRaporu.Size = new Size(1061, 278);
            lvZRaporu.TabIndex = 1;
            lvZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // btnDokuman
            // 
            btnDokuman.Location = new Point(928, 415);
            btnDokuman.Name = "btnDokuman";
            btnDokuman.Size = new Size(182, 65);
            btnDokuman.TabIndex = 2;
            btnDokuman.Text = "Döküman";
            btnDokuman.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 501);
            Controls.Add(btnDokuman);
            Controls.Add(lvZRaporu);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private ListView lvZRaporu;
        private Button btnDokuman;
    }
}