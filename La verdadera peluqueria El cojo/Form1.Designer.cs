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
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(51, 43);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 0;
            // 
            // cmbBarbero
            // 
            cmbBarbero.FormattingEnabled = true;
            cmbBarbero.Location = new Point(37, 104);
            cmbBarbero.Name = "cmbBarbero";
            cmbBarbero.Size = new Size(151, 28);
            cmbBarbero.TabIndex = 1;
            // 
            // cmbTipoServicio
            // 
            cmbTipoServicio.FormattingEnabled = true;
            cmbTipoServicio.Location = new Point(37, 147);
            cmbTipoServicio.Name = "cmbTipoServicio";
            cmbTipoServicio.Size = new Size(151, 28);
            cmbTipoServicio.TabIndex = 2;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(37, 213);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(122, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstCarrito
            // 
            lstCarrito.FormattingEnabled = true;
            lstCarrito.Location = new Point(284, 109);
            lstCarrito.Name = "lstCarrito";
            lstCarrito.Size = new Size(150, 104);
            lstCarrito.TabIndex = 5;
            // 
            // rtbTicket
            // 
            rtbTicket.Location = new Point(530, 43);
            rtbTicket.Name = "rtbTicket";
            rtbTicket.Size = new Size(125, 120);
            rtbTicket.TabIndex = 6;
            rtbTicket.Text = "";
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(375, 232);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(94, 29);
            btnFacturar.TabIndex = 7;
            btnFacturar.Text = "button1";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFacturar);
            Controls.Add(rtbTicket);
            Controls.Add(lstCarrito);
            Controls.Add(btnAgregar);
            Controls.Add(nudPrecio);
            Controls.Add(cmbTipoServicio);
            Controls.Add(cmbBarbero);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
