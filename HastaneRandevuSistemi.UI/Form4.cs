using ClosedXML.Excel;
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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }

        private Randevu[] randevular;
        // : this() ifadesi Form3 sınıfının parametresiz(varsayılan) kurucu metodunu çağırır.
        public Form4(Randevu[] randevularT) : this() //this() ifadesi önce varsayılan constructoru çağırır. 
        {
            randevular = randevularT;
            RandevuListesiniGuncelle(DateTime.Today, DateTime.Today); //Bugünün tarihine göre liste güncellenir.
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Form açıldığında ListView'in ayarları belirlenir.
            lvZRaporu.View = View.Details; //Detaylı görünüm için
            lvZRaporu.GridLines = true;   //HÜcreler arasında çizgiler için
            lvZRaporu.Columns.Add("Tarih", 150);  //Başlıklar için
            lvZRaporu.Columns.Add("Hasta Adı", 150);
            lvZRaporu.Columns.Add("Doktor Adı", 150);
            lvZRaporu.Columns.Add("Şikayet", 200);

            RandevuListesiniGuncelle(DateTime.Now.Date, DateTime.Now.Date);
        }

        private void RandevuListesiniGuncelle(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            lvZRaporu.Items.Clear(); // Her tarih değiştirmesi yapıldığında üstüne eklememesi için temizleniyor.

            //Randevular dizisi belirtilen tarih aralığına göre filtrelenir.(Sadece başlangıç ve bitiş tarihleri arasında olan randevular seçilir.)
            var filtrelenmisRandevular = randevular.Where(r => r.Tarih.Date >= baslangicTarihi && r.Tarih.Date <= bitisTarihi).ToList();

            foreach (var filtrelenmisRandevu in filtrelenmisRandevular)
            {
                //listViewItem nesnesi bir hastanın bilgilerini içerir.
                ListViewItem listViewItem = new ListViewItem();
                //ListViewItem listViewItem = new ListViewItem(filtrelenmisRandevu.Tarih.ToString());   // Bununla da başlanabilir.
                listViewItem.Text = filtrelenmisRandevu.Tarih.ToString();
                listViewItem.SubItems.Add(filtrelenmisRandevu.Hasta.AdSoyad);
                listViewItem.SubItems.Add(filtrelenmisRandevu.Hasta.Doktor.AdSoyad);
                listViewItem.SubItems.Add(filtrelenmisRandevu.Hasta.Doktor.Bolum.ToString());
                listViewItem.SubItems.Add(filtrelenmisRandevu.Hasta.Sikayet);

                lvZRaporu.Items.Add(listViewItem); //Her randevu ListView'e eklenir.
            }
        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            RandevuListesiniGuncelle(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date);
        }

        private void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            RandevuListesiniGuncelle(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date);
        }

        int excelDosyaNumarasi = 1;
        private void btnDokuman_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtpBaslangicTarihi.Value.Date;
                DateTime bitisTarihi = dtpBitisTarihi.Value.Date;

                RandevuListesiniGuncelle(baslangicTarihi, bitisTarihi);

                //ClosedXML kütüphanesini kullanarak ListView kontrolündeki verileri bir Excel dosyasına aktarıyor.
                using (var workbook = new XLWorkbook()) // Yeni bir Excel çalışma kitabı oluşturuluyor.
                {
                    var workSheet = workbook.AddWorksheet("ZRaporu"); //workbook içine ZRaporu adında yeni bir çalışma sayfası ekleniyor.

                    //Başlık satırının eklenmesi (İlk satırlara başlık deniyor)
                    workSheet.Cell(1, 1).Value = "Tarih";
                    workSheet.Cell(1, 2).Value = "Hasta Ad Soyad";
                    workSheet.Cell(1, 3).Value = "Doktor Ad Soyad";
                    workSheet.Cell(1, 4).Value = "Bölüm";
                    workSheet.Cell(1, 5).Value = "Şikayet";

                    int satir = 2; // lvZraporu adlı ListView kontrolünde bulunan veriler döngü ile Excel'e yazılıyor.
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        workSheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                        workSheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                        workSheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                        workSheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                        workSheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                        satir++;
                    }

                    //Excel Dosyasının Kaydedilmesi
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog()) //Kullanıcıdan Excel dosyasını kaydetmek istediği yeri seçmesi için bir SaveFileDialog penceresi açılıyor.
                    {
                        saveFileDialog.Filter = "Excel Files|*xlsx"; //Sadece .xlsx uzantılı dosyaların kaydedilmesine izin veriliyor.
                        saveFileDialog.Title = "Excel Dosyasını Kaydet"; // Pencere başlığı belirleniyor.
                        saveFileDialog.FileName = $"ZRaporu{excelDosyaNumarasi++}.xlsx"; //Varsayılan dosya adı ayarlanıyor. Üst üste kaydetmemesi için her seferinde dosya adının sonuna sayı koyarak ilerliyor.

                        //Kullanıcının seçtiği konuma kaydetme
                        if (saveFileDialog.ShowDialog() == DialogResult.OK) //Kullanıcı dosya kaydetme işlemini onaylarsa
                        {
                            string filePath = saveFileDialog.FileName; //Dosyanın kaydedileceği yolu alır.
                            workbook.SaveAs(filePath); //Excel dosyası belirtilen konuma kaydedilir.
                            MessageBox.Show("Excel dosyası başarıyla oluşturuldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
