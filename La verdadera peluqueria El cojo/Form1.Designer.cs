namespace PeluqueriaElCojo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            cmbBarbero = new ComboBox();
            cmbTipoServicio = new ComboBox();
            nudPrecio = new NumericUpDown();
            btnAgregar = new Button();
            lstCarrito = new ListBox();
            rtbTicket = new RichTextBox();
            btnFacturar = new Button();
            Datos_Venta = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            NuevaVenta = new Button();
            historial = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            Datos_Venta.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(5, 182);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(209, 23);
            txtCliente.TabIndex = 0;
            // 
            // cmbBarbero
            // 
            cmbBarbero.FormattingEnabled = true;
            cmbBarbero.Location = new Point(5, 53);
            cmbBarbero.Margin = new Padding(3, 2, 3, 2);
            cmbBarbero.Name = "cmbBarbero";
            cmbBarbero.Size = new Size(209, 23);
            cmbBarbero.TabIndex = 1;
            // 
            // cmbTipoServicio
            // 
            cmbTipoServicio.FormattingEnabled = true;
            cmbTipoServicio.Location = new Point(5, 118);
            cmbTipoServicio.Margin = new Padding(3, 2, 3, 2);
            cmbTipoServicio.Name = "cmbTipoServicio";
            cmbTipoServicio.Size = new Size(209, 23);
            cmbTipoServicio.TabIndex = 2;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(21, 166);
            nudPrecio.Margin = new Padding(3, 2, 3, 2);
            nudPrecio.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(183, 23);
            nudPrecio.TabIndex = 3;
            nudPrecio.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudPrecio.ValueChanged += nudPrecio_ValueChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.System;
            btnAgregar.ForeColor = Color.Lime;
            btnAgregar.Location = new Point(26, 216);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 44);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Añadir al carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // lstCarrito
            // 
            lstCarrito.FormattingEnabled = true;
            lstCarrito.ItemHeight = 15;
            lstCarrito.Location = new Point(21, 24);
            lstCarrito.Margin = new Padding(3, 2, 3, 2);
            lstCarrito.Name = "lstCarrito";
            lstCarrito.Size = new Size(183, 139);
            lstCarrito.TabIndex = 5;
            // 
            // rtbTicket
            // 
            rtbTicket.Location = new Point(5, 28);
            rtbTicket.Margin = new Padding(3, 2, 3, 2);
            rtbTicket.Name = "rtbTicket";
            rtbTicket.ReadOnly = true;
            rtbTicket.Size = new Size(185, 216);
            rtbTicket.TabIndex = 6;
            rtbTicket.Text = "";
            rtbTicket.TextChanged += rtbTicket_TextChanged;
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(21, 206);
            btnFacturar.Margin = new Padding(3, 2, 3, 2);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(183, 63);
            btnFacturar.TabIndex = 7;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // Datos_Venta
            // 
            Datos_Venta.BackColor = SystemColors.ControlLight;
            Datos_Venta.Controls.Add(textBox3);
            Datos_Venta.Controls.Add(textBox2);
            Datos_Venta.Controls.Add(btnAgregar);
            Datos_Venta.Controls.Add(textBox1);
            Datos_Venta.Controls.Add(cmbBarbero);
            Datos_Venta.Controls.Add(cmbTipoServicio);
            Datos_Venta.Controls.Add(txtCliente);
            Datos_Venta.Location = new Point(10, 32);
            Datos_Venta.Margin = new Padding(3, 2, 3, 2);
            Datos_Venta.Name = "Datos_Venta";
            Datos_Venta.Padding = new Padding(3, 2, 3, 2);
            Datos_Venta.Size = new Size(219, 279);
            Datos_Venta.TabIndex = 8;
            Datos_Venta.TabStop = false;
            Datos_Venta.Text = "Datos de venta";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(42, 154);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "Nombre del Cliente";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(50, 93);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Tipo de servicio";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(72, 28);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Barbero";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(lstCarrito);
            groupBox1.Controls.Add(btnFacturar);
            groupBox1.Controls.Add(nudPrecio);
            groupBox1.Location = new Point(242, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(235, 279);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carrito";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(rtbTicket);
            groupBox2.Location = new Point(494, 32);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(195, 279);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Factura y detalles";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // NuevaVenta
            // 
            NuevaVenta.Location = new Point(10, 6);
            NuevaVenta.Margin = new Padding(3, 2, 3, 2);
            NuevaVenta.Name = "NuevaVenta";
            NuevaVenta.Size = new Size(50, 22);
            NuevaVenta.TabIndex = 11;
            NuevaVenta.Text = "New";
            NuevaVenta.UseVisualStyleBackColor = true;
            NuevaVenta.Click += NuevaVenta_Click;
            // 
            // historial
            // 
            historial.Location = new Point(66, 6);
            historial.Margin = new Padding(3, 2, 3, 2);
            historial.Name = "historial";
            historial.Size = new Size(82, 22);
            historial.TabIndex = 12;
            historial.Text = "Historial";
            historial.UseVisualStyleBackColor = true;
            historial.Click += historial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(historial);
            Controls.Add(NuevaVenta);
            Controls.Add(groupBox2);
            Controls.Add(Datos_Venta);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            Datos_Venta.ResumeLayout(false);
            Datos_Venta.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCliente;
        private ComboBox cmbBarbero;
        private ComboBox cmbTipoServicio;
        private NumericUpDown nudPrecio;
        private Button btnAgregar;
        private ListBox lstCarrito;
        private RichTextBox rtbTicket;
        private Button btnFacturar;
        private GroupBox Datos_Venta;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button NuevaVenta;
        private Button historial;
    }
}
