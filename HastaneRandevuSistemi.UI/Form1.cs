using HastaneRandevuSistemi.UI.Data;

namespace HastaneRandevuSistemi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Boþ bölüm adý veya bölüm açýklamasý kontrolü yapýldý.
            if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            {
                MesajYazdir("Bölüm adý veya bölüm açýklamasý boþ olmamalýdýr!");
                return;
            }

            Bolum bolum = new Bolum();
            bolum.Adi = txtBolumAdi.Text;
            bolum.Aciklamasi = txtBolumAciklamasi.Text;

            lstBolumler.Items.Add(bolum);  //Listeye eklendi.
            MesajYazdir("Doktor ekleme" +
                " iþlemi baþarýyla sonuçlandý");
            Temizle();
        }

        private void Temizle()
        {
            txtBolumAdi.Text = txtBolumAciklamasi.Text = string.Empty;
            txtBolumAdi.Select();
        }

        //Mesaj formatlarý metodda yazýldý. Her seferinde uzun uzun yazmaya gerek kalmadý.
        private void MesajYazdir(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Listbox'ta seçili item kontrolü
            if (lstBolumler.SelectedItem == null)
            {
                MesajYazdir("Lütfen silmek istediðiniz bölümü seçiniz!");
                return;
            }

            lstBolumler.Items.Remove(lstBolumler.SelectedItem); //Seçili itemi listboxtan sil
            MesajYazdir("Doktor silme iþlemi baþarýyla sonuçlandý");
            Temizle();
        }


        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            //Boþ olma kontrolü
            if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            {
                MesajYazdir("Bölüm adý veya bölüm açýklamasý boþ olmamalýdýr!");
                return;
            }
            //Seçili item kontrolü
            if (lstBolumler.SelectedItem == null)
            {
                MesajYazdir("Lütfen güncellemek istedðiniz bölümü seçiniz!");
                return;
            }

            Bolum guncellenecekBolum = new Bolum();
            guncellenecekBolum.Adi = txtBolumAdi.Text;
            guncellenecekBolum.Aciklamasi = txtBolumAciklamasi.Text;

            int seciliBolumIndeksi = lstBolumler.SelectedIndex; //Güncellenecek bölüm indeksi bulundu.
            lstBolumler.Items[seciliBolumIndeksi] = guncellenecekBolum; //Güncellenmesi istenen indekse yeni bilgiler atandý.

            MesajYazdir("Doktor güncelleme iþlemi baþarýyla sonuçlandý");
            Temizle();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            List<Bolum> bolumler = new List<Bolum>(); //Form2 ye bölümleri göndermek için liste tanýmladým.
            foreach (Bolum bolum in lstBolumler.Items)
            {
                bolumler.Add(bolum); // Listeye listboxtaki bölümleri ekledim.
            }

            Form2 form2 = new Form2(bolumler);
            form2.ShowDialog();
        }
    }
}
