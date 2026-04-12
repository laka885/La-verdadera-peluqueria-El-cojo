using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_verdadera_peluqueria_El_cojo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Una validación sencilla para que pruebes el flujo
            if (txtUsuario.Text == "julian" && txtPassword.Text == "1234")
            {
                MessageBox.Show("¡Acceso concedido!");

                // Aquí es donde llamarás al siguiente formulario cuando lo crees
                // Por ahora déjalo así para que no te dé error
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos. (Usa julian y 1234)");
            }
        }
    }
    
}
