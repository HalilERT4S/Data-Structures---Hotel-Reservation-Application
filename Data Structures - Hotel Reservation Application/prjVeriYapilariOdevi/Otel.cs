using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeriYapilariOdevi
{
    public class Otel
    {
        public LinkedList<Oda> Odalar { get; set; } = new LinkedList<Oda>();
        public LinkedList<Personel> Personeller { get; set; } = new LinkedList<Personel>();
        public LinkedList<Yorum> Yorumlar { get; set; } = new LinkedList<Yorum>();
        public string Ad { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public byte YildizSayisi { get; set; }
        public byte ProfilResmi { get; set; }
        public ushort OdaSayisi { get; set; }
        public byte Puan { get; set; }

        public void OdaEkle(Oda oda)
        {
            Odalar.AddFirst(oda);
        }
        public void PersonelEkle(Personel per)
        {
            Personeller.AddFirst(per);
        }
        public void PersonelSil(Personel per)
        {
            Personeller.Remove(per);
        }
    }
}
