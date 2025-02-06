namespace PRESENTACION.VISTA
{
    partial class Crear_Funcion
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
            this.lblCrear_Funcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.Lbl_Horario = new System.Windows.Forms.Label();
            this.Lbl_Pelicula = new System.Windows.Forms.Label();
            this.Cbx_Peliculas = new System.Windows.Forms.ComboBox();
            this.Cbx_Sala = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrear_Funcion
            // 
            this.lblCrear_Funcion.AutoSize = true;
            this.lblCrear_Funcion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCrear_Funcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCrear_Funcion.Location = new System.Drawing.Point(12, 9);
            this.lblCrear_Funcion.Name = "lblCrear_Funcion";
            this.lblCrear_Funcion.Size = new System.Drawing.Size(180, 25);
            this.lblCrear_Funcion.TabIndex = 17;
            this.lblCrear_Funcion.Text = "CREAR FUNCION";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(215, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 35);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.Color.Silver;
            this.pcbImagen.Location = new System.Drawing.Point(337, 36);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(179, 250);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 34;
            this.pcbImagen.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(101, 251);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(91, 35);
            this.btnCrear.TabIndex = 33;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSala.Location = new System.Drawing.Point(44, 187);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(51, 25);
            this.lblSala.TabIndex = 31;
            this.lblSala.Text = "Sala";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(135, 129);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(196, 20);
            this.txtHorario.TabIndex = 30;
            // 
            // Lbl_Horario
            // 
            this.Lbl_Horario.AutoSize = true;
            this.Lbl_Horario.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Horario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Horario.Location = new System.Drawing.Point(34, 124);
            this.Lbl_Horario.Name = "Lbl_Horario";
            this.Lbl_Horario.Size = new System.Drawing.Size(83, 25);
            this.Lbl_Horario.TabIndex = 28;
            this.Lbl_Horario.Text = "Horario";
            // 
            // Lbl_Pelicula
            // 
            this.Lbl_Pelicula.AutoSize = true;
            this.Lbl_Pelicula.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Pelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Pelicula.Location = new System.Drawing.Point(33, 61);
            this.Lbl_Pelicula.Name = "Lbl_Pelicula";
            this.Lbl_Pelicula.Size = new System.Drawing.Size(85, 25);
            this.Lbl_Pelicula.TabIndex = 36;
            this.Lbl_Pelicula.Text = "Pelicula";
            // 
            // Cbx_Peliculas
            // 
            this.Cbx_Peliculas.FormattingEnabled = true;
            this.Cbx_Peliculas.Location = new System.Drawing.Point(135, 65);
            this.Cbx_Peliculas.Name = "Cbx_Peliculas";
            this.Cbx_Peliculas.Size = new System.Drawing.Size(196, 21);
            this.Cbx_Peliculas.TabIndex = 37;
            this.Cbx_Peliculas.SelectedIndexChanged += new System.EventHandler(this.Cbx_Peliculas_SelectedIndexChanged);
            // 
            // Cbx_Sala
            // 
            this.Cbx_Sala.FormattingEnabled = true;
            this.Cbx_Sala.Location = new System.Drawing.Point(135, 193);
            this.Cbx_Sala.Name = "Cbx_Sala";
            this.Cbx_Sala.Size = new System.Drawing.Size(196, 21);
            this.Cbx_Sala.TabIndex = 38;
            // 
            // Crear_Funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(557, 331);
            this.Controls.Add(this.Cbx_Sala);
            this.Controls.Add(this.Cbx_Peliculas);
            this.Controls.Add(this.Lbl_Pelicula);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.Lbl_Horario);
            this.Controls.Add(this.lblCrear_Funcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_Funcion";
            this.Text = "_5_Crear_Funcion";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCrear_Funcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label Lbl_Horario;
        private System.Windows.Forms.Label Lbl_Pelicula;
        private System.Windows.Forms.ComboBox Cbx_Peliculas;
        private System.Windows.Forms.ComboBox Cbx_Sala;
    }
}