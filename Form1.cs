using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsySalud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //inicializo las variables

            Decimal a = 0;
            Decimal b = 0;
            Decimal calculo = 0;

            a = Convert.ToDecimal(txtAltura.Text);
            b = Convert.ToDecimal(txtPeso.Text);

            calculo = b / (a * a);
            lblResultado.Text = Convert.ToString(calculo);

            if (calculo < 18)
            {
                pictureBox1.Image = PsySalud.Properties.Resources.bien;
                lblResultado.Text = "Estas perfecto";
                lblResultado.ForeColor = Color.Green;
            }
            if (calculo > 18 && calculo < 24)
            {
                pictureBox1.Image = PsySalud.Properties.Resources.normal;
                lblResultado.Text = "Estas en tu peso optimo";
                lblResultado.ForeColor = Color.Blue;
            }
            if (calculo > 25 && calculo < 30)
            {
                pictureBox1.Image = PsySalud.Properties.Resources.mal;
                lblResultado.Text = "Estas en el horno";
                lblResultado.ForeColor = Color.Red;

            }
            if (calculo > 30)
            {
                pictureBox1.Image = PsySalud.Properties.Resources.mal;
                lblResultado.Text = "Algo esta mal";
                lblResultado.ForeColor = Color.Red;
            }






        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
