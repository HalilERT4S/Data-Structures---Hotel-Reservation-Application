
namespace prjVeriYapilariOdevi
{
    partial class frmPersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelSil));
            this.lblOtelAd = new System.Windows.Forms.Label();
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lstwvPersonelSilTablosu = new System.Windows.Forms.ListView();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOtelAd
            // 
            this.lblOtelAd.AutoSize = true;
            this.lblOtelAd.BackColor = System.Drawing.Color.Black;
            this.lblOtelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOtelAd.Location = new System.Drawing.Point(94, 42);
            this.lblOtelAd.Name = "lblOtelAd";
            this.lblOtelAd.Size = new System.Drawing.Size(72, 13);
            this.lblOtelAd.TabIndex = 2;
            this.lblOtelAd.Text = "OTEL AD : ";
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(172, 39);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(138, 20);
            this.txtOtelAd.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(370, 42);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lstwvPersonelSilTablosu
            // 
            this.lstwvPersonelSilTablosu.FullRowSelect = true;
            this.lstwvPersonelSilTablosu.GridLines = true;
            this.lstwvPersonelSilTablosu.HideSelection = false;
            this.lstwvPersonelSilTablosu.Location = new System.Drawing.Point(40, 151);
            this.lstwvPersonelSilTablosu.Name = "lstwvPersonelSilTablosu";
            this.lstwvPersonelSilTablosu.Size = new System.Drawing.Size(748, 269);
            this.lstwvPersonelSilTablosu.TabIndex = 5;
            this.lstwvPersonelSilTablosu.UseCompatibleStateImageBehavior = false;
            this.lstwvPersonelSilTablosu.View = System.Windows.Forms.View.Details;
            this.lstwvPersonelSilTablosu.SelectedIndexChanged += new System.EventHandler(this.lstwvPersonelSilTablosu_SelectedIndexChanged);
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDevamEt.Enabled = false;
            this.btnDevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamEt.Location = new System.Drawing.Point(583, 448);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(153, 31);
            this.btnDevamEt.TabIndex = 6;
            this.btnDevamEt.Text = "İŞLEME DEVAM ET";
            this.btnDevamEt.UseVisualStyleBackColor = false;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // frmPersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 519);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.lstwvPersonelSilTablosu);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtOtelAd);
            this.Controls.Add(this.lblOtelAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelSil";
            this.Text = "frmPersonelSil";
            this.Load += new System.EventHandler(this.frmPersonelSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelAd;
        private System.Windows.Forms.TextBox txtOtelAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListView lstwvPersonelSilTablosu;
        private System.Windows.Forms.Button btnDevamEt;
    }
}