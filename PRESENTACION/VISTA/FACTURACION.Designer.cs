namespace PRESENTACION.VISTA
{
    partial class FACTURACION
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFuncion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtHorario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLES DE LA FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PELICULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FUNCION";
            // 
            // TxtFuncion
            // 
            this.TxtFuncion.Location = new System.Drawing.Point(50, 134);
            this.TxtFuncion.Name = "TxtFuncion";
            this.TxtFuncion.ReadOnly = true;
            this.TxtFuncion.Size = new System.Drawing.Size(108, 20);
            this.TxtFuncion.TabIndex = 3;
            this.TxtFuncion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(50, 83);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.ReadOnly = true;
            this.Txt_Nombre.Size = new System.Drawing.Size(108, 20);
            this.Txt_Nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SALA";
            // 
            // TxtSala
            // 
            this.TxtSala.Location = new System.Drawing.Point(50, 201);
            this.TxtSala.Name = "TxtSala";
            this.TxtSala.ReadOnly = true;
            this.TxtSala.Size = new System.Drawing.Size(108, 20);
            this.TxtSala.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL A PAGAR";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(180, 277);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ReadOnly = true;
            this.TxtPrecio.Size = new System.Drawing.Size(108, 20);
            this.TxtPrecio.TabIndex = 8;
            // 
            // TxtHorario
            // 
            this.TxtHorario.Location = new System.Drawing.Point(50, 247);
            this.TxtHorario.Name = "TxtHorario";
            this.TxtHorario.ReadOnly = true;
            this.TxtHorario.Size = new System.Drawing.Size(108, 20);
            this.TxtHorario.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "HORARIO";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(270, 18);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(62, 32);
            this.Btn_Cerrar.TabIndex = 11;
            this.Btn_Cerrar.Text = "CERRAR";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // FACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 316);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHorario);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.TxtFuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FACTURACION";
            this.Text = "FACTURACION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtFuncion;
        public System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtSala;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtPrecio;
        public System.Windows.Forms.TextBox TxtHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}