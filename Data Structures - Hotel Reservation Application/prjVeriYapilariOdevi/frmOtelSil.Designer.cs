
namespace prjVeriYapilariOdevi
{
    partial class frmOtelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtelSil));
            this.lblOtelAd = new System.Windows.Forms.Label();
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblEtiket = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.imglstYildiz = new System.Windows.Forms.ImageList(this.components);
            this.lblYildiz = new System.Windows.Forms.Label();
            this.lblOtel = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOtelAd
            // 
            this.lblOtelAd.AutoSize = true;
            this.lblOtelAd.BackColor = System.Drawing.Color.Black;
            this.lblOtelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOtelAd.Location = new System.Drawing.Point(107, 80);
            this.lblOtelAd.Name = "lblOtelAd";
            this.lblOtelAd.Size = new System.Drawing.Size(90, 17);
            this.lblOtelAd.TabIndex = 0;
            this.lblOtelAd.Text = "OTEL AD : ";
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(203, 80);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(176, 20);
            this.txtOtelAd.TabIndex = 1;
            this.txtOtelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtelAd_KeyPress);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(418, 76);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(72, 26);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblEtiket
            // 
            this.lblEtiket.BackColor = System.Drawing.Color.White;
            this.lblEtiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEtiket.Location = new System.Drawing.Point(107, 210);
            this.lblEtiket.Name = "lblEtiket";
            this.lblEtiket.Size = new System.Drawing.Size(774, 255);
            this.lblEtiket.TabIndex = 3;
            // 
            // lblResim
            // 
            this.lblResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResim.Location = new System.Drawing.Point(119, 222);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(207, 169);
            this.lblResim.TabIndex = 4;
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.Black;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(359, 222);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(361, 45);
            this.lblAd.TabIndex = 5;
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imglstYildiz
            // 
            this.imglstYildiz.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstYildiz.ImageStream")));
            this.imglstYildiz.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstYildiz.Images.SetKeyName(0, "1 yıldız.jpg");
            this.imglstYildiz.Images.SetKeyName(1, "2 yıldız.jpg");
            this.imglstYildiz.Images.SetKeyName(2, "3 yıldız.jpg");
            this.imglstYildiz.Images.SetKeyName(3, "4 yıldız.jpg");
            this.imglstYildiz.Images.SetKeyName(4, "5 yıldız.png");
            // 
            // lblYildiz
            // 
            this.lblYildiz.Location = new System.Drawing.Point(360, 286);
            this.lblYildiz.Name = "lblYildiz";
            this.lblYildiz.Size = new System.Drawing.Size(130, 33);
            this.lblYildiz.TabIndex = 6;
            // 
            // lblOtel
            // 
            this.lblOtel.AutoSize = true;
            this.lblOtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtel.Location = new System.Drawing.Point(496, 286);
            this.lblOtel.Name = "lblOtel";
            this.lblOtel.Size = new System.Drawing.Size(49, 17);
            this.lblOtel.TabIndex = 7;
            this.lblOtel.Text = "OTEL";
            // 
            // lblAdres
            // 
            this.lblAdres.Location = new System.Drawing.Point(363, 339);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(453, 111);
            this.lblAdres.TabIndex = 8;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(829, 511);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmOtelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 566);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblOtel);
            this.Controls.Add(this.lblYildiz);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lblEtiket);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtOtelAd);
            this.Controls.Add(this.lblOtelAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOtelSil";
            this.Text = "frmOtelSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelAd;
        private System.Windows.Forms.TextBox txtOtelAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblEtiket;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ImageList imglstYildiz;
        private System.Windows.Forms.Label lblYildiz;
        private System.Windows.Forms.Label lblOtel;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Button btnSil;
    }
}