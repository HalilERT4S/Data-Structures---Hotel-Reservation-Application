
namespace prjVeriYapilariOdevi
{
    partial class frmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanici));
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblIl = new System.Windows.Forms.Label();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.lblIlce = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbxArama = new System.Windows.Forms.ComboBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.cmbxSiralamaAlgoritmasi = new System.Windows.Forms.ComboBox();
            this.lblArmaAlgoritmasi = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtDugumSayisi = new System.Windows.Forms.TextBox();
            this.lblDugumSayisi = new System.Windows.Forms.Label();
            this.txtDerinlikSayisi = new System.Windows.Forms.TextBox();
            this.lblDerinlikSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 213);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 345);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.BackColor = System.Drawing.Color.Black;
            this.lblIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIl.Location = new System.Drawing.Point(11, 60);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(36, 17);
            this.lblIl.TabIndex = 1;
            this.lblIl.Text = "IL : ";
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(53, 57);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(124, 20);
            this.txtIl.TabIndex = 2;
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(275, 59);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(124, 20);
            this.txtIlce.TabIndex = 4;
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.BackColor = System.Drawing.Color.Black;
            this.lblIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIlce.Location = new System.Drawing.Point(213, 60);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(56, 17);
            this.lblIlce.TabIndex = 3;
            this.lblIlce.Text = "ILCE : ";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(275, 109);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(91, 29);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbxArama
            // 
            this.cmbxArama.FormattingEnabled = true;
            this.cmbxArama.Items.AddRange(new object[] {
            "İSİM SIRALA (A-Z)",
            "İSİM SIRALA (Z-A)",
            "PUAN SIRALA (AZALANA DOĞRU)",
            "PUAN SIRALA (ARTANA DOĞRU)",
            "YILDIZ SIRALA (AZALANA DOĞRU)",
            "YILDIZ SIRALA (ARTANA DOĞRU)"});
            this.cmbxArama.Location = new System.Drawing.Point(136, 109);
            this.cmbxArama.Name = "cmbxArama";
            this.cmbxArama.Size = new System.Drawing.Size(121, 21);
            this.cmbxArama.TabIndex = 6;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.BackColor = System.Drawing.Color.Black;
            this.lblFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFiltre.Location = new System.Drawing.Point(164, 85);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(61, 17);
            this.lblFiltre.TabIndex = 7;
            this.lblFiltre.Text = "FİLTRE";
            // 
            // cmbxSiralamaAlgoritmasi
            // 
            this.cmbxSiralamaAlgoritmasi.FormattingEnabled = true;
            this.cmbxSiralamaAlgoritmasi.Items.AddRange(new object[] {
            "PreOrder",
            "InOrder",
            "PostOrder"});
            this.cmbxSiralamaAlgoritmasi.Location = new System.Drawing.Point(579, 81);
            this.cmbxSiralamaAlgoritmasi.Name = "cmbxSiralamaAlgoritmasi";
            this.cmbxSiralamaAlgoritmasi.Size = new System.Drawing.Size(121, 21);
            this.cmbxSiralamaAlgoritmasi.TabIndex = 8;
            // 
            // lblArmaAlgoritmasi
            // 
            this.lblArmaAlgoritmasi.AutoSize = true;
            this.lblArmaAlgoritmasi.BackColor = System.Drawing.Color.Black;
            this.lblArmaAlgoritmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArmaAlgoritmasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblArmaAlgoritmasi.Location = new System.Drawing.Point(557, 57);
            this.lblArmaAlgoritmasi.Name = "lblArmaAlgoritmasi";
            this.lblArmaAlgoritmasi.Size = new System.Drawing.Size(170, 17);
            this.lblArmaAlgoritmasi.TabIndex = 9;
            this.lblArmaAlgoritmasi.Text = "ARAMA ALGORİTMASI";
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(713, 125);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 10;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtDugumSayisi
            // 
            this.txtDugumSayisi.Enabled = false;
            this.txtDugumSayisi.Location = new System.Drawing.Point(869, 56);
            this.txtDugumSayisi.Name = "txtDugumSayisi";
            this.txtDugumSayisi.Size = new System.Drawing.Size(79, 20);
            this.txtDugumSayisi.TabIndex = 12;
            // 
            // lblDugumSayisi
            // 
            this.lblDugumSayisi.AutoSize = true;
            this.lblDugumSayisi.BackColor = System.Drawing.Color.Black;
            this.lblDugumSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDugumSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDugumSayisi.Location = new System.Drawing.Point(753, 57);
            this.lblDugumSayisi.Name = "lblDugumSayisi";
            this.lblDugumSayisi.Size = new System.Drawing.Size(121, 17);
            this.lblDugumSayisi.TabIndex = 11;
            this.lblDugumSayisi.Text = "Dugum Sayısı : ";
            // 
            // txtDerinlikSayisi
            // 
            this.txtDerinlikSayisi.Enabled = false;
            this.txtDerinlikSayisi.Location = new System.Drawing.Point(869, 84);
            this.txtDerinlikSayisi.Name = "txtDerinlikSayisi";
            this.txtDerinlikSayisi.Size = new System.Drawing.Size(79, 20);
            this.txtDerinlikSayisi.TabIndex = 14;
            // 
            // lblDerinlikSayisi
            // 
            this.lblDerinlikSayisi.AutoSize = true;
            this.lblDerinlikSayisi.BackColor = System.Drawing.Color.Black;
            this.lblDerinlikSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDerinlikSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDerinlikSayisi.Location = new System.Drawing.Point(748, 85);
            this.lblDerinlikSayisi.Name = "lblDerinlikSayisi";
            this.lblDerinlikSayisi.Size = new System.Drawing.Size(126, 17);
            this.lblDerinlikSayisi.TabIndex = 13;
            this.lblDerinlikSayisi.Text = "Derinlik Sayısı : ";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 570);
            this.Controls.Add(this.txtDerinlikSayisi);
            this.Controls.Add(this.lblDerinlikSayisi);
            this.Controls.Add(this.txtDugumSayisi);
            this.Controls.Add(this.lblDugumSayisi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.lblArmaAlgoritmasi);
            this.Controls.Add(this.cmbxSiralamaAlgoritmasi);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.cmbxArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.listView1);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbxArama;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.ComboBox cmbxSiralamaAlgoritmasi;
        private System.Windows.Forms.Label lblArmaAlgoritmasi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtDugumSayisi;
        private System.Windows.Forms.Label lblDugumSayisi;
        private System.Windows.Forms.TextBox txtDerinlikSayisi;
        private System.Windows.Forms.Label lblDerinlikSayisi;
    }
}