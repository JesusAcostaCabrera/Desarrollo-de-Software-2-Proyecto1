using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular()
        {

            double Sueldo = double.Parse(txtSueldo.Text);

            txtISR.Text = Math.Round(Sueldo * 0.09,2).ToString();

            txtAFP.Text = Math.Round(Sueldo * 0.07,2).ToString();

            txtSSF.Text = Math.Round(Sueldo * 0.10,2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
