using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos; 
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {

        List<IFacturable> carrito = new List<IFacturable>();


        List<string> historialVentas = new List<string>();

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

            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue un servicio primero.", "Atención");
                return;
            }


            string ticketFinal = GeneradorReportes.GenerarTicket(carrito, txtCliente.Text, cmbBarbero.Text);


            rtbTicket.Text = ticketFinal;



            historialVentas.Add($"Cliente: {txtCliente.Text} - Total: {rtbTicket.Text.Split('$')[1].Trim()}");
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
                MessageBox.Show("No hay ventas registradas todavía.", "Historial Vacío");
                return;
            }


            rtbTicket.Clear();
            rtbTicket.Text = "======= HISTORIAL DE VENTAS =======\n\n";

            foreach (string ticket in historialVentas)
            {
                rtbTicket.Text += ticket + "\n" + new string('-', 30) + "\n";
            }
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
    }


}