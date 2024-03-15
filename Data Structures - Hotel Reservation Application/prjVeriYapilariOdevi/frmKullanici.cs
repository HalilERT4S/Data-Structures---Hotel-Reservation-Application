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
    public partial class frmKullanici : Form
    {

        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        ImageList list = new ImageList();
        List<Otel> oteller = new List<Otel>();

        public int OnButtonActionClick { get; private set; }

        public frmKullanici()
        {
            InitializeComponent();
        }

        public frmKullanici(İkiliAramaAgaci value, ImageList value1)
        {
            InitializeComponent();
            this.agaci = value;
            this.list = value1;
        }

        public void YildizSayisiBuyuktenKucuge(List<Otel> items)
        {
            Otel otel = new Otel();
            int i, j;
            for (i = 1; i < items.Count; i++)
            {
                otel = items[i];
                j = i;
                while (j > 0 && items[j - 1].YildizSayisi < otel.YildizSayisi)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = otel;
            }
        }

        public void YildizSayisiKucuktenBuyuge(List<Otel> items)
        {
            Otel otel = new Otel();
            int i, j;
            for (i = 1; i < items.Count; i++)
            {
                otel = items[i];
                j = i;
                while (j > 0 && items[j - 1].YildizSayisi > otel.YildizSayisi)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = otel;
            }
        }
        public void PuanSayisiBuyuktenKucuge(List<Otel> items)
        {
            Otel otel = new Otel();
            int i, j;
            for (i = 1; i < items.Count; i++)
            {
                otel = items[i];
                j = i;
                while (j > 0 && items[j - 1].Puan < otel.Puan)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = otel;
            }
        }
        public void PuanSayisiKucuktenBuyuge(List<Otel> items)
        {
            Otel otel = new Otel();
            int i, j;
            for (i = 1; i < items.Count; i++)
            {
                otel = items[i];
                j = i;
                while (j > 0 && items[j - 1].Puan > otel.Puan)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = otel;
            }
        }
        public void OtelIsmiZdenAya(List<Otel> items)
        {
            Otel otel = new Otel();
            int i, j;
            for (i = 1; i < items.Count; i++)
            {
                otel = items[i];
                j = i;
                while (j > 0 && String.Compare(items[j-1].Ad,otel.Ad) == -1)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = otel;
            }
        }
        public void OtelIsmiAdanZye(List<Otel> items)
        {
            Otel otel = new Otel();
            int i, j;
            for (i = 1; i < items.Count; i++)
            {
                otel = items[i];
                j = i;
                while (j > 0 && String.Compare(items[j - 1].Ad, otel.Ad) == 1)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = otel;
            }
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("AD", 100);
            listView1.Columns.Add("IL", 100);
            listView1.Columns.Add("ILCE", 100);
            listView1.Columns.Add("PUAN", 100);
            listView1.Columns.Add("YILDIZ SAYISI", 100);
            listView1.Columns.Add("ODA SAYISI", 100);
            listView1.Columns.Add("TELEFON", 100);


            agaci.PreOrder();
            oteller = agaci.DugumleriYazdir();
            foreach (var otel in oteller)
            {
                string[] bilgi = { otel.Ad, otel.Il, otel.Ilce, otel.Puan.ToString(), (otel.YildizSayisi+1).ToString(), otel.OdaSayisi.ToString(), otel.Telefon };
                ListViewItem list1 = new ListViewItem(bilgi);
                listView1.Items.Add(list1);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbxArama.Text == "")
                MessageBox.Show("Filtre Seçeneğini Kullanınız!");
            else
            {
                if (txtIl.Text != "" && txtIlce.Text != "")
                {
                    List<Otel> otels = new List<Otel>();
                    foreach (var otel in oteller)
                    {
                        if (otel.Il == txtIl.Text && otel.Ilce == txtIlce.Text)
                            otels.Add(otel);
                    }
                    if (cmbxArama.SelectedIndex == 4)
                    {
                        listView1.Items.Clear();
                        YildizSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 5)
                    {
                        listView1.Items.Clear();
                        YildizSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 2)
                    {
                        listView1.Items.Clear();
                        PuanSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 3)
                    {
                        listView1.Items.Clear();
                        PuanSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 0)
                    {
                        listView1.Items.Clear();
                        OtelIsmiAdanZye(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }

                    else if (cmbxArama.SelectedIndex == 1)
                    {
                        listView1.Items.Clear();
                        OtelIsmiZdenAya(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }

                }
                else if (txtIl.Text != "")
                {
                    List<Otel> otels = new List<Otel>();
                    foreach (var otel in oteller)
                    {
                        if (otel.Il == txtIl.Text)
                            otels.Add(otel);
                    }
                    if (cmbxArama.SelectedIndex == 4)
                    {
                        listView1.Items.Clear();
                        YildizSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 5)
                    {
                        listView1.Items.Clear();
                        YildizSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 2)
                    {
                        listView1.Items.Clear();
                        PuanSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 3)
                    {
                        listView1.Items.Clear();
                        PuanSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 0)
                    {
                        listView1.Items.Clear();
                        OtelIsmiAdanZye(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }

                    else if (cmbxArama.SelectedIndex == 1)
                    {
                        listView1.Items.Clear();
                        OtelIsmiZdenAya(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                }
                else if (txtIlce.Text != "")
                {
                    List<Otel> otels = new List<Otel>();
                    foreach (var otel in oteller)
                    {
                        if (otel.Ilce == txtIlce.Text)
                            otels.Add(otel);
                    }
                    if (cmbxArama.SelectedIndex == 4)
                    {
                        listView1.Items.Clear();
                        YildizSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 5)
                    {
                        listView1.Items.Clear();
                        YildizSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 2)
                    {
                        listView1.Items.Clear();
                        PuanSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 3)
                    {
                        listView1.Items.Clear();
                        PuanSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 0)
                    {
                        listView1.Items.Clear();
                        OtelIsmiAdanZye(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }

                    else if (cmbxArama.SelectedIndex == 1)
                    {
                        listView1.Items.Clear();
                        OtelIsmiZdenAya(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                }
                else
                {
                    List<Otel> otels = new List<Otel>();
                    foreach (var otel in oteller)
                    {
                            otels.Add(otel);
                    }
                    if (cmbxArama.SelectedIndex == 4)
                    {
                        listView1.Items.Clear();
                        YildizSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 5)
                    {
                        listView1.Items.Clear();
                        YildizSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 2)
                    {
                        listView1.Items.Clear();
                        PuanSayisiBuyuktenKucuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 3)
                    {
                        listView1.Items.Clear();
                        PuanSayisiKucuktenBuyuge(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                    else if (cmbxArama.SelectedIndex == 0)
                    {
                        listView1.Items.Clear();
                        OtelIsmiAdanZye(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }

                    else if (cmbxArama.SelectedIndex == 1)
                    {
                        listView1.Items.Clear();
                        OtelIsmiZdenAya(otels);
                        foreach (var otel1 in otels)
                        {
                            string[] bilgi = { otel1.Ad, otel1.Il, otel1.Ilce, otel1.Puan.ToString(), (otel1.YildizSayisi + 1).ToString(), otel1.OdaSayisi.ToString(), otel1.Telefon };
                            ListViewItem list1 = new ListViewItem(bilgi);
                            listView1.Items.Add(list1);
                        }
                    }
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (cmbxSiralamaAlgoritmasi.Text == "")
            {
                MessageBox.Show("Arama Algoritması seçiniz");
            }
            else if (cmbxSiralamaAlgoritmasi.SelectedIndex == 0)
            {
                List<Otel> aramaotel = new List<Otel>();
                agaci.PreOrder();
                txtDugumSayisi.Text = agaci.DugumSayisi().ToString();
                txtDerinlikSayisi.Text = agaci.MaxDepth().ToString();
                aramaotel = agaci.DugumleriYazdir();
                foreach (var item in aramaotel)
                {
                    string[] bilgi = { item.Ad, item.Il, item.Ilce, item.Puan.ToString(), (item.YildizSayisi + 1).ToString(), item.OdaSayisi.ToString(), item.Telefon };
                    ListViewItem list1 = new ListViewItem(bilgi);
                    listView1.Items.Add(list1);
                }
            }
            else if(cmbxSiralamaAlgoritmasi.SelectedIndex == 1)
            {
                List<Otel> aramaotel = new List<Otel>();
                agaci.InOrder();
                txtDugumSayisi.Text = agaci.DugumSayisi().ToString();
                txtDerinlikSayisi.Text = agaci.MaxDepth().ToString();
                aramaotel = agaci.DugumleriYazdir();
                foreach (var item in aramaotel)
                {
                    string[] bilgi = { item.Ad, item.Il, item.Ilce, item.Puan.ToString(), (item.YildizSayisi + 1).ToString(), item.OdaSayisi.ToString(), item.Telefon };
                    ListViewItem list1 = new ListViewItem(bilgi);
                    listView1.Items.Add(list1);
                }
            }
            else if(cmbxSiralamaAlgoritmasi.SelectedIndex == 2)
            {
                List<Otel> aramaotel = new List<Otel>();
                agaci.PostOrder();
                txtDugumSayisi.Text = agaci.DugumSayisi().ToString();
                txtDerinlikSayisi.Text = agaci.MaxDepth().ToString();
                aramaotel = agaci.DugumleriYazdir();
                foreach (var item in aramaotel)
                {
                    string[] bilgi = { item.Ad, item.Il, item.Ilce, item.Puan.ToString(), (item.YildizSayisi + 1).ToString(), item.OdaSayisi.ToString(), item.Telefon };
                    ListViewItem list1 = new ListViewItem(bilgi);
                    listView1.Items.Add(list1);
                }
            }
        }
        string OtelIsim;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OtelIsim = listView1.SelectedItems[0].SubItems[0].Text;
            frmOtelRezervasyon otelRezervasyon = new frmOtelRezervasyon(agaci, list, OtelIsim);
            otelRezervasyon.Show();
            this.Hide();
        }
    }
}