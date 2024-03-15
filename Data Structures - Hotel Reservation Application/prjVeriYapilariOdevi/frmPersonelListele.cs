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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }
        İkiliAramaAgaci İkiliArama = new İkiliAramaAgaci();
        İkiliAramaAgacDugumu dugumu = new İkiliAramaAgacDugumu();
        public frmPersonelListele(İkiliAramaAgaci value)
        {
            InitializeComponent();
            this.İkiliArama = value;
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC NO", 200);
            listView1.Columns.Add("AD", 150);
            listView1.Columns.Add("SOYAD", 150);
            listView1.Columns.Add("TELEFON", 150);
            listView1.Columns.Add("ADRES", 250);
            listView1.Columns.Add("E-POSTA", 150);
            listView1.Columns.Add("DEPARTMAN", 150);
            listView1.Columns.Add("POZİSYON", 150);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (txtOtelAd.Text == "")
                MessageBox.Show("Otel Ad Bilgisini Doldurunuz!");
            else
            {
                dugumu = İkiliArama.Ara(txtOtelAd.Text);
                if (dugumu == null)
                    MessageBox.Show("Böyle Bir Otel Bulunmamaktadır!");
                else
                {
                    Otel otel = new Otel();
                    otel = (Otel)dugumu.veri;
                    if (otel.Personeller.Count == 0)
                        MessageBox.Show("Bu Otelde Çalışan Personel Bulunmamaktadır!");
                    else
                    {
                        
                        foreach (var personel in otel.Personeller)
                        {
                            string[] bilgi = {personel.TCNo,personel.Ad,personel.Soyad,personel.Telefon,personel.Adres,
                            personel.Eposta,personel.Departman,personel.Pozisyon};
                            ListViewItem ıtem = new ListViewItem(bilgi);
                            listView1.Items.Add(ıtem);
                        }
                    }
                }
            }
        }

        private void txtOtelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
