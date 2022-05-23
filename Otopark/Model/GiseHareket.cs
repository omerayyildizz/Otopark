using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    class GiseHareket
    {
        public int Id { get; set; }
        public int AracID { get; set; }
        public int TarifeID { get; set; }
        public DateTime GirisT { get; set; }
        public DateTime CikisT { get; set; }
        public decimal AlinacakUcret { get; set; }
    }
}
