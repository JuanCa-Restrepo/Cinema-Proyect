namespace TAQUILLERO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CbxSeleccionarFuncion = new System.Windows.Forms.ComboBox();
            this.pcbpelicula = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblN = new System.Windows.Forms.Label();
            this.LblDetalleNombre = new System.Windows.Forms.Label();
            this.LblE = new System.Windows.Forms.Label();
            this.LblDetalleHorario = new System.Windows.Forms.Label();
            this.LblDetalleSala = new System.Windows.Forms.Label();
            this.LblS = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDetallePrecio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGenerarTiquete = new System.Windows.Forms.Button();
            this.BtnCancelarTiquete = new System.Windows.Forms.Button();
            this.Lbl_Disponible = new System.Windows.Forms.Label();
            this.Txt_Disponibles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbpelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // CbxSeleccionarFuncion
            // 
            this.CbxSeleccionarFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxSeleccionarFuncion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CbxSeleccionarFuncion.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.CbxSeleccionarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxSeleccionarFuncion.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeleccionarFuncion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CbxSeleccionarFuncion.FormattingEnabled = true;
            this.CbxSeleccionarFuncion.Location = new System.Drawing.Point(326, 47);
            this.CbxSeleccionarFuncion.Name = "CbxSeleccionarFuncion";
            this.CbxSeleccionarFuncion.Size = new System.Drawing.Size(291, 25);
            this.CbxSeleccionarFuncion.TabIndex = 1;
            this.CbxSeleccionarFuncion.Text = "FUNCION";
            this.CbxSeleccionarFuncion.SelectedIndexChanged += new System.EventHandler(this.CbxSeleccionarFuncion_SelectedIndexChanged);
            // 
            // pcbpelicula
            // 
            this.pcbpelicula.BackColor = System.Drawing.Color.SlateGray;
            this.pcbpelicula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbpelicula.Location = new System.Drawing.Point(326, 91);
            this.pcbpelicula.Name = "pcbpelicula";
            this.pcbpelicula.Size = new System.Drawing.Size(138, 196);
            this.pcbpelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbpelicula.TabIndex = 2;
            this.pcbpelicula.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PELICULA";
            // 
            // LblN
            // 
            this.LblN.AutoSize = true;
            this.LblN.Location = new System.Drawing.Point(484, 135);
            this.LblN.Name = "LblN";
            this.LblN.Size = new System.Drawing.Size(57, 13);
            this.LblN.TabIndex = 4;
            this.LblN.Text = "NOMBRE:";
            // 
            // LblDetalleNombre
            // 
            this.LblDetalleNombre.AutoSize = true;
            this.LblDetalleNombre.Location = new System.Drawing.Point(580, 135);
            this.LblDetalleNombre.Name = "LblDetalleNombre";
            this.LblDetalleNombre.Size = new System.Drawing.Size(46, 13);
            this.LblDetalleNombre.TabIndex = 5;
            this.LblDetalleNombre.Text = "-------------";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(484, 188);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(41, 13);
            this.LblE.TabIndex = 6;
            this.LblE.Text = "Horario";
            // 
            // LblDetalleHorario
            // 
            this.LblDetalleHorario.AutoSize = true;
            this.LblDetalleHorario.Location = new System.Drawing.Point(580, 188);
            this.LblDetalleHorario.Name = "LblDetalleHorario";
            this.LblDetalleHorario.Size = new System.Drawing.Size(46, 13);
            this.LblDetalleHorario.TabIndex = 7;
            this.LblDetalleHorario.Text = "-------------";
            // 
            // LblDetalleSala
            // 
            this.LblDetalleSala.AutoSize = true;
            this.LblDetalleSala.Location = new System.Drawing.Point(580, 238);
            this.LblDetalleSala.Name = "LblDetalleSala";
            this.LblDetalleSala.Size = new System.Drawing.Size(46, 13);
            this.LblDetalleSala.TabIndex = 9;
            this.LblDetalleSala.Text = "-------------";
            this.LblDetalleSala.Click += new System.EventHandler(this.LblDetalleSala_Click);
            // 
            // LblS
            // 
            this.LblS.AutoSize = true;
            this.LblS.Location = new System.Drawing.Point(484, 238);
            this.LblS.Name = "LblS";
            this.LblS.Size = new System.Drawing.Size(37, 13);
            this.LblS.TabIndex = 8;
            this.LblS.Text = "SALA:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(12, 91);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(132, 13);
            this.LblA.TabIndex = 11;
            this.LblA.Text = "SELECCIONAR ASIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "VALOR DEL TIQUTE";
            // 
            // LblDetallePrecio
            // 
            this.LblDetallePrecio.AutoSize = true;
            this.LblDetallePrecio.Location = new System.Drawing.Point(12, 180);
            this.LblDetallePrecio.Name = "LblDetallePrecio";
            this.LblDetallePrecio.Size = new System.Drawing.Size(28, 13);
            this.LblDetallePrecio.TabIndex = 15;
            this.LblDetallePrecio.Text = "-------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "SELECCIONAR ASIENTO Y FUNCION";
            // 
            // BtnGenerarTiquete
            // 
            this.BtnGenerarTiquete.Location = new System.Drawing.Point(15, 238);
            this.BtnGenerarTiquete.Name = "BtnGenerarTiquete";
            this.BtnGenerarTiquete.Size = new System.Drawing.Size(129, 38);
            this.BtnGenerarTiquete.TabIndex = 17;
            this.BtnGenerarTiquete.Text = "GENERAR TIQUETE";
            this.BtnGenerarTiquete.UseVisualStyleBackColor = true;
            this.BtnGenerarTiquete.Click += new System.EventHandler(this.BtnGenerarTiquete_Click);
            // 
            // BtnCancelarTiquete
            // 
            this.BtnCancelarTiquete.Location = new System.Drawing.Point(150, 238);
            this.BtnCancelarTiquete.Name = "BtnCancelarTiquete";
            this.BtnCancelarTiquete.Size = new System.Drawing.Size(114, 38);
            this.BtnCancelarTiquete.TabIndex = 18;
            this.BtnCancelarTiquete.Text = "CANCELAR";
            this.BtnCancelarTiquete.UseVisualStyleBackColor = true;
            // 
            // Lbl_Disponible
            // 
            this.Lbl_Disponible.AutoSize = true;
            this.Lbl_Disponible.Location = new System.Drawing.Point(161, 63);
            this.Lbl_Disponible.Name = "Lbl_Disponible";
            this.Lbl_Disponible.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Disponible.TabIndex = 20;
            this.Lbl_Disponible.Text = "DISPONIBLES";
            // 
            // Txt_Disponibles
            // 
            this.Txt_Disponibles.Location = new System.Drawing.Point(159, 91);
            this.Txt_Disponibles.Name = "Txt_Disponibles";
            this.Txt_Disponibles.Size = new System.Drawing.Size(80, 20);
            this.Txt_Disponibles.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.Txt_Disponibles);
            this.Controls.Add(this.Lbl_Disponible);
            this.Controls.Add(this.BtnCancelarTiquete);
            this.Controls.Add(this.BtnGenerarTiquete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDetallePrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblDetalleSala);
            this.Controls.Add(this.LblS);
            this.Controls.Add(this.LblDetalleHorario);
            this.Controls.Add(this.LblE);
            this.Controls.Add(this.LblDetalleNombre);
            this.Controls.Add(this.LblN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbpelicula);
            this.Controls.Add(this.CbxSeleccionarFuncion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TAQUILLERO";
            ((System.ComponentModel.ISupportInitialize)(this.pcbpelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxSeleccionarFuncion;
        private System.Windows.Forms.PictureBox pcbpelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblN;
        private System.Windows.Forms.Label LblDetalleNombre;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblDetalleHorario;
        private System.Windows.Forms.Label LblDetalleSala;
        private System.Windows.Forms.Label LblS;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDetallePrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnGenerarTiquete;
        private System.Windows.Forms.Button BtnCancelarTiquete;
        private System.Windows.Forms.Label Lbl_Disponible;
        private System.Windows.Forms.TextBox Txt_Disponibles;
    }
}

