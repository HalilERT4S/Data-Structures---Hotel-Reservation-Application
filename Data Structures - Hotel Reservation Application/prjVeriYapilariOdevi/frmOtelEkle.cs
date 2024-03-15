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
    public partial class frmOtelEkle : Form
    {
        public frmOtelEkle()
        {
            InitializeComponent();
        }
        Otel otel;
        Oda oda;
        public İkiliAramaAgaci aramaAgaci = new İkiliAramaAgaci();
        public frmOtelEkle(İkiliAramaAgaci value,ImageList ımage)
        {
            InitializeComponent();
            this.aramaAgaci = value;
            ımageList1 = ımage;
        }
        private void frmOtelEkle_Load(object sender, EventArgs e)
        {
            tmrpckZamanlayici.Start();
        }

        public void OtelBilgiTemizle()
        {
            pctrbxOtelResmi.Image = null;
            txtOtelAd.Text = txtOtelEPosta.Text = txtOdaSayisi.Text = txtIl.Text = txtIlce.Text = txtAdres.Text = mskdtxtOtelTelNo.Text = "";
            rdbtnYildiz1.Checked = rdbtnYildiz2.Checked = rdbtnYildiz3.Checked = rdbtnYildiz4.Checked = rdbtnYildiz5.Checked = false;
            lblEPostaKontrol.ForeColor = Color.Red;
            btnOdaEkle.Text = "EKLE";
            while (chckdlstbxEPosta.CheckedIndices.Count > 0)
                chckdlstbxEPosta.SetItemChecked(chckdlstbxEPosta.CheckedIndices[0], false);
            progressBar1.Value = 0;
            lblBirinciDugum.BackColor = lblIkıncıDugum.BackColor = Color.Red;
            lblOtelBilgisi.ForeColor = lblOdaBilgisi.ForeColor = Color.Orange;
            odaSayisi = 1;
            tbcntrlOtelBilgi.SelectedIndex = 0;
            OdaBilgiTemizle();
            tmrpckZamanlayici.Start();
        }

        private void tmrpckZamanlayici_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 25)
            {
                tmrpckZamanlayici.Stop();
                lblBirinciDugum.BackColor = Color.Green;
                lblOtelBilgisi.ForeColor = Color.Green;
                tbcntrlOtelBilgi.Visible = true;
            }
            if (progressBar1.Value == 75)
            {
                tmrpckZamanlayici.Stop();
                lblIkıncıDugum.BackColor = Color.Green;
                lblOdaBilgisi.ForeColor = Color.Green;
                tbcntrlOtelBilgi.SelectedIndex = 1;
                tbcntrlOtelBilgi.Visible = true;
            }
            if (progressBar1.Value == 100) 
            {
                aramaAgaci.Ekle(otel);
                tmrpckZamanlayici.Stop();
                MessageBox.Show("OTEL OLUŞTURULDU");
                OtelBilgiTemizle();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pctrbxOtelResmi.ImageLocation = openFileDialog1.FileName;
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

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            if (pctrbxOtelResmi.Image == null || txtOtelAd.Text == "" || mskdtxtOtelTelNo.Text == "" || lblEPostaKontrol.ForeColor.Name == "Red" || txtOdaSayisi.Text == "" || txtIl.Text == "" || txtIlce.Text == "" || txtAdres.Text == "")
            {
                MessageBox.Show("İSTENİLEN BİLGİLERİ BOŞ GEÇMEYİNİZ!");
            }
            else if (rdbtnYildiz1.Checked == false && rdbtnYildiz2.Checked == false && rdbtnYildiz3.Checked == false && rdbtnYildiz4.Checked == false && rdbtnYildiz5.Checked == false) 
            {
                MessageBox.Show("OTEL YILDIZ PUANINI SEÇİNİZ");
            }
            else if (mskdtxtOtelTelNo.Text.Length != 14)
            {
                lblTelNoUyari.Visible = true;
            }
            else if (Convert.ToInt32(txtOdaSayisi.Text) < 1)
            {
                lblOdaSayisiUyari.Visible = true;
            }
            else
            {
                byte yildizSayisi;
                if (rdbtnYildiz1.Checked == true)
                    yildizSayisi = 0;
                else if (rdbtnYildiz2.Checked == true)
                    yildizSayisi = 1;
                else if (rdbtnYildiz3.Checked == true)
                    yildizSayisi = 2;
                else if (rdbtnYildiz4.Checked == true)
                    yildizSayisi = 3;
                else
                    yildizSayisi = 4;

                ımageList1.Images.Add(pctrbxOtelResmi.Image);

                otel = new Otel
                {
                    Ad = txtOtelAd.Text, Il = txtIl.Text, Adres = txtAdres.Text,
                     Eposta = txtOtelEPosta.Text, Ilce = txtIlce.Text, OdaSayisi = Convert.ToUInt16(txtOdaSayisi.Text),
                      YildizSayisi = yildizSayisi, Telefon = mskdtxtOtelTelNo.Text,
                    ProfilResmi = Convert.ToByte(ımageList1.Images.Count - 1)
                };
                
                tbcntrlOtelBilgi.Visible = false;
                lblSiraliOda.Text = odaSayisi.ToString() + "/" + txtOdaSayisi.Text;
                if (txtOdaSayisi.Text == "1")
                    btnOdaEkle.Text = "OTEL OLUŞTUR";
                tmrpckZamanlayici.Start();
            }
        }

        private void txtOtelEPosta_KeyUp(object sender, KeyEventArgs e)
        {
            string EPosta = "";
            EPosta = txtOtelEPosta.Text;
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
        int odaSayisi = 1;
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text == "" || mskdtxtOdaTelNo.Text == "" || txtKisiSayisi.Text == "" || cmbxManzaraBilgisi.Text == "" || txtFiyat.Text == "")
            {
                MessageBox.Show("İSTENİLEN ODA BİLGİLERİNİ DOLDURUNUZ!");
            }
            else if (mskdtxtOdaTelNo.Text.Length != 14)
                lblOdaTelNoUyari.Visible = true;
            else if (Convert.ToInt32(txtKisiSayisi.Text) < 1)
                lblKisiSayisiUyari.Visible = true;
            else if (odaSayisi == Convert.ToInt32(txtOdaSayisi.Text))
            {
                OdaEkle();
                tmrpckZamanlayici.Start();
                tbcntrlOtelBilgi.Visible = false;
            }
            else
            {
                OdaEkle();
                OdaBilgiTemizle();
                odaSayisi++;
                lblSiraliOda.Text = odaSayisi.ToString() + "/" + txtOdaSayisi.Text;
                if (odaSayisi == Convert.ToInt32(txtOdaSayisi.Text))
                    btnOdaEkle.Text = "OTEL OLUŞTUR";
            }
        }

        public void OdaEkle()
        {
            oda = new Oda
            {
                Fiyat = Convert.ToUInt32(txtFiyat.Text), KisiSayisi = Convert.ToByte(txtKisiSayisi.Text),
                ManzaraBilgisi = cmbxManzaraBilgisi.Text, No = Convert.ToUInt16(txtOdaNo.Text),
                TelefonNo = mskdtxtOdaTelNo.Text
            };
            otel.OdaEkle(oda);
        }
        public void OdaBilgiTemizle()
        {
            txtOdaNo.Text = mskdtxtOdaTelNo.Text = txtKisiSayisi.Text = cmbxManzaraBilgisi.Text = txtFiyat.Text = "";
        }

        private void txtOtelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtOdaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtIlce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void mskdtxtOtelTelNo_Click(object sender, EventArgs e)
        {
            lblTelNoUyari.Visible = false;
        }

        private void txtOdaSayisi_Click(object sender, EventArgs e)
        {
            lblOdaSayisiUyari.Visible = false;
        }

        private void mskdtxtOdaTelNo_Click(object sender, EventArgs e)
        {
            lblOdaTelNoUyari.Visible = false;
        }

        private void txtKisiSayisi_Click(object sender, EventArgs e)
        {
            lblKisiSayisiUyari.Visible = false;
        }

        private void txtKisiSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOdaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
