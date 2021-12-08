using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenSayiyiHarflerleYazdırmaProgramı
{
    public partial class Form1 : Form
    {

        //Tamamlandı.

        string[] sayilarinHarfKarsiligiBirlikSayilar =
        {
            "Sıfır","Bir","İki","Üç","Dört",
            "Beş","Altı","Yedi","Sekiz","Dokuz","On"
        };
        string[] sayilarinHarfKarsiligiOndalikSayilar =
        {
            "On","Yirmi","Otuz","Kırk","Elli",
            "Altmış","Yedmiş","Seksen","Doksan"
        };

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int girdi = Convert.ToInt32(nudSayiGirdisi.Value);
            string girdiStr = Convert.ToString(nudSayiGirdisi.Value);

            int eldeOndalikSayi = 0;
            int eldeBirlikSayi = 0;         


            if (e.KeyCode == Keys.Enter)
            {

                if (girdi <= 10)
                {
                    for (int i = 0; i < sayilarinHarfKarsiligiBirlikSayilar.Length; i++)
                    {
                        if (girdi == i)
                        {
                            lblSayiCiktisi.Text = sayilarinHarfKarsiligiBirlikSayilar[i];
                            break;
                        }
                    }
                }
                else
                {

                    for (int i = 0; i < sayilarinHarfKarsiligiOndalikSayilar.Length; i++)
                    {
                        if (Convert.ToInt32(girdiStr[0] - 49) == i)
                        {

                            eldeOndalikSayi = i;

                        }
                    }
                    for (int i = 0; i < sayilarinHarfKarsiligiBirlikSayilar.Length; i++)
                    {
                        if (Convert.ToInt32(girdiStr[1] - 49) == i)
                        {
                            eldeBirlikSayi = i + 1;
                        }
                    }

                    if (eldeBirlikSayi == 0) lblSayiCiktisi.Text = $"{sayilarinHarfKarsiligiOndalikSayilar[eldeOndalikSayi]}";
                    else lblSayiCiktisi.Text = $"{sayilarinHarfKarsiligiOndalikSayilar[eldeOndalikSayi] + sayilarinHarfKarsiligiBirlikSayilar[eldeBirlikSayi]}";
                  
                }
            }
        }

    }
}