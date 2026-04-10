using System;
using System.Windows.Forms;

namespace PeluqueriaElCojo
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

            // Aquí iniciamos tu formulario principal
            Application.Run(new Form1());
        }
    }
}