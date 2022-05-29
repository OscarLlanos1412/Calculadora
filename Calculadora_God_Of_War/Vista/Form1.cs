using Calculadora_God_Of_War.Modelo;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora_God_Of_War
{
    public partial class Form1 : Form
    {
        Operaciones op = new Operaciones();
        private string valor1;
        private string valor2;
        private int opcion;
        public Form1()
        {
            InitializeComponent();
        }

        //Numeros
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
        //-----------------------------------------//

        //Botones de los signos
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
        //--------------------------------------------//

        //Botones adicionales
        private void btnComa_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + ",";
        }
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
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
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
        //-------------------------------------------------------//

        //Boton calculadora cientifica
        private void btnCientifica_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 calculadorCientifica = new Form2();
            calculadorCientifica.Show();
        }
        //---------------------------------------------------------//

        //Boton apagar
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestra calculadora :)", "Salida");
            Application.Exit();
            
        }
        //------------------------------------------------------------//
    }
}
