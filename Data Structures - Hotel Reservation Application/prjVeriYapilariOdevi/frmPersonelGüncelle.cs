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
    public partial class frmPersonelGüncelle : Form
    {

        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        İkiliAramaAgacDugumu dugumu = new İkiliAramaAgacDugumu();
        Otel otel = new Otel();
        public frmPersonelGüncelle()
        {
            InitializeComponent();
        }

        public frmPersonelGüncelle(İkiliAramaAgaci value)
        {
            InitializeComponent();
            this.agaci = value;
        }
        public string PersonelTCNo;
        private void frmPersonelGüncelle_Load(object sender, EventArgs e)
        {
            lstwvPersonelSilTablosu.Columns.Add("TC NO", 100);
            lstwvPersonelSilTablosu.Columns.Add("AD", 100);
            lstwvPersonelSilTablosu.Columns.Add("SOYAD", 100);
            lstwvPersonelSilTablosu.Columns.Add("TEL NO", 100);
            lstwvPersonelSilTablosu.Columns.Add("DEPARTMAN", 100);
            lstwvPersonelSilTablosu.Columns.Add("POZİSYON", 100);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtOtelAd.Text == "")
                MessageBox.Show("Otel Adini Giriniz!");
            else
            {
                if (agaci.Ara(txtOtelAd.Text) == null)
                    MessageBox.Show("Boyle bir otel adı bulunmamaktadır!");
                else
                {
                    btnAra.Enabled = false;
                    btnGuncellemeIsleminiBitir.Enabled = true;
                    lstwvPersonelSilTablosu.Items.Clear();
                    dugumu = agaci.Ara(txtOtelAd.Text);
                    otel = (Otel)dugumu.veri;
                    foreach (var personel in otel.Personeller)
                    {
                        string[] bilgi = { personel.TCNo, personel.Ad, personel.Soyad, personel.Telefon, personel.Departman, personel.Pozisyon };
                        ListViewItem list1 = new ListViewItem(bilgi);
                        lstwvPersonelSilTablosu.Items.Add(list1);
                    }
                }
            }
        }

        private void lstwvPersonelSilTablosu_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpbxPersonelGüncel.Visible = true;
            PersonelTCNo = lstwvPersonelSilTablosu.SelectedItems[0].SubItems[0].Text;
            foreach (var personel in otel.Personeller)
            {
                if (PersonelTCNo == personel.TCNo)
                {
                    txtAd.Text = personel.Ad;
                    txtSoyad.Text = personel.Soyad;
                    txtTCNo.Text = personel.TCNo;
                    txtDepartman.Text = personel.Departman;
                    txtPozisyon.Text = personel.Pozisyon;
                }
            }
            lstwvPersonelSilTablosu.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPozisyon.Text == "" || txtDepartman.Text == "")
                MessageBox.Show("Bilgileri Boş Bırakmayınız !");
            else
            {
                Personel per = new Personel();
                foreach (var personel in otel.Personeller)
                {
                    if (PersonelTCNo == personel.TCNo)
                    {
                        per = personel;
                        otel.PersonelSil(personel);
                        per.Departman = txtDepartman.Text;
                        per.Pozisyon = txtPozisyon.Text;
                        otel.PersonelEkle(per);
                        break;
                    }
                }
                lstwvPersonelSilTablosu.Items.Clear();
                foreach (var personel in otel.Personeller)
                {
                    string[] bilgi = { personel.TCNo, personel.Ad, personel.Soyad, personel.Telefon, personel.Departman, personel.Pozisyon };
                    ListViewItem list1 = new ListViewItem(bilgi);
                    lstwvPersonelSilTablosu.Items.Add(list1);
                }
                grpbxPersonelGüncel.Visible = false;
                lstwvPersonelSilTablosu.Visible = true;
            }
        }

        private void btnGuncellemeIsleminiBitir_Click(object sender, EventArgs e)
        {
            txtOtelAd.Text = txtAd.Text = txtSoyad.Text = txtTCNo.Text = txtDepartman.Text = txtPozisyon.Text = "";
            btnGuncellemeIsleminiBitir.Enabled = false;
            btnAra.Enabled = true;
            agaci.Sil(otel.Ad);
            agaci.Ekle(otel);
            grpbxPersonelGüncel.Visible = false;
            lstwvPersonelSilTablosu.Items.Clear();
        }
    }
}
