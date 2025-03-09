using HastaneRandevuSistemi.UI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi.UI
{
    public partial class Form2 : Form
    {
        public Form2(List<Bolum> bolumler)
        {
            InitializeComponent();

            foreach (Bolum bolum in bolumler) // Liste ile aktardığım verileri combobox'a taşıdım.
            {
                cbBolumler.Items.Add(bolum);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorAdSoyad.Text) || string.IsNullOrWhiteSpace(mtxtDoktorTelefonNo.Text))
            {
                MesajYazdir("Doktor ad soyad veya telefon numarası boş olmamalıdır!");
                return;
            }

            //Doktor bilgileri atandı.
            Doktor doktor = new Doktor();
            doktor.AdSoyad = txtDoktorAdSoyad.Text;
            doktor.TelefonNumarasi = mtxtDoktorTelefonNo.Text;
            doktor.Bolum = cbBolumler.SelectedItem as Bolum;

            lstDoktorlar.Items.Add(doktor);  //ListBox'a eklendi.
            MesajYazdir("Doktor ekleme işlemi başarıyla sonuçlandı");
            Temizle();
        }

        private void Temizle()
        {
            txtDoktorAdSoyad.Text = mtxtDoktorTelefonNo.Text = string.Empty;
            cbBolumler.SelectedItem = null;
        }

        private void MesajYazdir(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null)
            {
                MesajYazdir("Lütfen silmek istediğiniz doktoru seçiniz!");
                return;
            }

            lstDoktorlar.Items.Remove(lstDoktorlar.SelectedItem); // Seçili doktoru listboxtan siler.
            MesajYazdir("Doktor silme işlemi başarıyla sonuçlandı");
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorAdSoyad.Text) || string.IsNullOrWhiteSpace(mtxtDoktorTelefonNo.Text))
            {
                MesajYazdir("Doktor ad soyad veya telefon numarası boş olmamalıdır!");
                return;
            }
            if (lstDoktorlar.SelectedItem == null)
            {
                MesajYazdir("Lütfen güncellemek istediğiniz doktoru seçiniz!");
                return;
            }

            //Güncellenecek doktor bilgileri
            Doktor guncellenecekDoktor = new Doktor();
            guncellenecekDoktor.AdSoyad = txtDoktorAdSoyad.Text;
            guncellenecekDoktor.TelefonNumarasi = mtxtDoktorTelefonNo.Text;
            guncellenecekDoktor.Bolum = cbBolumler.SelectedItem as Bolum;

            int guncellenecekDoktorIndeksi = lstDoktorlar.SelectedIndex; // Güncellenecek olan doktor indeksi
            lstDoktorlar.Items[guncellenecekDoktorIndeksi] = guncellenecekDoktor;

            MesajYazdir("Doktor güncelleme işlemi başarıyla sonuçlandı.");
            Temizle();

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Doktor[] doktorlar = new Doktor[0];
            foreach (Doktor doktor in lstDoktorlar.Items)
            {
                Array.Resize(ref doktorlar, doktorlar.Length + 1);
                doktorlar[doktorlar.Length - 1] = doktor;
            }

            Form3 form3 = new Form3(doktorlar);
            form3.ShowDialog();
        }
    }
}
