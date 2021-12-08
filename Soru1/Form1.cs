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
<<<<<<< HEAD
            int girdi = Convert.ToInt32(nudSayiGirdisi.Value);
            string girdiStr = Convert.ToString(nudSayiGirdisi.Value);

            int eldeOndalikSayi = 0;
            int eldeBirlikSayi = 0;
=======

            int girdi = Convert.ToInt32(nudSayiGirdisi.Value);
            string girdiStr = Convert.ToString(nudSayiGirdisi.Value);

            int eldeOndalıkSayi = 0;
            int eldeBirlikSayi = 0;
            

>>>>>>> 0b7fe0f8b62e5a3903b7d0a2bf13fcd6c254869f

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
<<<<<<< HEAD
=======

>>>>>>> 0b7fe0f8b62e5a3903b7d0a2bf13fcd6c254869f
                    for (int i = 0; i < sayilarinHarfKarsiligiOndalikSayilar.Length; i++)
                    {
                        if (Convert.ToInt32(girdiStr[0]-49) == i)
                        {
<<<<<<< HEAD
                            eldeOndalikSayi = i;
=======
                            eldeOndalıkSayi = i;
>>>>>>> 0b7fe0f8b62e5a3903b7d0a2bf13fcd6c254869f
                        }
                    }
                    for (int i = 0; i < sayilarinHarfKarsiligiBirlikSayilar.Length; i++)
                    {
                        if (Convert.ToInt32(girdiStr[1] - 49) == i)
                        {
                            eldeBirlikSayi = i+1;
                        }
                    }
<<<<<<< HEAD
                    if (eldeBirlikSayi == 0) lblSayiCiktisi.Text = $"{sayilarinHarfKarsiligiOndalikSayilar[eldeOndalikSayi]}";
                    else lblSayiCiktisi.Text = $"{sayilarinHarfKarsiligiOndalikSayilar[eldeOndalikSayi]+sayilarinHarfKarsiligiBirlikSayilar[eldeBirlikSayi]}";
=======
                    if (eldeBirlikSayi == 0) lblSayiCiktisi.Text = $"{sayilarinHarfKarsiligiOndalikSayilar[eldeOndalıkSayi]}";
                    else lblSayiCiktisi.Text = $"{sayilarinHarfKarsiligiOndalikSayilar[eldeOndalıkSayi]+sayilarinHarfKarsiligiBirlikSayilar[eldeBirlikSayi]}";

>>>>>>> 0b7fe0f8b62e5a3903b7d0a2bf13fcd6c254869f
                }
            }
        }

    }
}