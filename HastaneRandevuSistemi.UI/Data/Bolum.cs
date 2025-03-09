using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.UI.Data
{
    public class Bolum
    {
        public string Adi { get; set; }
        public string Aciklamasi { get; set; }

        public override string ToString()
        {
            return $"{Adi}";
        }
    }
}
