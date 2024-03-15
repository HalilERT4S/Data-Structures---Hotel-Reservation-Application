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
    public partial class frmAdmin : Form
    {
        İkiliAramaAgaci ikiliArama = new İkiliAramaAgaci();
        ImageList ımageList = new ImageList();
        Form acikForm = null;
        private void image()
        {
            ımageList.ImageSize = new Size(207, 169);
        }
        public frmAdmin()
        {
            InitializeComponent();
        }

        public frmAdmin(İkiliAramaAgaci value,ImageList value1)
        {
            InitializeComponent();
            this.ikiliArama = value;
            this.ımageList = value1;
        }

        private void oTELEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image();
            frmOtelEkle frmOtelEkle = new frmOtelEkle(ikiliArama,ımageList);
            FormLocationSetting(frmOtelEkle);
            FormKapatma();
            acikForm = frmOtelEkle;
            frmOtelEkle.MdiParent = this;
            frmOtelEkle.Show();
        }

        private void oTELSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image();
            frmOtelSil frmOtelSil = new frmOtelSil(ikiliArama,ımageList);
            FormLocationSetting(frmOtelSil);
            FormKapatma();
            acikForm = frmOtelSil;
            frmOtelSil.MdiParent = this;
            frmOtelSil.Show();
        }

        private void pERSONELEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frmPersonel = new frmPersonelEkle(ikiliArama);
            FormLocationSetting(frmPersonel);
            FormKapatma();
            acikForm = frmPersonel;
            frmPersonel.MdiParent = this;
            frmPersonel.Show();
        }

        private void pERSONELLİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelListele personelListele = new frmPersonelListele(ikiliArama);
            FormLocationSetting(personelListele);
            FormKapatma();
            acikForm = personelListele;
            personelListele.MdiParent = this;
            personelListele.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris(ikiliArama,ımageList);
            giris.Show();
            this.Hide();
        }

        private void pERSONELSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelSil personelSil = new frmPersonelSil(ikiliArama);
            FormLocationSetting(personelSil);
            FormKapatma();
            acikForm = personelSil;
            personelSil.MdiParent = this;
            personelSil.Show();
        }

        private void pERSONELGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelGüncelle personelGüncelle = new frmPersonelGüncelle(ikiliArama);
            FormLocationSetting(personelGüncelle);
            FormKapatma();
            acikForm = personelGüncelle;
            personelGüncelle.MdiParent = this;
            personelGüncelle.Show();
        }

        private void FormLocationSetting(Form yeniForm)
        {
            yeniForm.StartPosition = FormStartPosition.Manual;
            yeniForm.Location = this.PointToScreen(Point.Empty);
        }

        private void FormKapatma()
        {
            if(!(acikForm is null))
            {
                acikForm.Close();
            }
        }

        private void oTELGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
