using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeriYapilariOdevi
{
    public class Yorum
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string Mesaj { get; set; }
        public byte Puan { get; set; }

        public Yorum (string _ad, string _soyad, string _eposta, string _adres, string _mesaj, byte _puan)
        {
            Ad = _ad;
            Soyad = _soyad;
            Eposta = _eposta;
            Adres = _adres;
            Mesaj = _mesaj;
            Puan = _puan;
        }
    }
}
