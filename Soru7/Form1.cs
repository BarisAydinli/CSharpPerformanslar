using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru7
{
    public partial class Form1 : Form
    {

        Random rdn = new Random();

        double decimal1 = 0;
        double decimal2 = 0;
        double decimalToplam = 0;

        string binaryToplam = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void BinaryToDecimal(string binary1, string binary2)
        {
            int kuvvet = 0;           

            int[] binary1IntList = new int[8];
            int[] binary2IntList = new int[8];
            

            for (int i = 0; i < 8; i++)
            {
                if (binary1[i] == '0' || binary2[i] == '0')
                {
                    binary1IntList[i] += (binary1[i] - 48);
                    binary2IntList[i] += (binary2[i] - 48);
                }
                else 
                {
                    binary1IntList[i] += (binary1[i] - 48);
                    binary2IntList[i] += (binary2[i] - 48);
                } 
            }

            for (int i = 7; i >= 0;)
            {
                if (binary1IntList[i] == 1)
                {
                    if ((binary1IntList[i] * Math.Pow(2, kuvvet)) != 0)
                    {
                        decimal1 += binary1IntList[i] * Math.Pow(2, kuvvet);                       
                    }
                }
                if (binary2IntList[i] == 1)
                {
                    if ((binary2IntList[i] * Math.Pow(2, kuvvet)) != 0)
                    {
                        decimal2 += binary2IntList[i] * Math.Pow(2, kuvvet);
                    }
                }
                kuvvet++;
                i--;
            }        
        }

        private void DecimalToBinary(int decimalToplam)
        {
            List<string> binaryToplamList = new List<string>();

            if (decimalToplam < 256)
            {
                while (decimalToplam >= 1)
                {
                    decimalToplam /= 2;
                    binaryToplamList.Add((decimalToplam % 2).ToString());
                }
                foreach (var i in binaryToplamList)
                {
                    binaryToplam += i;
                }
            }
            else 
            {
                MessageBox.Show("Ram Bit Sayısı Aşıldı");
                lblBinary1.Text = "";
                lblBinary2.Text = "";
                lblBinaryToplam.Text = "";
                lblDecimal1.Text = "";
                lblDecimal2.Text = "";
                lblDecimalToplam.Text = "";               
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                              
               
                decimal1 = 0;
                decimal2 = 0;

                binaryToplam = "";

                lblBinary1.Text = "";
                lblBinary2.Text = "";


                for (int i = 0; i < 8; i++)
                {
                    lblBinary1.Text += rdn.Next(0, 2);
                    lblBinary2.Text += rdn.Next(0, 2);
                }

                BinaryToDecimal(lblBinary1.Text, lblBinary2.Text);
                lblDecimal1.Text = decimal1.ToString();
                lblDecimal2.Text = decimal2.ToString();

                decimalToplam = decimal1 + decimal2;
                if (decimalToplam < 256) lblDecimalToplam.Text = decimalToplam.ToString();

                DecimalToBinary(Convert.ToInt32(decimalToplam));
                lblBinaryToplam.Text = binaryToplam;
            }
        }
    }
}
