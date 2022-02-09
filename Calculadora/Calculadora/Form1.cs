using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //numero 4
            txtcuadro.Text = txtcuadro.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(txtcuadro.Text);
            txtcuadro.Text = "";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            // numero 0
            txtcuadro.Text = txtcuadro.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            //numero 1
            txtcuadro.Text = txtcuadro.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            //numero 2
            txtcuadro.Text = txtcuadro.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            //numero 3
            txtcuadro.Text = txtcuadro.Text + "3";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            //numero 5
            txtcuadro.Text = txtcuadro.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            //numero 6
            txtcuadro.Text = txtcuadro.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            //numero 7
            txtcuadro.Text = txtcuadro.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            //numero 8
            txtcuadro.Text = txtcuadro.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            //numero 9
            txtcuadro.Text = txtcuadro.Text + "9";
        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            //borrar
            txtcuadro.Text = "";
        }

        private void btnsame_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtcuadro.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                default:
                    resultado = valor1 / valor2;
                    break;
                
            }

            txtcuadro.Text = resultado.ToString();

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            //Suma
            operacion = 1;
            valor1 = Convert.ToDouble(txtcuadro.Text);
            txtcuadro.Text = "";

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //resta
            operacion = 2;
            valor1 = Convert.ToDouble(txtcuadro.Text);
            txtcuadro.Text = "";
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(txtcuadro.Text);
            txtcuadro.Text = "";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            //PUNTO
            txtcuadro.Text = txtcuadro.Text + ".";
        }
    }
}
