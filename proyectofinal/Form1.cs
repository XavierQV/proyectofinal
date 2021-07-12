using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class Form1 : Form
    {
        string number = string.Empty;
        double operador1;
        double operador2;
        string operacion;

        sumar operaciones = new sumar();
        restar restar = new restar();
        multiplicar multiplicar = new multiplicar();
        dividir dividir = new dividir();
        porciento porciento = new porciento();
        unodividido unodividido = new unodividido();



        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            lbrespuesta1.Text = "+";
            
            if(!string.IsNullOrEmpty(txtresultado.Text))
            operador1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();

        }
        private void btnmenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            lbrespuesta1.Text = "-";
            if (!string.IsNullOrEmpty(txtresultado.Text))
                operador1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }
        private void btnmulti_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = "*";
            operacion = "*";
            if (!string.IsNullOrEmpty(txtresultado.Text))
                operador1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }
        private void btndividido_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = "/";
            operacion = "/";
            if (!string.IsNullOrEmpty(txtresultado.Text))
                operador1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }
        private void btnporciento_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = "%";
            operacion = "%";
            if (!string.IsNullOrEmpty(txtresultado.Text))
                operador1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }
        private void btn1diviparax_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = "1div";
            operacion = "1div";
            if (!string.IsNullOrEmpty(txtresultado.Text))
                operador2 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            operador2 = double.Parse(txtresultado.Text);
            
            double operacionsuma, operacionresta, operacionmulti, operaciondivi, operacionporciento,opdiv1;
            switch (operacion)
            {

                case "+":
                    operacionsuma = operaciones.sumas((operador1), (operador2));
                    txtresultado.Text = operacionsuma.ToString();
                    lbrespuesta1.Text = operacionsuma.ToString();
                    break;
                case "-":
                    operacionresta = restar.resta((operador1), (operador2));
                    txtresultado.Text = operacionresta.ToString();
                    lbrespuesta1.Text = operacionresta.ToString();
                    break;
                case "*":
                    operacionmulti = multiplicar.multiplicacion((operador1), (operador2));
                    txtresultado.Text = operacionmulti.ToString();
                    lbrespuesta1.Text = operacionmulti.ToString();
                    break;
                case "/":
                    operaciondivi = dividir.dividicion((operador1), (operador2));
                    txtresultado.Text = operaciondivi.ToString();
                    lbrespuesta1.Text = operaciondivi.ToString();
                    break;
                case "%":
                    operacionporciento = porciento.porcentaje((operador1), (operador2));
                    txtresultado.Text = operacionporciento.ToString();
                    break;
                case "1div":
                    opdiv1 = unodividido.unodivididos(operador2);
                    txtresultado.Text = opdiv1.ToString();
                    lbrespuesta1.Text = opdiv1.ToString();

                    break;



            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "0";
            txtresultado.Text = txtresultado.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "1";
            txtresultado.Text = txtresultado.Text + "1";
            

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "2";
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "3";
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "4";
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "5";
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "6";
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "7";
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "8";
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbrespuesta1.Text = lbrespuesta1.Text + "9";
            txtresultado.Text = txtresultado.Text + "9";
            
            
        }

        private void btnmasmenos_Click(object sender, EventArgs e)
        {
            double masmenos = double.Parse(txtresultado.Text);
            masmenos = ((masmenos) * (-1));
            txtresultado.Text = masmenos.ToString();
            lbrespuesta1.Text = masmenos.ToString();

        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + ",";
            lbrespuesta1.Text = lbrespuesta1.Text + ",";

        }

        private void btnxcuadrado_Click(object sender, EventArgs e)
        {
            double cuadrado = double.Parse(txtresultado.Text);
            cuadrado = Math.Pow(cuadrado, 2);
            txtresultado.Text = cuadrado.ToString();
        }

        private void btn2raisdex_Click(object sender, EventArgs e)
        {
            double raiz = double.Parse(txtresultado.Text);
            raiz = Math.Sqrt(raiz);
            txtresultado.Text = raiz.ToString();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            lbrespuesta1.Text = string.Empty;
        }
        private void btnborraruno_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length > 0)
            {
                txtresultado.Text = txtresultado.Text.Remove(txtresultado.Text.Length - 1);
                if (lbrespuesta1.Text.Length > 0)

                    lbrespuesta1.Text = lbrespuesta1.Text.Remove(lbrespuesta1.Text.Length - 1);
            }

        }

        private void btnborrarnum_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        private void txtresultado_TextChanged_1(object sender, EventArgs e)
        {
        }


    }
}