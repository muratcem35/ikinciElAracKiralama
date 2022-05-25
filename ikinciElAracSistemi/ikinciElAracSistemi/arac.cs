using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemi
{
    class arac : aracDonanim
    {
        public string marka { get; set; }
        public int model { get; set; }
        public string yakitTuru { get; set; }
        public int motor { get; set; }
        public string sanziman { get; set; }
        public int km { get; set; }
        public int satisFiyati { get; set; }
        public string resim { get; set; }

    }
}
