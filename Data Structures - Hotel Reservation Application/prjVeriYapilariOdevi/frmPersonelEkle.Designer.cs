
namespace prjVeriYapilariOdevi
{
    partial class frmPersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelEkle));
            this.lblOtelAd = new System.Windows.Forms.Label();
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSayi = new System.Windows.Forms.TextBox();
            this.lblPersonelSayisi = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblEtiket = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.mskdtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.chckdlstbxEPosta = new System.Windows.Forms.CheckedListBox();
            this.lblEPostaKontrol = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtPersonelEPosta = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.lblPoziyon = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSiraliPersonel = new System.Windows.Forms.Label();
            this.lblTCNoUyari = new System.Windows.Forms.Label();
            this.lblTelNoUyarisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOtelAd
            // 
            this.lblOtelAd.AutoSize = true;
            this.lblOtelAd.BackColor = System.Drawing.Color.Black;
            this.lblOtelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOtelAd.Location = new System.Drawing.Point(53, 49);
            this.lblOtelAd.Name = "lblOtelAd";
            this.lblOtelAd.Size = new System.Drawing.Size(85, 17);
            this.lblOtelAd.TabIndex = 0;
            this.lblOtelAd.Text = "OTEL AD :";
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(154, 49);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(150, 20);
            this.txtOtelAd.TabIndex = 1;
            this.txtOtelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtelAd_KeyPress);
            // 
            // txtPersonelSayi
            // 
            this.txtPersonelSayi.Location = new System.Drawing.Point(481, 52);
            this.txtPersonelSayi.Name = "txtPersonelSayi";
            this.txtPersonelSayi.Size = new System.Drawing.Size(84, 20);
            this.txtPersonelSayi.TabIndex = 3;
            this.txtPersonelSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSayi_KeyPress);
            // 
            // lblPersonelSayisi
            // 
            this.lblPersonelSayisi.AutoSize = true;
            this.lblPersonelSayisi.BackColor = System.Drawing.Color.Black;
            this.lblPersonelSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPersonelSayisi.Location = new System.Drawing.Point(335, 52);
            this.lblPersonelSayisi.Name = "lblPersonelSayisi";
            this.lblPersonelSayisi.Size = new System.Drawing.Size(140, 17);
            this.lblPersonelSayisi.TabIndex = 2;
            this.lblPersonelSayisi.Text = "PERSONEL SAYI :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAra.Location = new System.Drawing.Point(613, 42);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(54, 36);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblEtiket
            // 
            this.lblEtiket.BackColor = System.Drawing.Color.Black;
            this.lblEtiket.Location = new System.Drawing.Point(53, 159);
            this.lblEtiket.Name = "lblEtiket";
            this.lblEtiket.Size = new System.Drawing.Size(795, 296);
            this.lblEtiket.TabIndex = 5;
            this.lblEtiket.Visible = false;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(152, 203);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 7;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Black;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAd.Location = new System.Drawing.Point(73, 206);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 17);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "AD :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(150, 236);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtSoyad.TabIndex = 9;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Black;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSoyad.Location = new System.Drawing.Point(73, 236);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(71, 17);
            this.lblSoyad.TabIndex = 8;
            this.lblSoyad.Text = "SOYAD :";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(423, 203);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(150, 20);
            this.txtTCNo.TabIndex = 11;
            this.txtTCNo.Click += new System.EventHandler(this.txtTCNo_Click);
            this.txtTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCNo_KeyPress);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.BackColor = System.Drawing.Color.Black;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTCNo.Location = new System.Drawing.Point(351, 204);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(66, 17);
            this.lblTCNo.TabIndex = 10;
            this.lblTCNo.Text = "TC NO :";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Black;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTelNo.Location = new System.Drawing.Point(351, 253);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(75, 17);
            this.lblTelNo.TabIndex = 12;
            this.lblTelNo.Text = "TEL NO :";
            // 
            // mskdtxtTelNo
            // 
            this.mskdtxtTelNo.Location = new System.Drawing.Point(432, 252);
            this.mskdtxtTelNo.Mask = "(999) 000-0000";
            this.mskdtxtTelNo.Name = "mskdtxtTelNo";
            this.mskdtxtTelNo.Size = new System.Drawing.Size(141, 20);
            this.mskdtxtTelNo.TabIndex = 13;
            this.mskdtxtTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskdtxtTelNo.Click += new System.EventHandler(this.mskdtxtTelNo_Click);
            // 
            // chckdlstbxEPosta
            // 
            this.chckdlstbxEPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckdlstbxEPosta.FormattingEnabled = true;
            this.chckdlstbxEPosta.Items.AddRange(new object[] {
            "@ ÖNCESİ BİLGİ GİRİŞİ",
            "@ İŞARETİ KULLANIMI",
            "POSTA ADRESİ GİRİLMESİ"});
            this.chckdlstbxEPosta.Location = new System.Drawing.Point(89, 324);
            this.chckdlstbxEPosta.Name = "chckdlstbxEPosta";
            this.chckdlstbxEPosta.Size = new System.Drawing.Size(188, 49);
            this.chckdlstbxEPosta.TabIndex = 14;
            // 
            // lblEPostaKontrol
            // 
            this.lblEPostaKontrol.AutoSize = true;
            this.lblEPostaKontrol.BackColor = System.Drawing.Color.Black;
            this.lblEPostaKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEPostaKontrol.ForeColor = System.Drawing.Color.Red;
            this.lblEPostaKontrol.Location = new System.Drawing.Point(86, 304);
            this.lblEPostaKontrol.Name = "lblEPostaKontrol";
            this.lblEPostaKontrol.Size = new System.Drawing.Size(209, 17);
            this.lblEPostaKontrol.TabIndex = 15;
            this.lblEPostaKontrol.Text = "E-POSTA GEREKSİNİMLERİ";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.BackColor = System.Drawing.Color.Black;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEposta.Location = new System.Drawing.Point(86, 386);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(86, 17);
            this.lblEposta.TabIndex = 16;
            this.lblEposta.Text = "E-POSTA :";
            // 
            // txtPersonelEPosta
            // 
            this.txtPersonelEPosta.Location = new System.Drawing.Point(179, 386);
            this.txtPersonelEPosta.Name = "txtPersonelEPosta";
            this.txtPersonelEPosta.Size = new System.Drawing.Size(144, 20);
            this.txtPersonelEPosta.TabIndex = 17;
            this.txtPersonelEPosta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPersonelEPosta_KeyUp);
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(470, 344);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(150, 20);
            this.txtDepartman.TabIndex = 19;
            this.txtDepartman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartman_KeyPress);
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.BackColor = System.Drawing.Color.Black;
            this.lblDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDepartman.Location = new System.Drawing.Point(351, 347);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(113, 17);
            this.lblDepartman.TabIndex = 18;
            this.lblDepartman.Text = "DEPARTMAN :";
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Location = new System.Drawing.Point(470, 383);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(150, 20);
            this.txtPozisyon.TabIndex = 21;
            this.txtPozisyon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPozisyon_KeyPress);
            // 
            // lblPoziyon
            // 
            this.lblPoziyon.AutoSize = true;
            this.lblPoziyon.BackColor = System.Drawing.Color.Black;
            this.lblPoziyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoziyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPoziyon.Location = new System.Drawing.Point(351, 386);
            this.lblPoziyon.Name = "lblPoziyon";
            this.lblPoziyon.Size = new System.Drawing.Size(97, 17);
            this.lblPoziyon.TabIndex = 20;
            this.lblPoziyon.Text = "POZİSYON :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(628, 216);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(196, 122);
            this.txtAdres.TabIndex = 23;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Black;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdres.Location = new System.Drawing.Point(693, 196);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(60, 17);
            this.lblAdres.TabIndex = 22;
            this.lblAdres.Text = "ADRES";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Location = new System.Drawing.Point(738, 471);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 33);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Visible = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSiraliPersonel
            // 
            this.lblSiraliPersonel.BackColor = System.Drawing.Color.Black;
            this.lblSiraliPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiraliPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSiraliPersonel.Location = new System.Drawing.Point(693, 127);
            this.lblSiraliPersonel.Name = "lblSiraliPersonel";
            this.lblSiraliPersonel.Size = new System.Drawing.Size(100, 32);
            this.lblSiraliPersonel.TabIndex = 25;
            this.lblSiraliPersonel.Text = "a";
            this.lblSiraliPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSiraliPersonel.Visible = false;
            // 
            // lblTCNoUyari
            // 
            this.lblTCNoUyari.AutoSize = true;
            this.lblTCNoUyari.BackColor = System.Drawing.Color.Black;
            this.lblTCNoUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNoUyari.ForeColor = System.Drawing.Color.Red;
            this.lblTCNoUyari.Location = new System.Drawing.Point(428, 226);
            this.lblTCNoUyari.Name = "lblTCNoUyari";
            this.lblTCNoUyari.Size = new System.Drawing.Size(137, 13);
            this.lblTCNoUyari.TabIndex = 26;
            this.lblTCNoUyari.Text = "** TC No eksik girilmiş!";
            this.lblTCNoUyari.Visible = false;
            // 
            // lblTelNoUyarisi
            // 
            this.lblTelNoUyarisi.AutoSize = true;
            this.lblTelNoUyarisi.BackColor = System.Drawing.Color.Black;
            this.lblTelNoUyarisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNoUyarisi.ForeColor = System.Drawing.Color.Red;
            this.lblTelNoUyarisi.Location = new System.Drawing.Point(432, 279);
            this.lblTelNoUyarisi.Name = "lblTelNoUyarisi";
            this.lblTelNoUyarisi.Size = new System.Drawing.Size(139, 13);
            this.lblTelNoUyarisi.TabIndex = 27;
            this.lblTelNoUyarisi.Text = "** Tel No eksik girilmiş!";
            this.lblTelNoUyarisi.Visible = false;
            // 
            // frmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 541);
            this.Controls.Add(this.lblTelNoUyarisi);
            this.Controls.Add(this.lblTCNoUyari);
            this.Controls.Add(this.lblSiraliPersonel);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.lblPoziyon);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.txtPersonelEPosta);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblEPostaKontrol);
            this.Controls.Add(this.chckdlstbxEPosta);
            this.Controls.Add(this.mskdtxtTelNo);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblEtiket);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtPersonelSayi);
            this.Controls.Add(this.lblPersonelSayisi);
            this.Controls.Add(this.txtOtelAd);
            this.Controls.Add(this.lblOtelAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelEkle";
            this.Text = "frmPersonelEkle";
            this.Load += new System.EventHandler(this.frmPersonelEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelAd;
        private System.Windows.Forms.TextBox txtOtelAd;
        private System.Windows.Forms.TextBox txtPersonelSayi;
        private System.Windows.Forms.Label lblPersonelSayisi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblEtiket;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtTelNo;
        private System.Windows.Forms.CheckedListBox chckdlstbxEPosta;
        private System.Windows.Forms.Label lblEPostaKontrol;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtPersonelEPosta;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.Label lblPoziyon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSiraliPersonel;
        private System.Windows.Forms.Label lblTCNoUyari;
        private System.Windows.Forms.Label lblTelNoUyarisi;
    }
}