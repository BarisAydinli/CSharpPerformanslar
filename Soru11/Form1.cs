﻿using System;
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
            decimal ay = nudAy.Value;
            int tavsanSayisi = 1;
            int öncekiA = 0;
            int sayac = 0;
            if (e.KeyCode == Keys.Enter)
            {
                while (ay > sayac)
                {
                    for (int i = 0; i < sayac; i++)
                    {

                    }
                    sayac++;
                }
                MessageBox.Show(tavsanSayisi.ToString());
            }
        }
    }
}
