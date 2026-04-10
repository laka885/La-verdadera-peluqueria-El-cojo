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
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            Datos_Venta.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(6, 242);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(238, 27);
            txtCliente.TabIndex = 0;
            // 
            // cmbBarbero
            // 
            cmbBarbero.FormattingEnabled = true;
            cmbBarbero.Location = new Point(6, 71);
            cmbBarbero.Name = "cmbBarbero";
            cmbBarbero.Size = new Size(238, 28);
            cmbBarbero.TabIndex = 1;
            // 
            // cmbTipoServicio
            // 
            cmbTipoServicio.FormattingEnabled = true;
            cmbTipoServicio.Location = new Point(6, 157);
            cmbTipoServicio.Name = "cmbTipoServicio";
            cmbTipoServicio.Size = new Size(238, 28);
            cmbTipoServicio.TabIndex = 2;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(24, 222);
            nudPrecio.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(209, 27);
            nudPrecio.TabIndex = 3;
            nudPrecio.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.System;
            btnAgregar.ForeColor = Color.Lime;
            btnAgregar.Location = new Point(30, 288);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 58);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Añadir al carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // lstCarrito
            // 
            lstCarrito.FormattingEnabled = true;
            lstCarrito.Location = new Point(24, 32);
            lstCarrito.Name = "lstCarrito";
            lstCarrito.Size = new Size(209, 184);
            lstCarrito.TabIndex = 5;
            // 
            // rtbTicket
            // 
            rtbTicket.Location = new Point(6, 38);
            rtbTicket.Name = "rtbTicket";
            rtbTicket.Size = new Size(211, 287);
            rtbTicket.TabIndex = 6;
            rtbTicket.Text = "";
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(24, 275);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(209, 84);
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
            Datos_Venta.Location = new Point(12, 43);
            Datos_Venta.Name = "Datos_Venta";
            Datos_Venta.Size = new Size(250, 372);
            Datos_Venta.TabIndex = 8;
            Datos_Venta.TabStop = false;
            Datos_Venta.Text = "Datos de venta";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(48, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "Nombre del Cliente";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(57, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "Tipo de servicio";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(82, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(63, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Barbero";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(lstCarrito);
            groupBox1.Controls.Add(btnFacturar);
            groupBox1.Controls.Add(nudPrecio);
            groupBox1.Location = new Point(277, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 372);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carrito";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(rtbTicket);
            groupBox2.Location = new Point(565, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 372);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Factura y detalles";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(Datos_Venta);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
