using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora_God_Of_War.Modelo
{
    public class Operaciones
    {
        string valorTwo;
        double resultado;
        public string numero0 = 0.ToString();
        public string numero1 = 1.ToString();
        public string numero2 = 2.ToString();
        public string numero3 = 3.ToString();
        public string numero4 = 4.ToString();
        public string numero5 = 5.ToString();
        public string numero6 = 6.ToString();
        public string numero7 = 7.ToString();
        public string numero8 = 8.ToString();
        public string numero9 = 9.ToString();
        public string Sumar(string valor1, string valor2)
        {
            try
            {
                valorTwo = valor2;
                resultado = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
                return resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
                return "";
            }

        }
        public string Resta(string valor1, string valor2)
        {
            try
            {
                valorTwo = valor2;
                resultado = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
                return resultado.ToString();
            }
            catch (Exception)
            {
               MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
               return "";
            }
        }
        public string Multiplicar(string valor1, string valor2)
        {
            try
            {
                valorTwo = valor2;
                resultado = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
                return resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
                return "";
            }
        }
        public string Division(string valor1, string valor2)
        {
            try
            {
                valorTwo = valor2;
                resultado = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
                return resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor primero ingrese el numero", "Error", MessageBoxButtons.OK);
                return "";
            }
        }
    }
}
