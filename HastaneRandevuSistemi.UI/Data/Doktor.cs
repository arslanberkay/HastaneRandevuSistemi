using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.UI.Data
{
    public class Doktor
    {
        public string AdSoyad { get; set; }
        public string TelefonNumarasi { get; set; }
        public Bolum Bolum { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
