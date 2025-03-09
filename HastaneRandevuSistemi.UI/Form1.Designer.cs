namespace HastaneRandevuSistemi.UI
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
            label1 = new Label();
            label2 = new Label();
            lstBolumler = new ListBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtBolumAdi = new TextBox();
            txtBolumAciklamasi = new TextBox();
            groupBox1 = new GroupBox();
            btnGec = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 92);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 0;
            label2.Text = "Açıklaması :";
            // 
            // lstBolumler
            // 
            lstBolumler.FormattingEnabled = true;
            lstBolumler.ItemHeight = 25;
            lstBolumler.Location = new Point(31, 250);
            lstBolumler.Name = "lstBolumler";
            lstBolumler.Size = new Size(687, 154);
            lstBolumler.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Font = new Font("Verdana", 12F);
            btnEkle.Location = new Point(583, 53);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 51);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Verdana", 12F);
            btnSil.Location = new Point(583, 110);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(122, 50);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Font = new Font("Verdana", 12F);
            btnGuncelle.Location = new Point(583, 166);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 48);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Location = new Point(152, 41);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(375, 32);
            txtBolumAdi.TabIndex = 3;
            // 
            // txtBolumAciklamasi
            // 
            txtBolumAciklamasi.Location = new Point(152, 92);
            txtBolumAciklamasi.Multiline = true;
            txtBolumAciklamasi.Name = "txtBolumAciklamasi";
            txtBolumAciklamasi.Size = new Size(375, 110);
            txtBolumAciklamasi.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtBolumAciklamasi);
            groupBox1.Controls.Add(txtBolumAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 221);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bölüm Bilgileri";
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.ActiveCaption;
            btnGec.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGec.Location = new Point(583, 410);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(135, 48);
            btnGec.TabIndex = 2;
            btnGec.Text = ">>>";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(755, 480);
            Controls.Add(groupBox1);
            Controls.Add(btnGec);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lstBolumler);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstBolumler;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtBolumAdi;
        private TextBox txtBolumAciklamasi;
        private GroupBox groupBox1;
        private Button btnGec;
    }
}
