namespace _5UygulamaSayfa169
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Musteri = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.Siparis = new System.Windows.Forms.TabPage();
            this.numTatli = new System.Windows.Forms.NumericUpDown();
            this.numCorba = new System.Windows.Forms.NumericUpDown();
            this.numSalata = new System.Windows.Forms.NumericUpDown();
            this.numYemek = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbltatli = new System.Windows.Forms.Label();
            this.lblAnayemek = new System.Windows.Forms.Label();
            this.lblSalata = new System.Windows.Forms.Label();
            this.lblCorba = new System.Windows.Forms.Label();
            this.Hesap = new System.Windows.Forms.TabPage();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Musteri.SuspendLayout();
            this.Siparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTatli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Hesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Musteri);
            this.tabControl1.Controls.Add(this.Siparis);
            this.tabControl1.Controls.Add(this.Hesap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 512);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Musteri
            // 
            this.Musteri.Controls.Add(this.txtAdres);
            this.Musteri.Controls.Add(this.lblAdres);
            this.Musteri.Controls.Add(this.lblTelefon);
            this.Musteri.Controls.Add(this.lblAdSoyad);
            this.Musteri.Controls.Add(this.txtTelefon);
            this.Musteri.Controls.Add(this.txtAdsoyad);
            this.Musteri.Location = new System.Drawing.Point(4, 22);
            this.Musteri.Name = "Musteri";
            this.Musteri.Padding = new System.Windows.Forms.Padding(3);
            this.Musteri.Size = new System.Drawing.Size(687, 486);
            this.Musteri.TabIndex = 0;
            this.Musteri.Text = "Müşteri";
            this.Musteri.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(95, 115);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 74);
            this.txtAdres.TabIndex = 6;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(16, 115);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(14, 69);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(8, 30);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Ad Soyad";
            this.lblAdSoyad.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(95, 63);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(95, 23);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdsoyad.TabIndex = 0;
            // 
            // Siparis
            // 
            this.Siparis.Controls.Add(this.numTatli);
            this.Siparis.Controls.Add(this.numCorba);
            this.Siparis.Controls.Add(this.numSalata);
            this.Siparis.Controls.Add(this.numYemek);
            this.Siparis.Controls.Add(this.numericUpDown1);
            this.Siparis.Controls.Add(this.lbltatli);
            this.Siparis.Controls.Add(this.lblAnayemek);
            this.Siparis.Controls.Add(this.lblSalata);
            this.Siparis.Controls.Add(this.lblCorba);
            this.Siparis.Location = new System.Drawing.Point(4, 22);
            this.Siparis.Name = "Siparis";
            this.Siparis.Padding = new System.Windows.Forms.Padding(3);
            this.Siparis.Size = new System.Drawing.Size(687, 486);
            this.Siparis.TabIndex = 1;
            this.Siparis.Text = "Siparis";
            this.Siparis.UseVisualStyleBackColor = true;
            // 
            // numTatli
            // 
            this.numTatli.Location = new System.Drawing.Point(106, 95);
            this.numTatli.Name = "numTatli";
            this.numTatli.Size = new System.Drawing.Size(120, 20);
            this.numTatli.TabIndex = 8;
            // 
            // numCorba
            // 
            this.numCorba.Location = new System.Drawing.Point(106, 7);
            this.numCorba.Name = "numCorba";
            this.numCorba.Size = new System.Drawing.Size(120, 20);
            this.numCorba.TabIndex = 7;
            // 
            // numSalata
            // 
            this.numSalata.Location = new System.Drawing.Point(106, 39);
            this.numSalata.Name = "numSalata";
            this.numSalata.Size = new System.Drawing.Size(120, 20);
            this.numSalata.TabIndex = 6;
            // 
            // numYemek
            // 
            this.numYemek.Location = new System.Drawing.Point(106, 68);
            this.numYemek.Name = "numYemek";
            this.numYemek.Size = new System.Drawing.Size(120, 20);
            this.numYemek.TabIndex = 5;
            this.numYemek.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lbltatli
            // 
            this.lbltatli.AutoSize = true;
            this.lbltatli.Location = new System.Drawing.Point(39, 102);
            this.lbltatli.Name = "lbltatli";
            this.lbltatli.Size = new System.Drawing.Size(27, 13);
            this.lbltatli.TabIndex = 3;
            this.lbltatli.Text = "Tatlı";
            this.lbltatli.Click += new System.EventHandler(this.lbltatli_Click);
            // 
            // lblAnayemek
            // 
            this.lblAnayemek.AutoSize = true;
            this.lblAnayemek.Location = new System.Drawing.Point(30, 75);
            this.lblAnayemek.Name = "lblAnayemek";
            this.lblAnayemek.Size = new System.Drawing.Size(57, 13);
            this.lblAnayemek.TabIndex = 2;
            this.lblAnayemek.Text = "Anayemek";
            this.lblAnayemek.Click += new System.EventHandler(this.lblAnayemek_Click);
            // 
            // lblSalata
            // 
            this.lblSalata.AutoSize = true;
            this.lblSalata.Location = new System.Drawing.Point(39, 41);
            this.lblSalata.Name = "lblSalata";
            this.lblSalata.Size = new System.Drawing.Size(37, 13);
            this.lblSalata.TabIndex = 1;
            this.lblSalata.Text = "Salata";
            // 
            // lblCorba
            // 
            this.lblCorba.AutoSize = true;
            this.lblCorba.Location = new System.Drawing.Point(39, 14);
            this.lblCorba.Name = "lblCorba";
            this.lblCorba.Size = new System.Drawing.Size(35, 13);
            this.lblCorba.TabIndex = 0;
            this.lblCorba.Text = "Corba";
            this.lblCorba.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Hesap
            // 
            this.Hesap.Controls.Add(this.txtBilgi);
            this.Hesap.Location = new System.Drawing.Point(4, 22);
            this.Hesap.Name = "Hesap";
            this.Hesap.Size = new System.Drawing.Size(687, 486);
            this.Hesap.TabIndex = 2;
            this.Hesap.Text = "Hesap";
            this.Hesap.UseVisualStyleBackColor = true;
            // 
            // txtBilgi
            // 
            this.txtBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBilgi.Location = new System.Drawing.Point(0, 0);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(687, 486);
            this.txtBilgi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Musteri.ResumeLayout(false);
            this.Musteri.PerformLayout();
            this.Siparis.ResumeLayout(false);
            this.Siparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTatli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Hesap.ResumeLayout(false);
            this.Hesap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Musteri;
        private System.Windows.Forms.TabPage Siparis;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.TabPage Hesap;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lbltatli;
        private System.Windows.Forms.Label lblAnayemek;
        private System.Windows.Forms.Label lblSalata;
        private System.Windows.Forms.Label lblCorba;
        private System.Windows.Forms.NumericUpDown numCorba;
        private System.Windows.Forms.NumericUpDown numSalata;
        private System.Windows.Forms.NumericUpDown numYemek;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numTatli;
        private System.Windows.Forms.TextBox txtBilgi;
    }
}

