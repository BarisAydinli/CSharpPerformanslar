using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru9SayiHesaplamaProgrami
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
            int sayac = 1;
                  
            long ciftSayilarinToplami = 0;
            ulong uceBolunenlerinCarpımi = 1;

            double ikiVeUceBolunenlerinKaresi = 0;
            if (e.KeyCode == Keys.Enter)
            {
                lstSonuclar.Items.Clear();
                long girdi = Convert.ToInt64(txtGirdi.Text);
                if (rdbSayiDahil.Checked == true)
                {
                    while (sayac <= girdi)
                    {

                        if (sayac % 2 == 0) ciftSayilarinToplami += sayac;
                        if (sayac % 3 == 0) uceBolunenlerinCarpımi *= ulong.Parse(sayac.ToString());
                        if (sayac % 2 == 0 && sayac % 3 == 0) ikiVeUceBolunenlerinKaresi += Math.Pow(sayac, 2);
                        sayac++;
                    }
                }
                else if (rdbSayiDahilDegil.Checked == true)
                {
                    while (sayac <= girdi - 1)
                    {

                        if (sayac % 2 == 0) ciftSayilarinToplami += sayac;
                        if (sayac % 3 == 0) uceBolunenlerinCarpımi *= ulong.Parse(sayac.ToString());
                        if (sayac % 2 == 0 && sayac % 3 == 0) ikiVeUceBolunenlerinKaresi += Math.Pow(sayac, 2);
                        sayac++;
                    }
                }
                
                lstSonuclar.Items.Add($"Çift Sayıların Toplamı : {ciftSayilarinToplami}");
                lstSonuclar.Items.Add($"Üçe Bölünenelerin Çarpımı : {uceBolunenlerinCarpımi}");
                lstSonuclar.Items.Add($"Hem İkiye Hem Üçe Bölünenlerin Karelerinin Toplamı : {ikiVeUceBolunenlerinKaresi}");

            }
            

        }
    }
}
