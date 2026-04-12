using La_verdadera_peluqueria_El_cojo;
using PeluqueriaElCojo.Modelos; 
using PeluqueriaElCojo.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {

        List<IFacturable> carrito = new List<IFacturable>();


        List<string> historialVentas = new List<string>();

        decimal granTotalDia = 0;

        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {

            cmbBarbero.Items.AddRange(new string[] { "Don Rafael", "Junior", "El Tiguere" });
            cmbTipoServicio.Items.AddRange(new string[] { "Corte Normal", "Degradado", "Afeitado" });


            if (cmbBarbero.Items.Count > 0) cmbBarbero.SelectedIndex = 0;
            if (cmbTipoServicio.Items.Count > 0) cmbTipoServicio.SelectedIndex = 0;


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var nuevoServicio = new Degradado
            {
                Nombre = cmbTipoServicio.Text,
                PrecioBase = nudPrecio.Value,
                Nivel = 1
            };


            var errores = Validador.Validar(nuevoServicio);

            if (errores.Count == 0)
            {

                carrito.Add(nuevoServicio);
                lstCarrito.Items.Add($"{nuevoServicio.Nombre} - RD$ {nuevoServicio.CalcularPrecio():N2}");
            }
            else
            {

                MessageBox.Show(string.Join("\n", errores), "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0) return;

            decimal totalVentaActual = 0;
            foreach (var item in carrito)
            {
                totalVentaActual += item.CalcularPrecio();
            }

            granTotalDia += totalVentaActual;

            // --- AQUÍ EMPIEZA LO DE SQL PARA LA UCE ---
            try
            {
                using (SqlConnection cn = Conexion.Conectar())
                {
                    cn.Open();
                    string query = "INSERT INTO Ventas (Cliente, Servicio, Precio) VALUES (@cliente, @servicio, @precio)";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    // Pasamos los datos de tu lógica actual
                    cmd.Parameters.AddWithValue("@cliente", string.IsNullOrEmpty(txtCliente.Text) ? "Consumidor Final" : txtCliente.Text);

                    // Como el carrito puede tener varios items, aquí guardamos el resumen o el primero
                    // Si quieres guardar CADA item, tendrías que meter el SqlCommand dentro del foreach
                    cmd.Parameters.AddWithValue("@servicio", "Servicio de Peluquería");
                    cmd.Parameters.AddWithValue("@precio", totalVentaActual);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en SQL: " + ex.Message);
            }
            // --- AQUÍ TERMINA LO DE SQL ---

            // 3. Generamos el ticket
            string ticket = GeneradorReportes.GenerarTicket(carrito, txtCliente.Text, cmbBarbero.Text);
            rtbTicket.Text = ticket;

            string registro = $"[{DateTime.Now.ToShortTimeString()}] Barbero: {cmbBarbero.Text} | Cliente: {txtCliente.Text} | Precio: RD$ {totalVentaActual:N2}";
            historialVentas.Add(registro);

            // Limpieza (Esto se queda igual)
            carrito.Clear();
            lstCarrito.Items.Clear();
            txtCliente.Clear();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            decimal precioSeleccionado = nudPrecio.Value;

            var nuevoServicio = new Degradado
            {
                Nombre = cmbTipoServicio.Text,
                PrecioBase = precioSeleccionado,
                Nivel = 1
            };

            // Validación y agregado...
            var errores = Validador.Validar(nuevoServicio);
            if (errores.Count == 0)
            {
                carrito.Add(nuevoServicio);
                lstCarrito.Items.Add($"{nuevoServicio.Nombre} - RD$ {precioSeleccionado:N2}");
            }


        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NuevaVenta_Click(object sender, EventArgs e)
        {

            carrito.Clear();

            lstCarrito.Items.Clear();
            rtbTicket.Clear();
            txtCliente.Clear();


            nudPrecio.Value = 300;
            if (cmbBarbero.Items.Count > 0) cmbBarbero.SelectedIndex = 0;
            if (cmbTipoServicio.Items.Count > 0) cmbTipoServicio.SelectedIndex = 0;


            MessageBox.Show("Sistema reiniciado. ¡Listo para la próxima venta!", "Peluquería El Cojo");

            txtCliente.Focus();
        }

        private void historial_Click(object sender, EventArgs e)
        {
            if (historialVentas.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas.");
                return;
            }

            rtbTicket.Clear();
            rtbTicket.Text = "        REPORTE DE VENTAS TOTALES\n";
            rtbTicket.Text += "========================================\n\n";

            foreach (string venta in historialVentas)
            {
                rtbTicket.Text += venta + "\n";
            }

            rtbTicket.Text += "\n========================================\n";
            // AQUÍ SE MUESTRA LA SUMA TOTAL
            rtbTicket.Text += $"   GRAN TOTAL DEL DÍA: RD$ {granTotalDia:N2}\n";
            rtbTicket.Text += "========================================";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rtbTicket_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            {
                DialogResult resp = MessageBox.Show("¿Seguro que desea volver al menú? Se perderán los datos no guardados.",
                                                   "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Close();
                }
            }
        }
    }


}