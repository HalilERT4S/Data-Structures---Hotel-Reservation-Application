using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeriYapilariOdevi
{
    public class İkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        public İkiliAramaAgaci()
        {
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public List<Otel> DugumleriYazdir()
        {
            return oteller;
        }
        List<Otel> oteller = new List<Otel>();
        public void PreOrder()
        {
            oteller.Clear();
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            oteller.Clear();
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            oteller.Add((Otel)dugum.veri);
        }
        public void PostOrder()
        {
            oteller.Clear();
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(Otel otel)
        {
            bool kontrol = true;
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;
            int sonuc;
            while (tempSearch != null)
            {
                sonuc = String.Compare(otel.Ad, ((Otel)tempSearch.veri).Ad);
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (sonuc == 0)
                {
                    İkiliAramaAgacDugumu eklenecek1 = new İkiliAramaAgacDugumu(otel);
                    tempParent = eklenecek1;
                    kontrol = false;
                    break;
                }
                else if (sonuc == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(otel);
            //Ağaç boş, köke ekle
            if(kontrol)
            {
                if (kok == null)
                    kok = eklenecek;
                else
                {
                    sonuc = String.Compare(otel.Ad, ((Otel)tempParent.veri).Ad);
                    if (sonuc == -1)
                        tempParent.sol = eklenecek;
                    else
                        tempParent.sag = eklenecek;
                }
            }
        }
        public İkiliAramaAgacDugumu Ara(string anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum,
                                            string anahtar)
        {
            if (dugum == null)
                return null;
            else
            {
                int sonuc = String.Compare(((Otel)dugum.veri).Ad, anahtar);
                if (sonuc == 0)
                    return dugum;
                else if (sonuc == 1)
                    return (AraInt(dugum.sol, anahtar));
                else
                    return (AraInt(dugum.sag, anahtar));
            }
        }

        public İkiliAramaAgacDugumu MinDeger()
        {
            İkiliAramaAgacDugumu tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }

        public İkiliAramaAgacDugumu MaksDeger()
        {
            İkiliAramaAgacDugumu tempSag = kok;
            while (tempSag.sag != null)
                tempSag = tempSag.sag;
            return tempSag;
        }

        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu ParentSuccessor = silDugum;
            İkiliAramaAgacDugumu current = silDugum.sag;
            İkiliAramaAgacDugumu successor = silDugum;
            while (current != null)
            {
                ParentSuccessor = current;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                ParentSuccessor.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;

        }

        public bool Sil(string deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (((Otel)current.veri).Ad != deger)
            {
                int sonuc = String.Compare(deger, ((Otel)current.veri).Ad);
                parent = current;
                if (sonuc == -1)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current);
                //Doldurulacak
                if (current == kok)
                {
                    kok = successor;
                }
                else if (issol)
                {
                    parent.sol = successor;
                }
                else
                {
                    parent.sag = successor;
                }
                successor.sol = current.sol;
            }
            return true;
        }

        public int MaxDepth()
        {
          int derinlik  = maxDepth(kok);
            return derinlik;
        }
        int maxDepth(İkiliAramaAgacDugumu root)
        {
            // Root being null means tree doesn't exist.
            if (root == null)
                return 0;

            // Get the depth of the left and right subtree 
            // using recursion.
            int leftDepth = maxDepth(root.sol);
            int rightDepth = maxDepth(root.sag);

            // Choose the larger one and add the root to it.
            if (leftDepth > rightDepth)
                return leftDepth + 1;
            else
                return rightDepth + 1;
        }
    }
}
