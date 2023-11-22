using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayit
{
    internal class Randevu
    {
        public String hastaAdi;
        public String hastaneAdi;
        public String doktorAdi;
        public String bolum;
        public String tarih;
        public String saat;

        public Randevu(String hastaAdi, String hastaneAdi, String doktorAdi, String bolum, String tarih, String saat)
        {
            this.hastaAdi = hastaAdi;
            this.hastaneAdi = hastaneAdi;
            this.doktorAdi = doktorAdi;
            this.bolum = bolum;
            this.tarih = tarih;
            this.saat = saat;
        }
    }
}
