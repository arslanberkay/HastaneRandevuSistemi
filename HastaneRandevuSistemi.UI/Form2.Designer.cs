namespace HastaneRandevuSistemi.UI
{
    partial class Form2
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
            cbBolumler = new ComboBox();
            mtxtDoktorTelefonNo = new MaskedTextBox();
            txtDoktorAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGec = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            lstDoktorlar = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(cbBolumler);
            groupBox1.Controls.Add(mtxtDoktorTelefonNo);
            groupBox1.Controls.Add(txtDoktorAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(66, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 203);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgileri";
            // 
            // cbBolumler
            // 
            cbBolumler.FormattingEnabled = true;
            cbBolumler.Location = new Point(151, 133);
            cbBolumler.Name = "cbBolumler";
            cbBolumler.Size = new Size(239, 33);
            cbBolumler.TabIndex = 5;
            // 
            // mtxtDoktorTelefonNo
            // 
            mtxtDoktorTelefonNo.Location = new Point(151, 89);
            mtxtDoktorTelefonNo.Mask = "(999) 000-0000";
            mtxtDoktorTelefonNo.Name = "mtxtDoktorTelefonNo";
            mtxtDoktorTelefonNo.Size = new Size(239, 32);
            mtxtDoktorTelefonNo.TabIndex = 4;
            // 
            // txtDoktorAdSoyad
            // 
            txtDoktorAdSoyad.Location = new Point(152, 41);
            txtDoktorAdSoyad.Name = "txtDoktorAdSoyad";
            txtDoktorAdSoyad.Size = new Size(238, 32);
            txtDoktorAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 136);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 0;
            label3.Text = "Bölüm :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 92);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 0;
            label2.Text = "Telefon No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.ActiveCaption;
            btnGec.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGec.Location = new Point(553, 412);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(135, 48);
            btnGec.TabIndex = 6;
            btnGec.Text = ">>>";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Font = new Font("Verdana", 12F);
            btnGuncelle.Location = new Point(529, 164);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 48);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Verdana", 12F);
            btnSil.Location = new Point(529, 108);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(122, 50);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Font = new Font("Verdana", 12F);
            btnEkle.Location = new Point(529, 51);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 51);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstDoktorlar
            // 
            lstDoktorlar.FormattingEnabled = true;
            lstDoktorlar.ItemHeight = 25;
            lstDoktorlar.Location = new Point(37, 252);
            lstDoktorlar.Name = "lstDoktorlar";
            lstDoktorlar.Size = new Size(651, 154);
            lstDoktorlar.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(730, 477);
            Controls.Add(groupBox1);
            Controls.Add(btnGec);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstDoktorlar);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDoktorAdSoyad;
        private Label label2;
        private Label label1;
        private Button btnGec;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private ListBox lstDoktorlar;
        private MaskedTextBox mtxtDoktorTelefonNo;
        private Label label3;
        private ComboBox cbBolumler;
    }
}