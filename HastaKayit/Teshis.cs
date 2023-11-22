using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayit
{
    internal class Teshis
    {
        public String hastaAdi;
        public String doktorAdi;
        public String hastaneAdi;
        public String tarih;
        public String teshis;

        public Teshis(String hastaAdi, String hastaneAdi, String doktorAdi, String teshis, String tarih)
        {
            this.hastaAdi = hastaAdi;
            this.hastaneAdi = hastaneAdi;
            this.doktorAdi = doktorAdi;
            this.teshis = teshis;
            this.tarih = tarih;
        }
    }
}
