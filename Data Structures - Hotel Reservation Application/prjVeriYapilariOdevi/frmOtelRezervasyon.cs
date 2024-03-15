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
    public partial class frmOtelRezervasyon : Form
    {
        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        ImageList otelResim = new ImageList();
        string OtelIsim;

        Otel otel = new Otel();


        public frmOtelRezervasyon()
        {
            InitializeComponent();
        }

        public frmOtelRezervasyon(İkiliAramaAgaci value,ImageList value1,string value2)
        {
            InitializeComponent();
            this.agaci = value;
            this.otelResim = value1;
            this.OtelIsim = value2;
        }

        void OdalariGoster(Otel otel)
        {
            foreach (var oda in otel.Odalar)
            {
                if (oda.RezervasyonDurumu == false)
                {
                    lvOdalar.Items.Add(new ListViewItem(new[] { oda.No.ToString(), oda.TelefonNo, oda.KisiSayisi.ToString(), oda.ManzaraBilgisi, oda.RezervasyonDurumu.ToString(), oda.Fiyat.ToString() }));
                }
            }
        }

        private void frmOtelRezervasyon_Load(object sender, EventArgs e)
        {
            otelResim.ImageSize = new Size(193, 181);

            lvOdalar.Columns.Add("ODA NUMARASI", 100);
            lvOdalar.Columns.Add("TELEFON NUMARASI ", 100);
            lvOdalar.Columns.Add("KISI SAYISI", 100);
            lvOdalar.Columns.Add("MANZARA BILGISI", 100);
            lvOdalar.Columns.Add("REZERVASYON DURUMU", 100);
            lvOdalar.Columns.Add("FIYAT", 100);

            İkiliAramaAgacDugumu dugum = new İkiliAramaAgacDugumu();
            dugum = agaci.Ara(OtelIsim);
            otel = (Otel)dugum.veri;

            lblResim.ImageList = otelResim;
            lblResim.ImageIndex = otel.ProfilResmi;

            lblYildizSayisi.ImageList = imglstYildizSayisi;
            lblYildizSayisi.ImageIndex = otel.YildizSayisi;

            lblOtelAdi.Text = OtelIsim;

            OdalariGoster(otel);
        }

        string odaNo;
        private void lvOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            odaNo = lvOdalar.SelectedItems[0].SubItems[0].Text;
            frmOdaRezervasyon odaRezervasyon = new frmOdaRezervasyon(agaci, otelResim, OtelIsim, odaNo);
            odaRezervasyon.Show();
            this.Hide();
        }
    }
}
