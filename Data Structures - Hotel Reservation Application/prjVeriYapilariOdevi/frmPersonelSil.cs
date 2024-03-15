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
    public partial class frmPersonelSil : Form
    {
        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        İkiliAramaAgacDugumu dugumu = new İkiliAramaAgacDugumu();
        Otel otel = new Otel();
        public frmPersonelSil()
        {
            InitializeComponent();
        }

        public frmPersonelSil(İkiliAramaAgaci value)
        {
            InitializeComponent();
            this.agaci = value;
        }
        private void frmPersonelSil_Load(object sender, EventArgs e)
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
                    btnDevamEt.Enabled = true;
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

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            txtOtelAd.Text = "";
            lstwvPersonelSilTablosu.Items.Clear();
            btnAra.Enabled = true;
            btnDevamEt.Enabled = false;
            agaci.Sil(otel.Ad);
            agaci.Ekle(otel);
        }

        private void lstwvPersonelSilTablosu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PersonelTCNo = lstwvPersonelSilTablosu.SelectedItems[0].SubItems[0].Text;
            foreach (var per in otel.Personeller)
            {
                if (per.TCNo == PersonelTCNo)
                {
                    otel.PersonelSil(per);
                    lstwvPersonelSilTablosu.Items.Clear();
                    foreach (var personel in otel.Personeller)
                    {
                        string[] bilgi = { personel.TCNo, personel.Ad, personel.Soyad, personel.Telefon, personel.Departman, personel.Pozisyon };
                        ListViewItem list1 = new ListViewItem(bilgi);
                        lstwvPersonelSilTablosu.Items.Add(list1);
                    }
                    MessageBox.Show("Personel Silinme İşlemi Başarıyla Gerçekleşti...");
                    break;
                }
            }
        }
    }
}
