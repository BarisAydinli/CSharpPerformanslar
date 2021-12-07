using System.Collections.Generic;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string girdi = txtSayiGirdisi.Text.Trim();
                string virgul = ",";

                int sayi1=0, sayi2=0, sayi3=0, sayi4=0;

                int sayi1IleSayi2Ort = 0, sayi2IleSayi3Ort = 0, sayi3IleSayi4Ort = 0;
                
                int virgulUzunluk = 1;
                int sayac = 0;
                int baslangic = 0;

                List<int> virgulYerleri = new List<int>();

                while (sayac != -1)
                {
                    virgulYerleri.Add(sayac);
                    baslangic = virgulUzunluk + sayac;
                    sayac = girdi.IndexOf(virgul, baslangic);
                }

                virgulYerleri.RemoveAt(0);

                sayi1 = int.Parse(girdi.Substring(0, virgulYerleri[0]));
                sayi2 = int.Parse(girdi.Substring((virgulYerleri[0] + 1), (virgulYerleri[1] - virgulYerleri[0] - 1)));
                sayi3 = int.Parse(girdi.Substring((virgulYerleri[1] + 1), (virgulYerleri[2] - virgulYerleri[1] - 1)));
                sayi4 = int.Parse(girdi.Substring((virgulYerleri[2] + 1)));

                sayi1IleSayi2Ort = (sayi1 + sayi2) / 2;
                sayi2IleSayi3Ort = (sayi2 + sayi3) / 2;
                sayi3IleSayi4Ort = (sayi3 + sayi4) / 2;

                lstOrtalamalar.Items.Add($"{sayi1} ile {sayi2} sayılarının ortalaması: {sayi1IleSayi2Ort}");
                lstOrtalamalar.Items.Add($"{sayi2} ile {sayi3} sayılarının ortalaması: {sayi2IleSayi3Ort}");
                lstOrtalamalar.Items.Add($"{sayi3} ile {sayi4} sayılarının ortalaması: {sayi3IleSayi4Ort}");

            }
        }
    }
}
