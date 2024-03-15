using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVeriYapilariOdevi
{
    public partial class frmOdaRezervasyon : Form
    {
        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        ImageList otelResim = new ImageList();
        string odaNo;
        string OtelIsim;

        Otel otel = new Otel();
        Oda oda = new Oda();
        Musteri[] musteriler;
        Yorum yorum;
        HashChain rezervasyonHashTable = new HashChain();
        int musteriSayaci = 1, hash = 1;

        int HashFonksiyonu(int x)
        {
            return x % 10;
        }

        public frmOdaRezervasyon()
        {
            InitializeComponent();
        }

        public frmOdaRezervasyon(İkiliAramaAgaci agacValue, ImageList imgValue, string otelIsimValue, string odaNoValue)
        {
            InitializeComponent();
            this.agaci = agacValue;
            this.otelResim = imgValue;
            this.OtelIsim = otelIsimValue;
            this.odaNo = odaNoValue;
        }

        private void frmOdaRezervasyon_Load(object sender, EventArgs e)
        {
            otelResim.ImageSize = new Size(193, 181);

            İkiliAramaAgacDugumu dugum = new İkiliAramaAgacDugumu();
            dugum = agaci.Ara(OtelIsim);
            otel = (Otel)dugum.veri;

            foreach (var _oda in otel.Odalar)
            {
                if (odaNo == _oda.No.ToString())
                {
                    oda = _oda;
                }
            }

            lblResim.ImageList = otelResim;
            lblResim.ImageIndex = otel.ProfilResmi;

            lblYildizSayisi.ImageList = imglstYildizSayisi;
            lblYildizSayisi.ImageIndex = otel.YildizSayisi;

            lblOtelAdiBaslik.Text = OtelIsim;

            tbOtelAdi.Text = OtelIsim;
            tbOdaNo.Text = oda.No.ToString();
            tbMaxKisiSayisi.Text = oda.KisiSayisi.ToString();

            musteriSayaci = 1;



        }

        private void tbKisiSayisi_TextChanged(object sender, EventArgs e)
        {
            if (String.Compare(tbKisiSayisi.Text, tbMaxKisiSayisi.Text) > 0)
            {
                lblKisiSayisiUyari.Visible = true;
                gbMusteri.Enabled = false;
                btnRezervasyonTamamla.Enabled = false;
            }
            else
            {
                lblKisiSayisiUyari.Visible = false;
                gbMusteri.Enabled = true;
                btnRezervasyonTamamla.Enabled = true;

                if (!String.IsNullOrEmpty(tbKisiSayisi.Text))
                {
                    musteriler = new Musteri[Convert.ToInt32(tbKisiSayisi.Text)];
                    lblMusteriSayaci.Text = musteriSayaci + "/" + tbKisiSayisi.Text;
                }
            }
        }

        private void tbGunSayisi_TextChanged(object sender, EventArgs e)
        {
            lblToplamFiyatSayisalDeger.Text = (Convert.ToInt32(tbGunSayisi.Text) * oda.Fiyat).ToString();
        }

        private void btnMusteriBilgisiKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteriBilgisi = new Musteri(tbTckn.Text, tbMusteriAd.Text, tbMusteriSoyad.Text, mtbMusteriTel.Text, tbAdres.Text, tbEposta.Text);
            musteriler[musteriSayaci - 1] = musteriBilgisi;
            musteriSayaci++;

            if (musteriSayaci > Convert.ToInt32(tbKisiSayisi.Text))
            {
                btnMusteriBilgisiKaydet.Enabled = false;
                musteriSayaci--;
                MessageBox.Show("Musteri kaydiniz tamamlandi.");
            }
            else
            {
                lblMusteriSayaci.Text = musteriSayaci + "/" + tbKisiSayisi.Text;
            }

            if (tbYorum.Text != string.Empty && tbPuan.Text != string.Empty)
            {
                bool ayniMusteri = false;
                foreach (var yorum in otel.Yorumlar)
                {
                    if (yorum.Ad == tbMusteriAd.Text)
                    {
                        ayniMusteri = true;
                        MessageBox.Show("Zaten yorum yapmissiniz.");
                    }
                }

                if (!ayniMusteri)
                {
                    yorum = new Yorum(tbMusteriAd.Text, tbMusteriSoyad.Text, tbEposta.Text, tbAdres.Text, tbYorum.Text, Convert.ToByte(tbPuan.Text));
                    otel.Yorumlar.AddLast(yorum);
                }
            }

            tbTckn.Text = string.Empty;
            tbMusteriAd.Text = string.Empty;
            tbMusteriSoyad.Text = string.Empty;
            mtbMusteriTel.Text = string.Empty;
            tbAdres.Text = string.Empty;
            tbEposta.Text = string.Empty;
        }

        private void btnRezervasyonTamamla_Click(object sender, EventArgs e)
        {

            if (musteriSayaci.ToString() == tbKisiSayisi.Text)
            {
                Random random = new Random();
                int randomSayi = random.Next();
                hash = HashFonksiyonu(randomSayi);

                Rezervasyon rezervasyonBilgileri = new Rezervasyon(tbOtelAdi.Text, Convert.ToInt32(tbOdaNo.Text), Convert.ToInt32(tbKisiSayisi.Text), Convert.ToInt32(tbGunSayisi.Text), Convert.ToInt32(lblToplamFiyatSayisalDeger.Text), musteriler);
                rezervasyonHashTable.Add(hash, rezervasyonBilgileri);

                Heap musteriHeapAgaci = new Heap(musteriler.Length);
                foreach (var musteri in musteriler)
                {
                    musteriHeapAgaci.Insert(musteri);
                }

                Musteri[] siraliMusteriler = new Musteri[musteriler.Length];
                int i = 0;
                string sonuc = "Musterilerin Sirlanmis Hali Su Sekildedir: \n";
                while (!musteriHeapAgaci.IsEmpty())
                    siraliMusteriler[i++] = musteriHeapAgaci.RemoveMax().Deger;

                foreach (var musteri1 in siraliMusteriler)
                {
                    sonuc += musteri1.ad + " " + musteri1.soyAd + "\n";
                }
                MessageBox.Show(sonuc);

                int otelToplamPuan = 0;
                foreach (var yorum1 in otel.Yorumlar)
                {
                    otelToplamPuan += yorum1.Puan;
                }
                otel.Puan = Convert.ToByte(otelToplamPuan / otel.Yorumlar.Count);

                agaci.Sil(OtelIsim);
                agaci.Ekle(otel);

                oda.RezervasyonDurumu = true;
                this.Hide();
                frmGiris frmGiris = new frmGiris(agaci, otelResim);
                frmGiris.Show();
            }
            else
            {
                MessageBox.Show("Lutfen musterileri eksiksiz giriniz!");
            }
        }
    }
}
