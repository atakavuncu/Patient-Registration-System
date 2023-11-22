using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayit
{
    internal class Doktor
    {
        public String doktorTamAdi;
        public String dogumTarihi;
        public List<string> uzmanlikAlanlari;

        public Doktor(String doktorTamAdi, String dogumTarihi, List<string> uzmanlikAlanlari)
        {
            this.doktorTamAdi = doktorTamAdi;
            this.dogumTarihi = dogumTarihi;
            this.uzmanlikAlanlari = uzmanlikAlanlari;
        }
    }
}
