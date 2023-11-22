using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayit
{
    internal class Hastane
    {
        public String ad;
        public String sehir;
        public decimal doktorSayisi;
        public String telefon;
        public List<String> bolumler;

        public Hastane(String ad, String sehir, decimal doktorSayisi, String telefon, List<String> bolumler)
        {
            this.ad = ad;
            this.sehir = sehir;
            this.doktorSayisi = doktorSayisi;
            this.telefon = telefon;
            this.bolumler = bolumler;
        }
    }
}
