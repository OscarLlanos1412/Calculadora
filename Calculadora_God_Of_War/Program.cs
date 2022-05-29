using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_God_Of_War
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Hace que se ejecute el formulario 1 pero al abrir el otro no termina
            //El programa. Sin pasarle parametro al .Run este se ejecuta normal
            //Sin necesidad de pasarle que formulario se ejecutara, se hará global.
            Form1 formu = new Form1();
            formu.Show();
            Application.Run();
        }
    }
}
