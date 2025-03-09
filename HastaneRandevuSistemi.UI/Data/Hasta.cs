using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.UI.Data
{
    public class Hasta
    {
        public string AdSoyad { get; set; }
        public string Sikayet { get; set; }
        public Doktor Doktor { get; set; }
    }
}
