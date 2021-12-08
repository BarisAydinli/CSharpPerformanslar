using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru10MukemmelSayiBulmaProgrami
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
            int sonuc = 0;
            int sayac = 1;

            if (e.KeyCode == Keys.Enter)
            {
                lstMukemmelSayilar.Items.Clear();

                long girdi = Convert.ToInt64(txtGirdi.Text);

                while (sayac <= girdi)
                {
                    for (int i = 1; i < sayac; i++)
                    {
                        if (sayac % i == 0)
                        {
                            sonuc += i;
                        }
                    }
                    if (sayac == sonuc) lstMukemmelSayilar.Items.Add(sonuc);

                    sonuc = 0;
                    sayac++;
                }       
            }
        }
    }
}
