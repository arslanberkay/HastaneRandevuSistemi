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
            //Bo� b�l�m ad� veya b�l�m a��klamas� kontrol� yap�ld�.
            if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            {
                MesajYazdir("B�l�m ad� veya b�l�m a��klamas� bo� olmamal�d�r!");
                return;
            }

            Bolum bolum = new Bolum();
            bolum.Adi = txtBolumAdi.Text;
            bolum.Aciklamasi = txtBolumAciklamasi.Text;

            lstBolumler.Items.Add(bolum);  //Listeye eklendi.
            MesajYazdir("Doktor ekleme" +
                " i�lemi ba�ar�yla sonu�land�");
            Temizle();
        }

        private void Temizle()
        {
            txtBolumAdi.Text = txtBolumAciklamasi.Text = string.Empty;
            txtBolumAdi.Select();
        }

        //Mesaj formatlar� metodda yaz�ld�. Her seferinde uzun uzun yazmaya gerek kalmad�.
        private void MesajYazdir(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Listbox'ta se�ili item kontrol�
            if (lstBolumler.SelectedItem == null)
            {
                MesajYazdir("L�tfen silmek istedi�iniz b�l�m� se�iniz!");
                return;
            }

            lstBolumler.Items.Remove(lstBolumler.SelectedItem); //Se�ili itemi listboxtan sil
            MesajYazdir("Doktor silme i�lemi ba�ar�yla sonu�land�");
            Temizle();
        }


        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            //Bo� olma kontrol�
            if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            {
                MesajYazdir("B�l�m ad� veya b�l�m a��klamas� bo� olmamal�d�r!");
                return;
            }
            //Se�ili item kontrol�
            if (lstBolumler.SelectedItem == null)
            {
                MesajYazdir("L�tfen g�ncellemek isted�iniz b�l�m� se�iniz!");
                return;
            }

            Bolum guncellenecekBolum = new Bolum();
            guncellenecekBolum.Adi = txtBolumAdi.Text;
            guncellenecekBolum.Aciklamasi = txtBolumAciklamasi.Text;

            int seciliBolumIndeksi = lstBolumler.SelectedIndex; //G�ncellenecek b�l�m indeksi bulundu.
            lstBolumler.Items[seciliBolumIndeksi] = guncellenecekBolum; //G�ncellenmesi istenen indekse yeni bilgiler atand�.

            MesajYazdir("Doktor g�ncelleme i�lemi ba�ar�yla sonu�land�");
            Temizle();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            List<Bolum> bolumler = new List<Bolum>(); //Form2 ye b�l�mleri g�ndermek i�in liste tan�mlad�m.
            foreach (Bolum bolum in lstBolumler.Items)
            {
                bolumler.Add(bolum); // Listeye listboxtaki b�l�mleri ekledim.
            }

            Form2 form2 = new Form2(bolumler);
            form2.ShowDialog();
        }
    }
}
