namespace La_verdadera_peluqueria_El_cojo
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            btnFacturacion = new Button();
            btnHistorial = new Button();
            btnCerrarSesion = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(140, 17);
            label1.Name = "label1";
            label1.Size = new Size(178, 29);
            label1.TabIndex = 1;
            label1.Text = "Peluqueria El Cojo";
            label1.Click += label1_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Location = new Point(161, 81);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(136, 45);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "Facturacion";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(161, 155);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(132, 49);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(151, 226);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(157, 51);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnCerrarSesion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnHistorial);
            groupBox1.Controls.Add(btnFacturacion);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 328);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(500, 400);
            MinimumSize = new Size(500, 400);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnFacturacion;
        private Button btnHistorial;
        private Button btnCerrarSesion;
        private GroupBox groupBox1;
    }
}