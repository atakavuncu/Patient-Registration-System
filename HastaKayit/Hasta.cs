using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayit
{
    
    internal class Hasta
    {
        public String hastaTamAdi;
        public String adres;
        public String email;
        public String telefon;
        public String meslek;
        public String cinsiyet;

        public Hasta(String hastaTamAdi, String adres, String email, String telefon, String meslek, String cinsiyet)
        {
            this.hastaTamAdi = hastaTamAdi;
            this.adres = adres;
            this.email = email;
            this.telefon = telefon;
            this.meslek = meslek;
            this.cinsiyet = cinsiyet;
        }
    }
}
