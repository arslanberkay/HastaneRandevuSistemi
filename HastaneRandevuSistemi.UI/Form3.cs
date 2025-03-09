﻿using HastaneRandevuSistemi.UI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi.UI
{
    public partial class Form3 : Form
    {

        public Form3(Doktor[] doktorlar)
        {
            InitializeComponent();
            foreach (Doktor doktor in doktorlar)
            {
                cbDoktorlar.Items.Add(doktor);
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdSoyad.Text) || string.IsNullOrWhiteSpace(txtSikayet.Text) || cbDoktorlar.SelectedItem == null)
            {
                MesajYazdir("Hastanın ad soyad şikayet bilgileri veya doktor bilgisi boş olmamalıdır!");
                return;
            }

            Hasta hasta = new Hasta();
            hasta.AdSoyad = txtHastaAdSoyad.Text;
            hasta.Sikayet = txtSikayet.Text;
            hasta.Doktor = cbDoktorlar.SelectedItem as Doktor;

            Randevu randevu = new Randevu();
            randevu.Hasta = hasta;
            randevu.Tarih = dtpRandevuTarihi.Value;

            lstRandevular.Items.Add(randevu);
            Temizle();
        }

        private void Temizle()
        {
            txtHastaAdSoyad.Text = txtSikayet.Text = string.Empty;
            cbDoktorlar.SelectedIndex = -1;
        }

        private void MesajYazdir(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {

        }
    }
}
