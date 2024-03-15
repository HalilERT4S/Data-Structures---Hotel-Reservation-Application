
namespace prjVeriYapilariOdevi
{
    partial class frmAdmin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oTELİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTELEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTELGÜNCELLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTELSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELGÜNCELLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELLİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCikis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTELİŞLEMLERİToolStripMenuItem,
            this.pERSONELİŞLEMLERİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oTELİŞLEMLERİToolStripMenuItem
            // 
            this.oTELİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTELEKLEToolStripMenuItem,
            this.oTELGÜNCELLEToolStripMenuItem,
            this.oTELSİLToolStripMenuItem});
            this.oTELİŞLEMLERİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.oTELİŞLEMLERİToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.oTELİŞLEMLERİToolStripMenuItem.Name = "oTELİŞLEMLERİToolStripMenuItem";
            this.oTELİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.oTELİŞLEMLERİToolStripMenuItem.Text = "OTEL İŞLEMLERİ";
            // 
            // oTELEKLEToolStripMenuItem
            // 
            this.oTELEKLEToolStripMenuItem.Name = "oTELEKLEToolStripMenuItem";
            this.oTELEKLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oTELEKLEToolStripMenuItem.Text = "OTEL EKLE";
            this.oTELEKLEToolStripMenuItem.Click += new System.EventHandler(this.oTELEKLEToolStripMenuItem_Click);
            // 
            // oTELGÜNCELLEToolStripMenuItem
            // 
            this.oTELGÜNCELLEToolStripMenuItem.Name = "oTELGÜNCELLEToolStripMenuItem";
            this.oTELGÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oTELGÜNCELLEToolStripMenuItem.Text = "OTEL GÜNCELLE";
            this.oTELGÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.oTELGÜNCELLEToolStripMenuItem_Click);
            // 
            // oTELSİLToolStripMenuItem
            // 
            this.oTELSİLToolStripMenuItem.Name = "oTELSİLToolStripMenuItem";
            this.oTELSİLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oTELSİLToolStripMenuItem.Text = "OTEL SİL";
            this.oTELSİLToolStripMenuItem.Click += new System.EventHandler(this.oTELSİLToolStripMenuItem_Click);
            // 
            // pERSONELİŞLEMLERİToolStripMenuItem
            // 
            this.pERSONELİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONELEKLEToolStripMenuItem,
            this.pERSONELGÜNCELLEToolStripMenuItem,
            this.pERSONELSİLToolStripMenuItem,
            this.pERSONELLİSTELEToolStripMenuItem});
            this.pERSONELİŞLEMLERİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pERSONELİŞLEMLERİToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pERSONELİŞLEMLERİToolStripMenuItem.Name = "pERSONELİŞLEMLERİToolStripMenuItem";
            this.pERSONELİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.pERSONELİŞLEMLERİToolStripMenuItem.Text = "PERSONEL İŞLEMLERİ";
            // 
            // pERSONELEKLEToolStripMenuItem
            // 
            this.pERSONELEKLEToolStripMenuItem.Name = "pERSONELEKLEToolStripMenuItem";
            this.pERSONELEKLEToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pERSONELEKLEToolStripMenuItem.Text = "PERSONEL EKLE";
            this.pERSONELEKLEToolStripMenuItem.Click += new System.EventHandler(this.pERSONELEKLEToolStripMenuItem_Click);
            // 
            // pERSONELGÜNCELLEToolStripMenuItem
            // 
            this.pERSONELGÜNCELLEToolStripMenuItem.Name = "pERSONELGÜNCELLEToolStripMenuItem";
            this.pERSONELGÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pERSONELGÜNCELLEToolStripMenuItem.Text = "PERSONEL GÜNCELLE";
            this.pERSONELGÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.pERSONELGÜNCELLEToolStripMenuItem_Click);
            // 
            // pERSONELSİLToolStripMenuItem
            // 
            this.pERSONELSİLToolStripMenuItem.Name = "pERSONELSİLToolStripMenuItem";
            this.pERSONELSİLToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pERSONELSİLToolStripMenuItem.Text = "PERSONEL SİL";
            this.pERSONELSİLToolStripMenuItem.Click += new System.EventHandler(this.pERSONELSİLToolStripMenuItem_Click);
            // 
            // pERSONELLİSTELEToolStripMenuItem
            // 
            this.pERSONELLİSTELEToolStripMenuItem.Name = "pERSONELLİSTELEToolStripMenuItem";
            this.pERSONELLİSTELEToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pERSONELLİSTELEToolStripMenuItem.Text = "PERSONEL LİSTELE";
            this.pERSONELLİSTELEToolStripMenuItem.Click += new System.EventHandler(this.pERSONELLİSTELEToolStripMenuItem_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(848, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 24);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 657);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oTELİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTELEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTELGÜNCELLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTELSİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELGÜNCELLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELSİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELLİSTELEToolStripMenuItem;
        private System.Windows.Forms.Button btnCikis;
    }
}

