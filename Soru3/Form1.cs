using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru3SifreUygulaması
{
    public partial class Form1 : Form
    {
        string sifre = "1234ABC";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int sayac = 0;
            string sifreGirdisi = txtSifre.Text;
            if (e.KeyCode == Keys.Enter)
            {
                while (sayac != 1)
                {
                    if (sifreGirdisi == sifre)
                    {
                        MessageBox.Show("Tebrikler Şifreniz Doğru ! ");
                        sayac++;
                        Close();
                    }
                    else MessageBox.Show("Şifreniz Yanlış Tekrar Deneyiniz ! "); break;
                }
            }
            
        }
    }
}
