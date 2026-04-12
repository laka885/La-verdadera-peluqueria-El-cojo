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
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
            // Esto "amarra" el evento Load por código por si el diseño falló
            this.Load += new EventHandler(FormHistorial_Load);
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        public void CargarVentas()
        {
            try
            {
                using (SqlConnection cn = Conexion.Conectar())
                {
                    cn.Open();
                    // Query para traer los datos
                    string query = "SELECT Id, Cliente, Servicio, Precio, Fecha FROM Ventas ORDER BY Id DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // MENSAJE DE PRUEBA: Te dirá cuántas filas encontró en SQL
                    MessageBox.Show("Se encontraron " + dt.Rows.Count + " ventas en la base de datos.");

                    // Asignamos los datos al control
                    dgvVentas.DataSource = dt;

                    // Formateo de columnas (solo si hay datos)
                    if (dgvVentas.Columns.Count > 0)
                    {
                        dgvVentas.Columns["Precio"].DefaultCellStyle.Format = "N2";
                        dgvVentas.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvVentas.Columns["Id"].HeaderText = "No.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message);
            }
        }

        // Código para el botón de Atrás
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        // Evita procesos zombies en el Administrador de Tareas
        private void FormHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si el usuario cierra con la X y no hay más formularios, cerramos todo
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}