using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru6PalindromCumleOldugunuAnlamaProgrami
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
            string cumle = txtCumle.Text;
            string tersCumle = "";

            var cumleCharArray = cumle.ToCharArray();

            for (int i = cumleCharArray.Length -1 ; i > -1; i--)
            {
                tersCumle += cumleCharArray[i];
            }

            if (e.KeyCode == Keys.Enter)
            {               
                if (cumle == tersCumle) MessageBox.Show("Palindrom Cümledir.");
                else MessageBox.Show("Palindrom Cümle Değildir.");
            }
            
        }
    }
}
