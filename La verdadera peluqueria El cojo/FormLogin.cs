using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                // 1. Conectamos usando tu clase Conexion
                using (SqlConnection cn = Conexion.Conectar())
                {
                    cn.Open();

                    // 2. Buscamos al usuario en la tabla de SQL
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @user AND Clave = @pass";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    // 3. Pasamos lo que escribiste en los TextBox
                    cmd.Parameters.AddWithValue("@user", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    int existe = Convert.ToInt32(cmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        // ¡ÉXITO!
                        MessageBox.Show("Acceso concedido. ¡Bienvenido!");

                        // 4. CREAMOS EL MENU Y LO MOSTRAMOS
                        FormMenu principal = new FormMenu();
                        principal.Show();

                        // 5. OCULTAMOS EL LOGIN
                        this.Hide();
                    }
                    else
                    {
                        // FALLO
                        MessageBox.Show("Usuario o contraseña incorrectos. Verifica en SQL.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Por si el "punto" de la conexión falla
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }


    }
}
