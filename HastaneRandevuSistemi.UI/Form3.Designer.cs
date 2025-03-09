namespace HastaneRandevuSistemi.UI
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            cbDoktorlar = new ComboBox();
            txtHastaAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOlustur = new Button();
            btnZRaporu = new Button();
            lstRandevular = new ListBox();
            dtpRandevuTarihi = new DateTimePicker();
            label4 = new Label();
            txtSikayet = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(dtpRandevuTarihi);
            groupBox1.Controls.Add(cbDoktorlar);
            groupBox1.Controls.Add(txtSikayet);
            groupBox1.Controls.Add(txtHastaAdSoyad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 286);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // cbDoktorlar
            // 
            cbDoktorlar.FormattingEnabled = true;
            cbDoktorlar.Location = new Point(146, 133);
            cbDoktorlar.Name = "cbDoktorlar";
            cbDoktorlar.Size = new Size(229, 33);
            cbDoktorlar.TabIndex = 5;
            // 
            // txtHastaAdSoyad
            // 
            txtHastaAdSoyad.Location = new Point(147, 41);
            txtHastaAdSoyad.Name = "txtHastaAdSoyad";
            txtHastaAdSoyad.Size = new Size(228, 32);
            txtHastaAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 136);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 0;
            label3.Text = "Doktor :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 0;
            label2.Text = "Tarih :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = SystemColors.ActiveCaption;
            btnOlustur.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOlustur.Location = new Point(598, 251);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(126, 62);
            btnOlustur.TabIndex = 12;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = false;
            // 
            // btnZRaporu
            // 
            btnZRaporu.BackColor = SystemColors.ActiveCaption;
            btnZRaporu.Font = new Font("Verdana", 12F);
            btnZRaporu.Location = new Point(597, 27);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new Size(127, 58);
            btnZRaporu.TabIndex = 15;
            btnZRaporu.Text = "Z Raporu";
            btnZRaporu.UseVisualStyleBackColor = false;
            // 
            // lstRandevular
            // 
            lstRandevular.FormattingEnabled = true;
            lstRandevular.ItemHeight = 25;
            lstRandevular.Location = new Point(56, 330);
            lstRandevular.Name = "lstRandevular";
            lstRandevular.Size = new Size(687, 179);
            lstRandevular.TabIndex = 11;
            // 
            // dtpRandevuTarihi
            // 
            dtpRandevuTarihi.Location = new Point(146, 89);
            dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            dtpRandevuTarihi.Size = new Size(225, 32);
            dtpRandevuTarihi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 178);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 0;
            label4.Text = "Şikayet :";
            // 
            // txtSikayet
            // 
            txtSikayet.Location = new Point(146, 175);
            txtSikayet.Multiline = true;
            txtSikayet.Name = "txtSikayet";
            txtSikayet.Size = new Size(356, 95);
            txtSikayet.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 553);
            Controls.Add(groupBox1);
            Controls.Add(btnOlustur);
            Controls.Add(btnZRaporu);
            Controls.Add(lstRandevular);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpRandevuTarihi;
        private ComboBox cbDoktorlar;
        private TextBox txtHastaAdSoyad;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOlustur;
        private Button btnZRaporu;
        private ListBox lstRandevular;
        private TextBox txtSikayet;
        private Label label4;
    }
}