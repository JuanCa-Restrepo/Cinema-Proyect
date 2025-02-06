namespace PRESENTACION.VISTA
{
    partial class Crear_pelicula
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIdescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCrear_peli = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblgenero = new System.Windows.Forms.Label();
            this.txtgenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(205, 312);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(81, 35);
            this.btnCrear.TabIndex = 23;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(205, 199);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(213, 20);
            this.txtDuracion.TabIndex = 22;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDuracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDuracion.Location = new System.Drawing.Point(58, 198);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(95, 25);
            this.lblDuracion.TabIndex = 21;
            this.lblDuracion.Text = "Duracion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(205, 143);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(213, 20);
            this.txtDescripcion.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // lblIdescripcion
            // 
            this.lblIdescripcion.AutoSize = true;
            this.lblIdescripcion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIdescripcion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIdescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdescripcion.Location = new System.Drawing.Point(58, 140);
            this.lblIdescripcion.Name = "lblIdescripcion";
            this.lblIdescripcion.Size = new System.Drawing.Size(119, 25);
            this.lblIdescripcion.TabIndex = 18;
            this.lblIdescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(58, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCrear_peli
            // 
            this.lblCrear_peli.AutoSize = true;
            this.lblCrear_peli.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCrear_peli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrear_peli.Location = new System.Drawing.Point(12, 9);
            this.lblCrear_peli.Name = "lblCrear_peli";
            this.lblCrear_peli.Size = new System.Drawing.Size(185, 25);
            this.lblCrear_peli.TabIndex = 16;
            this.lblCrear_peli.Text = "CREAR PELICULA";
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.Color.Gray;
            this.pcbImagen.Location = new System.Drawing.Point(441, 83);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(175, 196);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 24;
            this.pcbImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(319, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 35);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.Location = new System.Drawing.Point(486, 285);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(103, 34);
            this.btnInsertar.TabIndex = 26;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblgenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgenero.Location = new System.Drawing.Point(58, 248);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(78, 25);
            this.lblgenero.TabIndex = 27;
            this.lblgenero.Text = "Genero";
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(205, 259);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(213, 20);
            this.txtgenero.TabIndex = 28;
            // 
            // Crear_pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCrear_peli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_pelicula";
            this.Text = "pelicula";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIdescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCrear_peli;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.TextBox txtgenero;
    }
}