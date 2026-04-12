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
            label1.Location = new Point(284, 41);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Peluqueria El Cojo";
            label1.Click += label1_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Location = new Point(74, 145);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(75, 23);
            btnFacturacion.TabIndex = 2;
            btnFacturacion.Text = "button1";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(74, 195);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(75, 23);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "button2";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(74, 249);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(75, 23);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "button3";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnHistorial);
            Controls.Add(btnFacturacion);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnFacturacion;
        private Button btnHistorial;
        private Button btnCerrarSesion;
    }
}