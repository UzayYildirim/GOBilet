using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzayYildirim_GorselProje
{
    public class ucus // Seçilen uçuşun bilgileri.
    {
        public string firma { get; set; }
        public string saat { get; set; }
        public string tarih { get; set; }
        public string kalkis { get; set; }
        public string varis { get; set; }
        public int fiyat { get; set; }
        public int ksayisi { get; set; }
        public bool gidisdonus { get; set; }
    }
}
