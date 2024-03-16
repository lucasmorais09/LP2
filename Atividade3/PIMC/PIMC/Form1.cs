using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMC
{
    public partial class Form1 : Form
    {
        double peso, altura, resultIMC;

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
                txtAltura.Focus();

            }
            else if (altura <= 0)
            {
                MessageBox.Show("Altura inválida");
                txtAltura.Focus();
            }
        }

        private void btnCalculoIMC_Click(object sender, EventArgs e)
        {
            resultIMC = peso / (Math.Pow(altura, 2));
            resultIMC = Math.Round(resultIMC, 1);

            txtResultIMC.Text = resultIMC.ToString();

            if(resultIMC < 18.5)
            {
                MessageBox.Show("IMC: MENOR QUE 18,5\nCLASSIFICAÇÃO: MAGREZA\nOBESIDADE(GRAU): 0");
            }
            else if (resultIMC <= 24.9)
            {
                MessageBox.Show("IMC: ENTRE 18,5 E 24,9\nCLASSIFICAÇÃO: NORMAL\nOBESIDADE(GRAU): 0");
            }
            else if(resultIMC <= 29.9)
            {
                MessageBox.Show("IMC: ENTRE 25 E 29,9\nCLASSIFICAÇÃO: SOBREPESO\nOBESIDADE(GRAU): I");
            }
            else if(resultIMC <= 39.9)
            {
                MessageBox.Show("IMC: ENTRE 30 E 39,9\nCLASSIFICAÇÃO: OBESIDADE\nOBESIDADE(GRAU): II");
            }
            else if(resultIMC >= 40)
            {
                MessageBox.Show("IMC: MAIOR QUE 40,0\nCLASSIFICAÇÃO: OBESIDADE GRAVE\nOBESIDADE(GRAU): III");
            }    
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtPeso.Text, out peso))
                {
                MessageBox.Show("Peso inválida");
                txtPeso.Focus();
            }
            else if (peso <= 0)
            {
                MessageBox.Show("Peso inválida");
                txtPeso.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
