using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru4ButonHareketEttirmeProgrami
{
    public partial class Form1 : Form
    {

        //Tamamlandı.

        public Form1()
        {
            InitializeComponent();
        }

        private void dugmelerBirbirineDegdiMi()
        {
            if (btnIki.Location.Y-40 == btnBir.Location.Y)
            {
                MessageBox.Show("Düğmeler Birbirine Değidi.");
                Close();
            }
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            var point = new Point(btnBir.Location.X, btnBir.Location.Y - 10);
            btnBir.Location = point;

            dugmelerBirbirineDegdiMi();
        }    

        private void btnİki_Click(object sender, EventArgs e)
        {            
            var point = new Point(btnIki.Location.X, btnIki.Location.Y - 10);
            btnIki.Location = point;

            dugmelerBirbirineDegdiMi();
        }
    }
}
