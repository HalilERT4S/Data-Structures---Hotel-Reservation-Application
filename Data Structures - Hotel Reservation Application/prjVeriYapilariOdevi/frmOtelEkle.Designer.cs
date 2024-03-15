
namespace prjVeriYapilariOdevi
{
    partial class frmOtelEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtelEkle));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrpckZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.lblBirinciDugum = new System.Windows.Forms.Label();
            this.lblOtelBilgisi = new System.Windows.Forms.Label();
            this.tbcntrlOtelBilgi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblOdaSayisiUyari = new System.Windows.Forms.Label();
            this.lblTelNoUyari = new System.Windows.Forms.Label();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.mskdtxtOtelTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblEPostaKontrol = new System.Windows.Forms.Label();
            this.chckdlstbxEPosta = new System.Windows.Forms.CheckedListBox();
            this.txtOtelEPosta = new System.Windows.Forms.TextBox();
            this.lblEPosta = new System.Windows.Forms.Label();
            this.grpbxOtelYildizSayisi = new System.Windows.Forms.GroupBox();
            this.rdbtnYildiz5 = new System.Windows.Forms.RadioButton();
            this.rdbtnYildiz4 = new System.Windows.Forms.RadioButton();
            this.rdbtnYildiz3 = new System.Windows.Forms.RadioButton();
            this.rdbtnYildiz2 = new System.Windows.Forms.RadioButton();
            this.rdbtnYildiz1 = new System.Windows.Forms.RadioButton();
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.lblOtelAd = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pctrbxOtelResmi = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSiraliOda = new System.Windows.Forms.Label();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.grpbxOdaBilgisi = new System.Windows.Forms.GroupBox();
            this.lblKisiSayisiUyari = new System.Windows.Forms.Label();
            this.lblOdaTelNoUyari = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.cmbxManzaraBilgisi = new System.Windows.Forms.ComboBox();
            this.lblManzaraBilgisi = new System.Windows.Forms.Label();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.mskdtxtOdaTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblOdaTelNo = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblOdaBilgisi = new System.Windows.Forms.Label();
            this.lblIkıncıDugum = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbcntrlOtelBilgi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbxOtelYildizSayisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxOtelResmi)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpbxOdaBilgisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(56, 112);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(928, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // tmrpckZamanlayici
            // 
            this.tmrpckZamanlayici.Tick += new System.EventHandler(this.tmrpckZamanlayici_Tick);
            // 
            // lblBirinciDugum
            // 
            this.lblBirinciDugum.BackColor = System.Drawing.Color.Red;
            this.lblBirinciDugum.Location = new System.Drawing.Point(281, 106);
            this.lblBirinciDugum.Name = "lblBirinciDugum";
            this.lblBirinciDugum.Size = new System.Drawing.Size(25, 26);
            this.lblBirinciDugum.TabIndex = 1;
            // 
            // lblOtelBilgisi
            // 
            this.lblOtelBilgisi.BackColor = System.Drawing.Color.Black;
            this.lblOtelBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelBilgisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOtelBilgisi.Location = new System.Drawing.Point(243, 20);
            this.lblOtelBilgisi.Name = "lblOtelBilgisi";
            this.lblOtelBilgisi.Size = new System.Drawing.Size(107, 69);
            this.lblOtelBilgisi.TabIndex = 2;
            this.lblOtelBilgisi.Text = "OTEL BİLGİSİ OLUŞTUR";
            this.lblOtelBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcntrlOtelBilgi
            // 
            this.tbcntrlOtelBilgi.Controls.Add(this.tabPage1);
            this.tbcntrlOtelBilgi.Controls.Add(this.tabPage2);
            this.tbcntrlOtelBilgi.Location = new System.Drawing.Point(56, 155);
            this.tbcntrlOtelBilgi.Name = "tbcntrlOtelBilgi";
            this.tbcntrlOtelBilgi.SelectedIndex = 0;
            this.tbcntrlOtelBilgi.Size = new System.Drawing.Size(928, 446);
            this.tbcntrlOtelBilgi.TabIndex = 0;
            this.tbcntrlOtelBilgi.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.lblOdaSayisiUyari);
            this.tabPage1.Controls.Add(this.lblTelNoUyari);
            this.tabPage1.Controls.Add(this.txtIlce);
            this.tabPage1.Controls.Add(this.txtIl);
            this.tabPage1.Controls.Add(this.btnDevamEt);
            this.tabPage1.Controls.Add(this.lblIlce);
            this.tabPage1.Controls.Add(this.lblIl);
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.lblAdres);
            this.tabPage1.Controls.Add(this.txtOdaSayisi);
            this.tabPage1.Controls.Add(this.lblOdaSayisi);
            this.tabPage1.Controls.Add(this.mskdtxtOtelTelNo);
            this.tabPage1.Controls.Add(this.lblTelNo);
            this.tabPage1.Controls.Add(this.lblEPostaKontrol);
            this.tabPage1.Controls.Add(this.chckdlstbxEPosta);
            this.tabPage1.Controls.Add(this.txtOtelEPosta);
            this.tabPage1.Controls.Add(this.lblEPosta);
            this.tabPage1.Controls.Add(this.grpbxOtelYildizSayisi);
            this.tabPage1.Controls.Add(this.txtOtelAd);
            this.tabPage1.Controls.Add(this.lblOtelAd);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.pctrbxOtelResmi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 420);
            this.tabPage1.TabIndex = 0;
            // 
            // lblOdaSayisiUyari
            // 
            this.lblOdaSayisiUyari.AutoSize = true;
            this.lblOdaSayisiUyari.ForeColor = System.Drawing.Color.Red;
            this.lblOdaSayisiUyari.Location = new System.Drawing.Point(671, 203);
            this.lblOdaSayisiUyari.Name = "lblOdaSayisiUyari";
            this.lblOdaSayisiUyari.Size = new System.Drawing.Size(161, 13);
            this.lblOdaSayisiUyari.TabIndex = 23;
            this.lblOdaSayisiUyari.Text = "** 1 den küçük sayı giremezsiniz!";
            this.lblOdaSayisiUyari.Visible = false;
            // 
            // lblTelNoUyari
            // 
            this.lblTelNoUyari.AutoSize = true;
            this.lblTelNoUyari.ForeColor = System.Drawing.Color.Red;
            this.lblTelNoUyari.Location = new System.Drawing.Point(370, 203);
            this.lblTelNoUyari.Name = "lblTelNoUyari";
            this.lblTelNoUyari.Size = new System.Drawing.Size(107, 13);
            this.lblTelNoUyari.TabIndex = 22;
            this.lblTelNoUyari.Text = "** Eksik Tel No Girişi!";
            this.lblTelNoUyari.Visible = false;
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(455, 301);
            this.txtIlce.MaxLength = 40;
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(157, 20);
            this.txtIlce.TabIndex = 21;
            this.txtIlce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIlce_KeyPress);
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(435, 261);
            this.txtIl.MaxLength = 40;
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(177, 20);
            this.txtIl.TabIndex = 20;
            this.txtIl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIl_KeyPress);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamEt.Location = new System.Drawing.Point(741, 352);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(138, 46);
            this.btnDevamEt.TabIndex = 19;
            this.btnDevamEt.Text = "DEVAM ET";
            this.btnDevamEt.UseVisualStyleBackColor = false;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.BackColor = System.Drawing.Color.Black;
            this.lblIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIlce.Location = new System.Drawing.Point(398, 304);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(51, 17);
            this.lblIlce.TabIndex = 16;
            this.lblIlce.Text = "İLÇE :";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.BackColor = System.Drawing.Color.Black;
            this.lblIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIl.Location = new System.Drawing.Point(398, 262);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(31, 17);
            this.lblIl.TabIndex = 15;
            this.lblIl.Text = "İL :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(28, 261);
            this.txtAdres.MaxLength = 200;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(340, 122);
            this.txtAdres.TabIndex = 14;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Black;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdres.Location = new System.Drawing.Point(25, 232);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(75, 17);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "ADRES : ";
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(674, 180);
            this.txtOdaSayisi.MaxLength = 4;
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(157, 20);
            this.txtOdaSayisi.TabIndex = 12;
            this.txtOdaSayisi.Click += new System.EventHandler(this.txtOdaSayisi_Click);
            this.txtOdaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.BackColor = System.Drawing.Color.Black;
            this.lblOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOdaSayisi.Location = new System.Drawing.Point(568, 183);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(109, 17);
            this.lblOdaSayisi.TabIndex = 11;
            this.lblOdaSayisi.Text = "ODA SAYISI : ";
            // 
            // mskdtxtOtelTelNo
            // 
            this.mskdtxtOtelTelNo.Location = new System.Drawing.Point(357, 180);
            this.mskdtxtOtelTelNo.Mask = "(999) 000-0000";
            this.mskdtxtOtelTelNo.Name = "mskdtxtOtelTelNo";
            this.mskdtxtOtelTelNo.Size = new System.Drawing.Size(128, 20);
            this.mskdtxtOtelTelNo.TabIndex = 10;
            this.mskdtxtOtelTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdtxtOtelTelNo.Click += new System.EventHandler(this.mskdtxtOtelTelNo_Click);
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Black;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTelNo.Location = new System.Drawing.Point(270, 180);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(80, 17);
            this.lblTelNo.TabIndex = 9;
            this.lblTelNo.Text = "TEL NO : ";
            // 
            // lblEPostaKontrol
            // 
            this.lblEPostaKontrol.AutoSize = true;
            this.lblEPostaKontrol.BackColor = System.Drawing.Color.Black;
            this.lblEPostaKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEPostaKontrol.ForeColor = System.Drawing.Color.Red;
            this.lblEPostaKontrol.Location = new System.Drawing.Point(568, 37);
            this.lblEPostaKontrol.Name = "lblEPostaKontrol";
            this.lblEPostaKontrol.Size = new System.Drawing.Size(209, 17);
            this.lblEPostaKontrol.TabIndex = 8;
            this.lblEPostaKontrol.Text = "E-POSTA GEREKSİNİMLERİ";
            // 
            // chckdlstbxEPosta
            // 
            this.chckdlstbxEPosta.Enabled = false;
            this.chckdlstbxEPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckdlstbxEPosta.FormattingEnabled = true;
            this.chckdlstbxEPosta.Items.AddRange(new object[] {
            "@ ÖNCESİ BİLGİ GİRİŞİ",
            "@ İŞARETİ KULLANIMI",
            "POSTA ADRESİ GİRİLMESİ"});
            this.chckdlstbxEPosta.Location = new System.Drawing.Point(571, 57);
            this.chckdlstbxEPosta.Name = "chckdlstbxEPosta";
            this.chckdlstbxEPosta.Size = new System.Drawing.Size(261, 49);
            this.chckdlstbxEPosta.TabIndex = 7;
            // 
            // txtOtelEPosta
            // 
            this.txtOtelEPosta.Location = new System.Drawing.Point(655, 122);
            this.txtOtelEPosta.MaxLength = 40;
            this.txtOtelEPosta.Name = "txtOtelEPosta";
            this.txtOtelEPosta.Size = new System.Drawing.Size(177, 20);
            this.txtOtelEPosta.TabIndex = 6;
            this.txtOtelEPosta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOtelEPosta_KeyUp);
            // 
            // lblEPosta
            // 
            this.lblEPosta.AutoSize = true;
            this.lblEPosta.BackColor = System.Drawing.Color.Black;
            this.lblEPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEPosta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEPosta.Location = new System.Drawing.Point(568, 122);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(91, 17);
            this.lblEPosta.TabIndex = 5;
            this.lblEPosta.Text = "E-POSTA : ";
            // 
            // grpbxOtelYildizSayisi
            // 
            this.grpbxOtelYildizSayisi.BackColor = System.Drawing.Color.Black;
            this.grpbxOtelYildizSayisi.Controls.Add(this.rdbtnYildiz5);
            this.grpbxOtelYildizSayisi.Controls.Add(this.rdbtnYildiz4);
            this.grpbxOtelYildizSayisi.Controls.Add(this.rdbtnYildiz3);
            this.grpbxOtelYildizSayisi.Controls.Add(this.rdbtnYildiz2);
            this.grpbxOtelYildizSayisi.Controls.Add(this.rdbtnYildiz1);
            this.grpbxOtelYildizSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxOtelYildizSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpbxOtelYildizSayisi.Location = new System.Drawing.Point(272, 95);
            this.grpbxOtelYildizSayisi.Name = "grpbxOtelYildizSayisi";
            this.grpbxOtelYildizSayisi.Size = new System.Drawing.Size(213, 47);
            this.grpbxOtelYildizSayisi.TabIndex = 4;
            this.grpbxOtelYildizSayisi.TabStop = false;
            this.grpbxOtelYildizSayisi.Text = "YILDIZ ";
            // 
            // rdbtnYildiz5
            // 
            this.rdbtnYildiz5.AutoSize = true;
            this.rdbtnYildiz5.Location = new System.Drawing.Point(168, 19);
            this.rdbtnYildiz5.Name = "rdbtnYildiz5";
            this.rdbtnYildiz5.Size = new System.Drawing.Size(32, 17);
            this.rdbtnYildiz5.TabIndex = 5;
            this.rdbtnYildiz5.TabStop = true;
            this.rdbtnYildiz5.Text = "5";
            this.rdbtnYildiz5.UseVisualStyleBackColor = true;
            // 
            // rdbtnYildiz4
            // 
            this.rdbtnYildiz4.AutoSize = true;
            this.rdbtnYildiz4.Location = new System.Drawing.Point(129, 19);
            this.rdbtnYildiz4.Name = "rdbtnYildiz4";
            this.rdbtnYildiz4.Size = new System.Drawing.Size(32, 17);
            this.rdbtnYildiz4.TabIndex = 6;
            this.rdbtnYildiz4.TabStop = true;
            this.rdbtnYildiz4.Text = "4";
            this.rdbtnYildiz4.UseVisualStyleBackColor = true;
            // 
            // rdbtnYildiz3
            // 
            this.rdbtnYildiz3.AutoSize = true;
            this.rdbtnYildiz3.Location = new System.Drawing.Point(91, 19);
            this.rdbtnYildiz3.Name = "rdbtnYildiz3";
            this.rdbtnYildiz3.Size = new System.Drawing.Size(32, 17);
            this.rdbtnYildiz3.TabIndex = 2;
            this.rdbtnYildiz3.TabStop = true;
            this.rdbtnYildiz3.Text = "3";
            this.rdbtnYildiz3.UseVisualStyleBackColor = true;
            // 
            // rdbtnYildiz2
            // 
            this.rdbtnYildiz2.AutoSize = true;
            this.rdbtnYildiz2.Location = new System.Drawing.Point(53, 19);
            this.rdbtnYildiz2.Name = "rdbtnYildiz2";
            this.rdbtnYildiz2.Size = new System.Drawing.Size(32, 17);
            this.rdbtnYildiz2.TabIndex = 1;
            this.rdbtnYildiz2.TabStop = true;
            this.rdbtnYildiz2.Text = "2";
            this.rdbtnYildiz2.UseVisualStyleBackColor = true;
            // 
            // rdbtnYildiz1
            // 
            this.rdbtnYildiz1.AutoSize = true;
            this.rdbtnYildiz1.Location = new System.Drawing.Point(15, 19);
            this.rdbtnYildiz1.Name = "rdbtnYildiz1";
            this.rdbtnYildiz1.Size = new System.Drawing.Size(32, 17);
            this.rdbtnYildiz1.TabIndex = 0;
            this.rdbtnYildiz1.TabStop = true;
            this.rdbtnYildiz1.Text = "1";
            this.rdbtnYildiz1.UseVisualStyleBackColor = true;
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOtelAd.Location = new System.Drawing.Point(320, 48);
            this.txtOtelAd.MaxLength = 40;
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(152, 20);
            this.txtOtelAd.TabIndex = 3;
            this.txtOtelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtelAd_KeyPress);
            // 
            // lblOtelAd
            // 
            this.lblOtelAd.AutoSize = true;
            this.lblOtelAd.BackColor = System.Drawing.Color.Black;
            this.lblOtelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOtelAd.Location = new System.Drawing.Point(270, 49);
            this.lblOtelAd.Name = "lblOtelAd";
            this.lblOtelAd.Size = new System.Drawing.Size(44, 17);
            this.lblOtelAd.TabIndex = 2;
            this.lblOtelAd.Text = "AD : ";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEkle.Location = new System.Drawing.Point(154, 141);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(26, 22);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pctrbxOtelResmi
            // 
            this.pctrbxOtelResmi.BackColor = System.Drawing.Color.White;
            this.pctrbxOtelResmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrbxOtelResmi.Location = new System.Drawing.Point(28, 22);
            this.pctrbxOtelResmi.Name = "pctrbxOtelResmi";
            this.pctrbxOtelResmi.Size = new System.Drawing.Size(161, 128);
            this.pctrbxOtelResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxOtelResmi.TabIndex = 0;
            this.pctrbxOtelResmi.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.lblSiraliOda);
            this.tabPage2.Controls.Add(this.btnOdaEkle);
            this.tabPage2.Controls.Add(this.grpbxOdaBilgisi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 420);
            this.tabPage2.TabIndex = 1;
            // 
            // lblSiraliOda
            // 
            this.lblSiraliOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiraliOda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSiraliOda.Location = new System.Drawing.Point(755, 78);
            this.lblSiraliOda.Name = "lblSiraliOda";
            this.lblSiraliOda.Size = new System.Drawing.Size(100, 23);
            this.lblSiraliOda.TabIndex = 2;
            this.lblSiraliOda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOdaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaEkle.Location = new System.Drawing.Point(723, 355);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(144, 38);
            this.btnOdaEkle.TabIndex = 1;
            this.btnOdaEkle.Text = "EKLE";
            this.btnOdaEkle.UseVisualStyleBackColor = false;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // grpbxOdaBilgisi
            // 
            this.grpbxOdaBilgisi.BackColor = System.Drawing.Color.Black;
            this.grpbxOdaBilgisi.Controls.Add(this.lblKisiSayisiUyari);
            this.grpbxOdaBilgisi.Controls.Add(this.lblOdaTelNoUyari);
            this.grpbxOdaBilgisi.Controls.Add(this.txtFiyat);
            this.grpbxOdaBilgisi.Controls.Add(this.lblFiyat);
            this.grpbxOdaBilgisi.Controls.Add(this.cmbxManzaraBilgisi);
            this.grpbxOdaBilgisi.Controls.Add(this.lblManzaraBilgisi);
            this.grpbxOdaBilgisi.Controls.Add(this.txtKisiSayisi);
            this.grpbxOdaBilgisi.Controls.Add(this.lblKisiSayisi);
            this.grpbxOdaBilgisi.Controls.Add(this.mskdtxtOdaTelNo);
            this.grpbxOdaBilgisi.Controls.Add(this.lblOdaTelNo);
            this.grpbxOdaBilgisi.Controls.Add(this.txtOdaNo);
            this.grpbxOdaBilgisi.Controls.Add(this.lblOdaNo);
            this.grpbxOdaBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxOdaBilgisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpbxOdaBilgisi.Location = new System.Drawing.Point(38, 95);
            this.grpbxOdaBilgisi.Name = "grpbxOdaBilgisi";
            this.grpbxOdaBilgisi.Size = new System.Drawing.Size(845, 241);
            this.grpbxOdaBilgisi.TabIndex = 0;
            this.grpbxOdaBilgisi.TabStop = false;
            this.grpbxOdaBilgisi.Text = "ODA BİLGİ";
            // 
            // lblKisiSayisiUyari
            // 
            this.lblKisiSayisiUyari.AutoSize = true;
            this.lblKisiSayisiUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiSayisiUyari.ForeColor = System.Drawing.Color.Red;
            this.lblKisiSayisiUyari.Location = new System.Drawing.Point(98, 196);
            this.lblKisiSayisiUyari.Name = "lblKisiSayisiUyari";
            this.lblKisiSayisiUyari.Size = new System.Drawing.Size(217, 13);
            this.lblKisiSayisiUyari.TabIndex = 13;
            this.lblKisiSayisiUyari.Text = "** Kişi Sayısı 1 den Küçük Girilemez! ";
            this.lblKisiSayisiUyari.Visible = false;
            // 
            // lblOdaTelNoUyari
            // 
            this.lblOdaTelNoUyari.AutoSize = true;
            this.lblOdaTelNoUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaTelNoUyari.ForeColor = System.Drawing.Color.Red;
            this.lblOdaTelNoUyari.Location = new System.Drawing.Point(99, 141);
            this.lblOdaTelNoUyari.Name = "lblOdaTelNoUyari";
            this.lblOdaTelNoUyari.Size = new System.Drawing.Size(153, 13);
            this.lblOdaTelNoUyari.TabIndex = 12;
            this.lblOdaTelNoUyari.Text = "** Tel No Eksik Girilmiştir!";
            this.lblOdaTelNoUyari.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(664, 170);
            this.txtFiyat.MaxLength = 7;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(128, 23);
            this.txtFiyat.TabIndex = 11;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Black;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFiyat.Location = new System.Drawing.Point(595, 173);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(61, 17);
            this.lblFiyat.TabIndex = 10;
            this.lblFiyat.Text = "FİYAT :";
            // 
            // cmbxManzaraBilgisi
            // 
            this.cmbxManzaraBilgisi.FormattingEnabled = true;
            this.cmbxManzaraBilgisi.Items.AddRange(new object[] {
            "DAĞ ",
            "DENİZ"});
            this.cmbxManzaraBilgisi.Location = new System.Drawing.Point(374, 130);
            this.cmbxManzaraBilgisi.Name = "cmbxManzaraBilgisi";
            this.cmbxManzaraBilgisi.Size = new System.Drawing.Size(137, 24);
            this.cmbxManzaraBilgisi.TabIndex = 9;
            // 
            // lblManzaraBilgisi
            // 
            this.lblManzaraBilgisi.AutoSize = true;
            this.lblManzaraBilgisi.BackColor = System.Drawing.Color.Black;
            this.lblManzaraBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManzaraBilgisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblManzaraBilgisi.Location = new System.Drawing.Point(371, 109);
            this.lblManzaraBilgisi.Name = "lblManzaraBilgisi";
            this.lblManzaraBilgisi.Size = new System.Drawing.Size(140, 17);
            this.lblManzaraBilgisi.TabIndex = 8;
            this.lblManzaraBilgisi.Text = "MANZARA BİLGİSİ";
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Location = new System.Drawing.Point(124, 170);
            this.txtKisiSayisi.MaxLength = 2;
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(128, 23);
            this.txtKisiSayisi.TabIndex = 7;
            this.txtKisiSayisi.Click += new System.EventHandler(this.txtKisiSayisi_Click);
            this.txtKisiSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKisiSayisi_KeyPress);
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.BackColor = System.Drawing.Color.Black;
            this.lblKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblKisiSayisi.Location = new System.Drawing.Point(19, 173);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(99, 17);
            this.lblKisiSayisi.TabIndex = 6;
            this.lblKisiSayisi.Text = "KİŞİ SAYISI :";
            // 
            // mskdtxtOdaTelNo
            // 
            this.mskdtxtOdaTelNo.Location = new System.Drawing.Point(101, 109);
            this.mskdtxtOdaTelNo.Mask = "(999) 000-0000";
            this.mskdtxtOdaTelNo.Name = "mskdtxtOdaTelNo";
            this.mskdtxtOdaTelNo.Size = new System.Drawing.Size(151, 23);
            this.mskdtxtOdaTelNo.TabIndex = 5;
            this.mskdtxtOdaTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdtxtOdaTelNo.Click += new System.EventHandler(this.mskdtxtOdaTelNo_Click);
            // 
            // lblOdaTelNo
            // 
            this.lblOdaTelNo.AutoSize = true;
            this.lblOdaTelNo.BackColor = System.Drawing.Color.Black;
            this.lblOdaTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOdaTelNo.Location = new System.Drawing.Point(19, 109);
            this.lblOdaTelNo.Name = "lblOdaTelNo";
            this.lblOdaTelNo.Size = new System.Drawing.Size(75, 17);
            this.lblOdaTelNo.TabIndex = 4;
            this.lblOdaTelNo.Text = "TEL NO :";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(66, 36);
            this.txtOdaNo.MaxLength = 9;
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(100, 23);
            this.txtOdaNo.TabIndex = 3;
            this.txtOdaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaNo_KeyPress);
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.BackColor = System.Drawing.Color.Black;
            this.lblOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOdaNo.Location = new System.Drawing.Point(19, 37);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(41, 17);
            this.lblOdaNo.TabIndex = 2;
            this.lblOdaNo.Text = "NO :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOdaBilgisi
            // 
            this.lblOdaBilgisi.BackColor = System.Drawing.Color.Black;
            this.lblOdaBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaBilgisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOdaBilgisi.Location = new System.Drawing.Point(693, 20);
            this.lblOdaBilgisi.Name = "lblOdaBilgisi";
            this.lblOdaBilgisi.Size = new System.Drawing.Size(107, 69);
            this.lblOdaBilgisi.TabIndex = 4;
            this.lblOdaBilgisi.Text = "ODA BİLGİSİ OLUŞTUR";
            this.lblOdaBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIkıncıDugum
            // 
            this.lblIkıncıDugum.BackColor = System.Drawing.Color.Red;
            this.lblIkıncıDugum.Location = new System.Drawing.Point(731, 106);
            this.lblIkıncıDugum.Name = "lblIkıncıDugum";
            this.lblIkıncıDugum.Size = new System.Drawing.Size(25, 26);
            this.lblIkıncıDugum.TabIndex = 5;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(119, 222);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmOtelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 613);
            this.Controls.Add(this.lblIkıncıDugum);
            this.Controls.Add(this.lblOdaBilgisi);
            this.Controls.Add(this.tbcntrlOtelBilgi);
            this.Controls.Add(this.lblOtelBilgisi);
            this.Controls.Add(this.lblBirinciDugum);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOtelEkle";
            this.Text = "frmOtelEkle";
            this.Load += new System.EventHandler(this.frmOtelEkle_Load);
            this.tbcntrlOtelBilgi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpbxOtelYildizSayisi.ResumeLayout(false);
            this.grpbxOtelYildizSayisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxOtelResmi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grpbxOdaBilgisi.ResumeLayout(false);
            this.grpbxOdaBilgisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrpckZamanlayici;
        private System.Windows.Forms.Label lblBirinciDugum;
        private System.Windows.Forms.Label lblOtelBilgisi;
        private System.Windows.Forms.TabControl tbcntrlOtelBilgi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pctrbxOtelResmi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtOtelAd;
        private System.Windows.Forms.Label lblOtelAd;
        private System.Windows.Forms.GroupBox grpbxOtelYildizSayisi;
        private System.Windows.Forms.RadioButton rdbtnYildiz5;
        private System.Windows.Forms.RadioButton rdbtnYildiz4;
        private System.Windows.Forms.RadioButton rdbtnYildiz3;
        private System.Windows.Forms.RadioButton rdbtnYildiz2;
        private System.Windows.Forms.RadioButton rdbtnYildiz1;
        private System.Windows.Forms.TextBox txtOtelEPosta;
        private System.Windows.Forms.Label lblEPosta;
        private System.Windows.Forms.CheckedListBox chckdlstbxEPosta;
        private System.Windows.Forms.Label lblEPostaKontrol;
        private System.Windows.Forms.MaskedTextBox mskdtxtOtelTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtOdaSayisi;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblOdaBilgisi;
        private System.Windows.Forms.Label lblIkıncıDugum;
        private System.Windows.Forms.GroupBox grpbxOdaBilgisi;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtOdaTelNo;
        private System.Windows.Forms.Label lblOdaTelNo;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.ComboBox cmbxManzaraBilgisi;
        private System.Windows.Forms.Label lblManzaraBilgisi;
        private System.Windows.Forms.Label lblSiraliOda;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.Label lblTelNoUyari;
        private System.Windows.Forms.Label lblOdaSayisiUyari;
        private System.Windows.Forms.Label lblOdaTelNoUyari;
        private System.Windows.Forms.Label lblKisiSayisiUyari;
        public System.Windows.Forms.ImageList ımageList1;
    }
}