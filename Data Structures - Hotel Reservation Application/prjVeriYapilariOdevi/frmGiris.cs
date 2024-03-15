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
    public partial class frmGiris : Form
    {

        İkiliAramaAgaci agaci = new İkiliAramaAgaci();
        ImageList ımage = new ImageList();
        public frmGiris()
        {
            InitializeComponent();
        }

        public frmGiris(İkiliAramaAgaci value,ImageList value1)
        {
            InitializeComponent();
            this.agaci = value;
            this.ımage = value1;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin(agaci,ımage);
            admin.Show();
            this.Hide();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            frmKullanici kullanici = new frmKullanici(agaci,ımage);
            kullanici.Show();
            this.Hide();
        }
    }
}
