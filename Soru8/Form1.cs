using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru8
{
    public partial class Form1 : Form
    {

        //Tamamlandı.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstSonuclar.Items.Clear();

                bool sayilarKaresiCarpilacakMi = false;
                bool sayilarCaprilicakMi = false;
                

                int sayiBir = Convert.ToInt32(txtSayiBir.Text);
                int sayiIki = Convert.ToInt32(txtSayiIki.Text);
                int sayiUc = Convert.ToInt32(txtSayiUc.Text);

                int[] sayilar = { sayiBir, sayiIki, sayiUc };

                double sayilarinKaresiCarpimi = 0;
                int sayilarinCarpimi = 0;
                int sayilarinToplami = 0;
                

                foreach (var item in sayilar)
                {
                    if (item % 3 == 0)
                    {
                        sayilarKaresiCarpilacakMi = true;
                        sayilarinKaresiCarpimi++;
                        break;
                    }
                    if (item % 2 == 0)
                    {
                        sayilarCaprilicakMi = true;
                        sayilarinCarpimi++;
                        break;
                    }                   
                }

                for (int i = 0; i < sayilar.Length; i++)
                {                                      
                    if (sayilarKaresiCarpilacakMi == true) sayilarinKaresiCarpimi *= Math.Pow(sayilar[i], 2);
                    else if (sayilarCaprilicakMi == true) sayilarinCarpimi *= sayilar[i];
                    else sayilarinToplami += sayilar[i];
                }               

                if (sayilarKaresiCarpilacakMi == true) lstSonuclar.Items.Add($"Sayiların Karelerinin Çarpımı : {sayilarinKaresiCarpimi}");
                else if (sayilarCaprilicakMi == true) lstSonuclar.Items.Add($"Sayiların Çarpımı : {sayilarinCarpimi}");
                else lstSonuclar.Items.Add($"Sayiların Toplamı : {sayilarinToplami}");

                
            }
        }
    }
}
