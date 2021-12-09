using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru11TavsanSayisiBulmaProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int ay = Convert.ToInt32(nudAy.Value);

            if (e.KeyCode == Keys.Enter)
            {
                int birOncekiGunTS = 0; int ikiOncekiGunTS = 0; int tavsanSayisi = 0; int sayac = 2;

                //2 | 3 | 5 | 8 | 13 | 21
                if (ay == 1) { MessageBox.Show($"{ay}. ayda {2} kadar tavşan vardır."); }           
                if (ay == 2) {MessageBox.Show($"{ay}. ayda {3} kadar tavşan vardır."); }

                while (ay > sayac)
                {
                    

                    sayac++;
                }
                if (ay == sayac) { MessageBox.Show($"{ay}. ayda {tavsanSayisi} kadar tavşan vardır."); }

            }
        }
    }
}
