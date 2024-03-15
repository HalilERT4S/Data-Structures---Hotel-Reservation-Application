
namespace prjVeriYapilariOdevi
{
    partial class frmOtelRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtelRezervasyon));
            this.imglstYildizSayisi = new System.Windows.Forms.ImageList(this.components);
            this.lvOdalar = new System.Windows.Forms.ListView();
            this.lblResim = new System.Windows.Forms.Label();
            this.lblYildizSayisi = new System.Windows.Forms.Label();
            this.lblOtelAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imglstYildizSayisi
            // 
            this.imglstYildizSayisi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstYildizSayisi.ImageStream")));
            this.imglstYildizSayisi.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstYildizSayisi.Images.SetKeyName(0, "1 yıldız.jpg");
            this.imglstYildizSayisi.Images.SetKeyName(1, "2 yıldız.jpg");
            this.imglstYildizSayisi.Images.SetKeyName(2, "3 yıldız.jpg");
            this.imglstYildizSayisi.Images.SetKeyName(3, "4 yıldız.jpg");
            this.imglstYildizSayisi.Images.SetKeyName(4, "5 yıldız.png");
            // 
            // lvOdalar
            // 
            this.lvOdalar.FullRowSelect = true;
            this.lvOdalar.GridLines = true;
            this.lvOdalar.HideSelection = false;
            this.lvOdalar.Location = new System.Drawing.Point(12, 197);
            this.lvOdalar.Name = "lvOdalar";
            this.lvOdalar.Size = new System.Drawing.Size(738, 345);
            this.lvOdalar.TabIndex = 1;
            this.lvOdalar.UseCompatibleStateImageBehavior = false;
            this.lvOdalar.View = System.Windows.Forms.View.Details;
            this.lvOdalar.SelectedIndexChanged += new System.EventHandler(this.lvOdalar_SelectedIndexChanged);
            // 
            // lblResim
            // 
            this.lblResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResim.Location = new System.Drawing.Point(13, 13);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(193, 181);
            this.lblResim.TabIndex = 2;
            // 
            // lblYildizSayisi
            // 
            this.lblYildizSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYildizSayisi.Location = new System.Drawing.Point(212, 62);
            this.lblYildizSayisi.Name = "lblYildizSayisi";
            this.lblYildizSayisi.Size = new System.Drawing.Size(138, 41);
            this.lblYildizSayisi.TabIndex = 3;
            // 
            // lblOtelAdi
            // 
            this.lblOtelAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOtelAdi.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtelAdi.Location = new System.Drawing.Point(212, 13);
            this.lblOtelAdi.Name = "lblOtelAdi";
            this.lblOtelAdi.Size = new System.Drawing.Size(538, 40);
            this.lblOtelAdi.TabIndex = 4;
            // 
            // frmOtelRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 554);
            this.Controls.Add(this.lblOtelAdi);
            this.Controls.Add(this.lblYildizSayisi);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lvOdalar);
            this.Name = "frmOtelRezervasyon";
            this.Text = "frmOtelRezervasyon";
            this.Load += new System.EventHandler(this.frmOtelRezervasyon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglstYildizSayisi;
        private System.Windows.Forms.ListView lvOdalar;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label lblYildizSayisi;
        private System.Windows.Forms.Label lblOtelAdi;
    }
}