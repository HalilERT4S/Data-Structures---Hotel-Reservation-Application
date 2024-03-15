
namespace prjVeriYapilariOdevi
{
    partial class frmPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.lblOtelAd = new System.Windows.Forms.Label();
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblOtelAd
            // 
            this.lblOtelAd.AutoSize = true;
            this.lblOtelAd.BackColor = System.Drawing.Color.Black;
            this.lblOtelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOtelAd.Location = new System.Drawing.Point(448, 99);
            this.lblOtelAd.Name = "lblOtelAd";
            this.lblOtelAd.Size = new System.Drawing.Size(85, 17);
            this.lblOtelAd.TabIndex = 0;
            this.lblOtelAd.Text = "OTEL AD :";
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(540, 99);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(138, 20);
            this.txtOtelAd.TabIndex = 1;
            this.txtOtelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtelAd_KeyPress);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListele.Location = new System.Drawing.Point(748, 90);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(93, 34);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1350, 409);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1461, 634);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtOtelAd);
            this.Controls.Add(this.lblOtelAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonelListele";
            this.Text = "frmPersonelListele";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelAd;
        private System.Windows.Forms.TextBox txtOtelAd;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListView listView1;
    }
}