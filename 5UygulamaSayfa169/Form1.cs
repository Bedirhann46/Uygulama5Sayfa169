using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5UygulamaSayfa169
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbltatli_Click(object sender, EventArgs e)
        {

        }

        private void lblAnayemek_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "\r\n";
                txtBilgi.Text += txtAdsoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                double hesap = 0;

                if (numCorba.Value > 0)
                {
                    double corbaBirimFiyat = 55;
                    double corbaToplamFiyat = Convert.ToDouble(numCorba.Value) * corbaBirimFiyat;
                    hesap += corbaToplamFiyat;
                    txtBilgi.Text += "Çorbanın Toplam Fiyatı=" + corbaToplamFiyat.ToString() + "\r\n";
                }
                if (numSalata.Value > 0)
                {
                    double SalataBirimfiyat = 40;
                    double SalataToplamFiyat = Convert.ToDouble(numSalata.Value) * SalataBirimfiyat;
                    hesap += SalataToplamFiyat;
                    txtBilgi.Text += "Salatanın Toplam Fiyatı=" + SalataToplamFiyat.ToString() + "\r\n";
                }
                if (numYemek.Value > 0)
                {
                    double YemekBirimFiyat = 90;
                    double YemekToplamFiyat = Convert.ToDouble(numYemek.Value) * YemekBirimFiyat;
                    hesap += YemekToplamFiyat;
                    txtBilgi.Text += "AnaYemeğin Toplam Fiyatı=" + YemekToplamFiyat.ToString() + "\r\n";
                }
                if (numTatli.Value > 0)
                {
                    double TatliBirimFiyat = 75;
                    double TatliToplamFiyat = Convert.ToDouble(numTatli.Value) * TatliBirimFiyat;
                    hesap += TatliToplamFiyat;
                    txtBilgi.Text += "Tatlının Toplam Fiyatı=" + TatliToplamFiyat.ToString() + "\r\n";
                }
                txtBilgi.Text += "Toplam Hesabın Fiyatı=" + hesap.ToString() + "\r\n";
            }
        }
    }
}

