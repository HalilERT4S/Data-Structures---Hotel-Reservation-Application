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
    public partial class frmPersonelEkle : Form
    {
        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        public frmPersonelEkle(İkiliAramaAgaci value)
        {
            InitializeComponent();
            this.agaci = value;
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {}


        İkiliAramaAgacDugumu agacDugumu = new İkiliAramaAgacDugumu();
        Otel otel = new Otel();
        int personelSayisi = 1;
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtOtelAd.Text == "" || txtPersonelSayi.Text == "")
                MessageBox.Show("Bilgileri Lütfen Doldurunuz!");
            else
            {
                agacDugumu = agaci.Ara(txtOtelAd.Text);
                if (agacDugumu == null)
                    MessageBox.Show("Böyle Bir Otel Bulunmamaktadır");
                else
                {
                    otel = (Otel)agacDugumu.veri;
                    lblSiraliPersonel.Text = personelSayisi.ToString() + "/" + txtPersonelSayi.Text;
                    lblSiraliPersonel.Visible = true;
                    lblEtiket.Visible = true;
                    btnEkle.Visible = true;
                }
            }
        }

        private void PersonelEkle()
        {
            Personel personel = new Personel
            {
                Ad = txtAd.Text,
                Adres = txtAdres.Text,
                Departman = txtDepartman.Text,
                Eposta = txtPersonelEPosta.Text,
                Pozisyon = txtPozisyon.Text,
                Soyad = txtSoyad.Text,
                TCNo = txtTCNo.Text,
                Telefon = mskdtxtTelNo.Text
            };
            otel.PersonelEkle(personel);
        }

        private void EkranHazirla()
        {
            txtOtelAd.Text = txtPersonelSayi.Text = "";
            PersonelEkranHazirlama();
            lblEtiket.Visible = false;
            lblSiraliPersonel.Visible = false;
            btnEkle.Visible = false;
            personelSayisi = 1;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAdres.Text == "" || txtDepartman.Text == "" || txtPozisyon.Text == "" || txtSoyad.Text == "" || txtTCNo.Text == "" || mskdtxtTelNo.Text == "" || lblEPostaKontrol.ForeColor.Name == "Red")
                MessageBox.Show("Sizden İstenilen Bilgileri Doldurunuz!");
            else if (mskdtxtTelNo.Text.Length != 14)
                lblTelNoUyarisi.Visible = true;
            else if (txtTCNo.Text.Length != 11)
                lblTCNoUyari.Visible = true;
            else
            {
                if (personelSayisi == Convert.ToInt32(txtPersonelSayi.Text))
                {
                    PersonelEkle();
                    MessageBox.Show("PERSONEL EKLEME İŞLEMİ BAŞARILI BİR ŞEKİLDE YAPILDI");
                    EkranHazirla();
                    agaci.Ekle(otel);
                }
                else
                {
                    PersonelEkle();
                    personelSayisi++;
                    lblSiraliPersonel.Text = personelSayisi.ToString() + "/" + txtPersonelSayi.Text;
                    PersonelEkranHazirlama();
                }
            }
        }

        private void PersonelEkranHazirlama()
        {
            txtAd.Text = txtSoyad.Text = txtTCNo.Text = txtDepartman.Text = txtPozisyon.Text = txtPersonelEPosta.Text = mskdtxtTelNo.Text = txtAdres.Text = "";
            while (chckdlstbxEPosta.CheckedIndices.Count > 0)
                chckdlstbxEPosta.SetItemChecked(chckdlstbxEPosta.CheckedIndices[0], false);
            lblEPostaKontrol.ForeColor = Color.Red;
        }

        public void EPostaKontrol(string Eposta)
        {
            if (Eposta.Contains("@"))
            {
                chckdlstbxEPosta.SetItemChecked(1, true);
                string[] dizi = Eposta.Split('@');
                if (dizi[0] != "")
                    chckdlstbxEPosta.SetItemChecked(0, true);
                else
                    chckdlstbxEPosta.SetItemChecked(0, false);
                if (dizi[1].CompareTo("hotmail.com") == 0 || dizi[1].CompareTo("gmail.com") == 0 || dizi[1].CompareTo("outlook.com.com") == 0)
                    chckdlstbxEPosta.SetItemChecked(2, true);
                else
                    chckdlstbxEPosta.SetItemChecked(2, false);
            }
            else
            {
                while (chckdlstbxEPosta.CheckedIndices.Count > 0)
                    chckdlstbxEPosta.SetItemChecked(chckdlstbxEPosta.CheckedIndices[0], false);
            }
        }

        private void txtTCNo_Click(object sender, EventArgs e)
        {
            lblTCNoUyari.Visible = false;
        }

        private void mskdtxtTelNo_Click(object sender, EventArgs e)
        {
            lblTelNoUyarisi.Visible = false;
        }

        private void txtPersonelEPosta_KeyUp(object sender, KeyEventArgs e)
        {
            string EPosta = "";
            EPosta = txtPersonelEPosta.Text;
            if (String.IsNullOrEmpty(EPosta))
            {
                while (chckdlstbxEPosta.CheckedIndices.Count > 0)
                    chckdlstbxEPosta.SetItemChecked(chckdlstbxEPosta.CheckedIndices[0], false);
            }
            else
                EPostaKontrol(EPosta);
            if (chckdlstbxEPosta.CheckedIndices.Count == 3)
                lblEPostaKontrol.ForeColor = Color.Green;
            else
                lblEPostaKontrol.ForeColor = Color.Red;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtDepartman_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPozisyon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtOtelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPersonelSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
