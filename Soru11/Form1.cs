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
            int tavsanSayisi = 0; int birinciAyTavsanSayisi = 2; int ikinciAyTavsanSayisi = 3;

            List<int> tavsanSayisiList = new List<int>();

            tavsanSayisiList.Add(0);
            tavsanSayisiList.Add(birinciAyTavsanSayisi);
            tavsanSayisiList.Add(ikinciAyTavsanSayisi);

            if (e.KeyCode == Keys.Enter)
            {
                //2,3,5,8,13,21,34,55
                for (int i = 2; i <= ay; i++)
                {
                    tavsanSayisi = birinciAyTavsanSayisi + ikinciAyTavsanSayisi;
                    if (tavsanSayisi == birinciAyTavsanSayisi + ikinciAyTavsanSayisi)
                    {
                        tavsanSayisiList.Add(tavsanSayisi);                        
                    }
                    birinciAyTavsanSayisi = ikinciAyTavsanSayisi;
                    ikinciAyTavsanSayisi = tavsanSayisi;
                }

                for (int i = 1; i <= ay+1; i++)
                {
                    if (i == ay)
                    {
                        MessageBox.Show($"{ay}. ayda {tavsanSayisiList[i].ToString()} kadar tavşan vardır.");
                    }
                }
            }

            
        }
    }
}

