using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru5CumleUzunluguBulmaProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int metinUzunlugu = txtCumle.Text.Length;

            if(e.KeyCode == Keys.Enter)
            {
                if (metinUzunlugu < 20) MessageBox.Show("Girdiğiniz Cümle 20 Haneden Kısadır !");
                else if (metinUzunlugu == 20) MessageBox.Show("Girdiğiniz Cümle 20 Haneye Eşit !");
                else MessageBox.Show("Girdiğiniz Cümle 20 Haneden Uzundur !");
            }                
        }
    }
}
