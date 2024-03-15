using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeriYapilariOdevi
{
    public class Rezervasyon
    {
        public string otelIsmi;
        public int odaNo;
        public int kisiSayisi;
        public int gunSayisi;
        public int toplamfiyat;
        public Musteri[] musteriler;

        public Rezervasyon( string _otelIsmi, int _odaNo, int _kisiSayisi, int _gunSayisi, int _toplamfiyat, Musteri [] _musteriler) 
        {
            otelIsmi = _otelIsmi;
            odaNo = _odaNo;
            kisiSayisi = _kisiSayisi;
            gunSayisi = _gunSayisi;
            toplamfiyat = _toplamfiyat;
            musteriler = _musteriler;
        }
    }
}
