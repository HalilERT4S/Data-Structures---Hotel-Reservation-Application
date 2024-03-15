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
    public partial class frmOtelSil : Form
    {
        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        ImageList ımage = new ImageList();
        public frmOtelSil()
        {
            InitializeComponent();
        }

        public frmOtelSil(İkiliAramaAgaci value,ImageList ımage)
        {
            InitializeComponent();
            this.agaci = value;
            this.ımage = ımage;
        }
        private void txtOtelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        public void EkranHazirla()
        {
            btnSil.Enabled = false;
            lblResim.Image = null;
            lblYildiz.Image = null;
            lblAd.Text = lblAdres.Text = "";
            txtOtelAd.Text = "";
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (agaci.Ara(txtOtelAd.Text) == null)
            {
                MessageBox.Show("GİRMİŞ OLDUĞUNUZ AD A AİT OTEL BULUNMAMAKTADIR!");
            }
            else
            {
                btnSil.Enabled = true;
                Otel otel = new Otel();
                İkiliAramaAgacDugumu dugumu = new İkiliAramaAgacDugumu();
                dugumu = agaci.Ara(txtOtelAd.Text);
                otel = (Otel)dugumu.veri;
                lblResim.ImageList = ımage;
                lblResim.ImageIndex = otel.ProfilResmi;
                lblAd.Text = otel.Ad;
                lblYildiz.ImageList = imglstYildiz;
                lblYildiz.ImageIndex = otel.YildizSayisi;
                lblAdres.Text = otel.Il + "/" + otel.Ilce + "\n" + otel.Adres;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            agaci.Sil(txtOtelAd.Text);
            MessageBox.Show("OTEL SİLİNDİ");
            EkranHazirla();
        }
    }
}
