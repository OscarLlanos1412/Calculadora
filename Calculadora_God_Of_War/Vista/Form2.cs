using Calculadora_God_Of_War.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_God_Of_War
{
    public partial class Form2 : Form
    {
        Operaciones op = new Operaciones();
        private string valor1;
        private string valor2;
        private double resultado;
        private int opcion;
        private double conversion;
        private double pi = 3.14159;
        public Form2()
        {
            InitializeComponent();
        }
        //Botones numeros
        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + op.numero0;
        }
        //------------------------------------------//

        //Botones operaciones basicas
        private void btnMas_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            txtNumeros.Text = "";
            opcion = 1;
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            txtNumeros.Text = "";
            opcion = 2;
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            txtNumeros.Text = "";
            opcion = 3;
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            txtNumeros.Text = "";
            opcion = 4;
        }
        //------------------------------------------//

        //Botones Seno, Coseno, Tangente, etc
        private void btnSeno_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = txtNumeros.Text;
                conversion = Convert.ToDouble(valor1) * (pi / 180);
                opcion = 5;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
            
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = txtNumeros.Text;
                conversion = Convert.ToDouble(valor1) * (pi / 180);
                opcion = 6;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = txtNumeros.Text;
                conversion = Convert.ToDouble(valor1) * (pi / 180);
                opcion = 7;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 8;
        }
        private void btnLn_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 9;
        }
        private void btnRaiz2_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 10;
        }
        private void btnRaiz3_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 11;
        }
        private void btnX1_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            txtNumeros.Text = "";
            opcion = 12;
        }
        private void btnX2_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 13;
        }
        private void btnX3_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 14;
        }
        private void btnExpo_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            opcion = 15;
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            valor1 = txtNumeros.Text;
            txtNumeros.Text = "";
            opcion = 16;
        }
        //------------------------------------------//

        //Metodos para cada signo
        
        private void seno()
        {
            resultado = Math.Sin(conversion);
            txtNumeros.Text = resultado.ToString();
        }
        private void coseno()
        {
            resultado = Math.Cos(conversion);
            txtNumeros.Text = resultado.ToString();
        }
        private void tangente()
        {
            resultado = Math.Tan(conversion);
            txtNumeros.Text = resultado.ToString();
        }
        private void logaritmo10()
        {
            try
            {
                resultado = Math.Log10(Convert.ToDouble(valor1));
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void logaritmo()
        {
            try
            {
                resultado = Math.Log(Convert.ToDouble(valor1));
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void raiz()
        {
            try
            {
                resultado = Math.Sqrt(Convert.ToDouble(valor1));
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void raizCubica()
        {
            try
            {
                resultado = Math.Pow(Convert.ToDouble(valor1), 1 / 3d);
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void elevar()
        {
            try
            {
                valor2 = txtNumeros.Text;
                resultado = Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2));
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void elevarCuadrado()
        {
            try
            {
                resultado = Math.Pow(Convert.ToDouble(valor1), 2);
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void elevarCubico()
        {
            try
            {
                resultado = Math.Pow(Convert.ToDouble(valor1), 3);
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void exponente()
        {
            try
            {
                resultado = Math.Exp(Convert.ToDouble(valor1));
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        private void porcentaje()
        {
            try
            {
                valor2 = txtNumeros.Text;
                resultado = Convert.ToDouble(valor1) * Convert.ToDouble(valor2) / 100;
                txtNumeros.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
            }
        }
        //------------------------------------------//

        //Boton igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 1:
                    txtNumeros.Text = op.Sumar(valor1, valor2 = txtNumeros.Text);
                    break;
                case 2:
                    txtNumeros.Text = op.Resta(valor1, valor2 = txtNumeros.Text);
                    break;
                case 3:
                    txtNumeros.Text = op.Multiplicar(valor1, valor2 = txtNumeros.Text);
                    break;
                case 4:
                    txtNumeros.Text = op.Division(valor1, valor2 = txtNumeros.Text);
                    break;
                case 5:
                    seno();
                    break;
                case 6:
                    coseno();
                    break;
                case 7:
                    tangente();
                    break;
                case 8:
                    logaritmo10();
                    break;
                case 9:
                    logaritmo();
                    break;
                case 10:
                    raiz();
                    break;
                case 11:
                    raizCubica();
                    break;
                case 12:
                    elevar();
                    break;
                case 13:
                    elevarCuadrado();
                    break;
                case 14:
                    elevarCubico();
                    break;
                case 15:
                    exponente();
                    break;
                case 16:
                    porcentaje();
                    break;
            }
        }
        //------------------------------------------//

        //Demás botones
        private void btnComa_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + ",";
        }
        private void btnBorrarLetra_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                btnBorrarLetra.Enabled = false;
                DialogResult result = MessageBox.Show("No puede eliminar valores vacios", "Error", MessageBoxButtons.OK);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    btnBorrarLetra.Enabled = true;
                }
            }
            else
            {
                btnBorrarLetra.Enabled = true;
                txtNumeros.Text = txtNumeros.Text.Substring(0, txtNumeros.Text.Length - 1);

            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestra calculadora :)", "Salida");
            Application.Exit();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 calculadorNormal = new Form1();
            calculadorNormal.Show();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
        }
        //------------------------------------------//

    }
}
