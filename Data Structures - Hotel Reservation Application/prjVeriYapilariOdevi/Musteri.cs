using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeriYapilariOdevi
{
    public class Musteri
    {
        public string tckn;
        public string ad;
        public string soyAd;
        public string tel;
        public string adres;
        public string eposta;

        public Musteri (string _tckn, string _ad, string _soyAd, string _tel, string _adres, string _eposta) 
        {
            tckn = _tckn;
            ad = _ad;
            soyAd = _soyAd;
            tel = _tel;
            adres = _adres;
            eposta = _eposta;
        }
    }
}
