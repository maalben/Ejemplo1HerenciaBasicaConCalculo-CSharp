using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo1HerenciaBasica
{
    public partial class Form1 : Form
    {

        Suma suma = new Suma(); //Instanciar clase Suma
        Resta resta = new Resta(); //Instanciar clase Resta
        Multiplicacion multiplicacion = new Multiplicacion(); //Instanciar clase Multiplicación
        Division division = new Division();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            numero1 = double.Parse(txtnumero1.Text);
            numero2 = double.Parse(txtnumero2.Text);
            suma.setNumero1(numero1);
            suma.setNumero2(numero2);

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(suma.sumar());

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            resta.setNumero1(double.Parse(txtnumero1.Text));
            resta.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(resta.restar());
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            multiplicacion.setNumero1(double.Parse(txtnumero1.Text));
            multiplicacion.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(multiplicacion.multiplicar());
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            division.setNumero1(double.Parse(txtnumero1.Text));
            division.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(division.dividir());
        }
    }
}
