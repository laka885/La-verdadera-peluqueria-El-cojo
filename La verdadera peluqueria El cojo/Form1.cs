using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    // IMPORTANTE: Debe decir 'partial' y ': Form'
    public partial class Form1 : Form
    {
        List<IFacturable> carrito = new List<IFacturable>();

        public Form1()
        {
            InitializeComponent();
        }

        // Asegúrate de que en el DISEÑO, el botón de agregar
        // tenga este nombre en el evento Click
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var servicio = new Degradado
            {
                Nombre = cmbTipoServicio.Text,
                PrecioBase = nudPrecio.Value,
                Nivel = 1
            };

            var errores = Validador.Validar(servicio);

            if (errores.Count == 0)
            {
                carrito.Add(servicio);
                lstCarrito.Items.Add(servicio.Nombre + " - RD$" + servicio.CalcularPrecio());
            }
            else
            {
                MessageBox.Show(string.Join("\n", errores), "Error de Validación");
            }
        }

        // Asegúrate de que en el DISEÑO, el botón de facturar
        // tenga este nombre en el evento Click
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0) return;

            rtbTicket.Text = GeneradorReportes.GenerarTicket(carrito, txtCliente.Text, cmbBarbero.Text);

            carrito.Clear();
            lstCarrito.Items.Clear();
        }
    }
}