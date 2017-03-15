using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionZoneData
{
    public class TotaalPerJaarPerMerk
    {
        public int Jaar { get; set; }
        public string Merk { get; set; }
        public decimal TotBesteld { get; set; }
        public decimal TotVoorzien { get; set; }
        public decimal TotBetaald { get; set; }

    }
}
