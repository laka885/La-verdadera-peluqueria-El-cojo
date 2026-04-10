using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos; // Asegúrate de que este sea tu namespace de modelos
using PeluqueriaElCojo.Utilidades;

namespace PeluqueriaElCojo
{
    public partial class Form1 : Form
    {
        // Lista polimórfica que guardará los servicios del carrito
        List<IFacturable> carrito = new List<IFacturable>();

        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            // Llenamos los ComboBox para que no estén vacíos al arrancar
            cmbBarbero.Items.AddRange(new string[] { "Don Rafael", "Junior", "El Tiguere" });
            cmbTipoServicio.Items.AddRange(new string[] { "Corte Normal", "Degradado", "Afeitado" });

            // Seleccionamos el primero por defecto
            if (cmbBarbero.Items.Count > 0) cmbBarbero.SelectedIndex = 0;
            if (cmbTipoServicio.Items.Count > 0) cmbTipoServicio.SelectedIndex = 0;

            // nudPrecio.Value = 300; // Precio inicial sugerido
        }

        // --- CÓDIGO DEL BOTÓN AÑADIR AL CARRITO ---
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Creamos el objeto Servicio (usamos Degradado por el requisito de polimorfismo)
            var nuevoServicio = new Degradado
            {
                Nombre = cmbTipoServicio.Text,
                PrecioBase = nudPrecio.Value,
                Nivel = 1 // Por defecto
            };

            // REQUISITO: Validación dinámica usando REFLECTION (2.0 pts)
            var errores = Validador.Validar(nuevoServicio);

            if (errores.Count == 0)
            {
                // Si es válido, lo agregamos a la lista y al ListBox visual
                carrito.Add(nuevoServicio);
                lstCarrito.Items.Add($"{nuevoServicio.Nombre} - RD$ {nuevoServicio.CalcularPrecio():N2}");
            }
            else
            {
                // Si falla el validador de Reflection, mostramos los errores
                MessageBox.Show(string.Join("\n", errores), "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- CÓDIGO DEL BOTÓN FINALIZAR VENTA (FACTURAR) ---
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            // Verificamos que haya algo que cobrar
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue un servicio primero.", "Atención");
                return;
            }

            // REQUISITO: Uso de GENÉRICOS y STRINGBUILDER (1.5 pts)
            // Llamamos a nuestro generador pasándole la lista del carrito
            string ticketFinal = GeneradorReportes.GenerarTicket(carrito, txtCliente.Text, cmbBarbero.Text);

            // Mostramos el resultado en el RichTextBox de la derecha
            rtbTicket.Text = ticketFinal;

            // Opcional: Limpiar después de facturar para una nueva venta
            // carrito.Clear();
            // lstCarrito.Items.Clear();
        }
    }
}