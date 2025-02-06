namespace PRESENTACION.VISTA
{
    partial class Crear_Sala
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
            this.Cbx_TIpoSala = new System.Windows.Forms.ComboBox();
            this.Lbl_TipoSala = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNumSala = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtValorAsiento = new System.Windows.Forms.TextBox();
            this.txtCantAsientos = new System.Windows.Forms.TextBox();
            this.Lbl_ValorAsiento = new System.Windows.Forms.Label();
            this.lblCantAsientos = new System.Windows.Forms.Label();
            this.lblCrear_Funcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbx_TIpoSala
            // 
            this.Cbx_TIpoSala.FormattingEnabled = true;
            this.Cbx_TIpoSala.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4D"});
            this.Cbx_TIpoSala.Location = new System.Drawing.Point(246, 87);
            this.Cbx_TIpoSala.Name = "Cbx_TIpoSala";
            this.Cbx_TIpoSala.Size = new System.Drawing.Size(171, 21);
            this.Cbx_TIpoSala.TabIndex = 47;
            this.Cbx_TIpoSala.SelectedIndexChanged += new System.EventHandler(this.Cbx_TIpoSala_SelectedIndexChanged);
            // 
            // Lbl_TipoSala
            // 
            this.Lbl_TipoSala.AutoSize = true;
            this.Lbl_TipoSala.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_TipoSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_TipoSala.Location = new System.Drawing.Point(26, 87);
            this.Lbl_TipoSala.Name = "Lbl_TipoSala";
            this.Lbl_TipoSala.Size = new System.Drawing.Size(138, 25);
            this.Lbl_TipoSala.TabIndex = 46;
            this.Lbl_TipoSala.Text = "Tipo de sala:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(229, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(115, 331);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 35);
            this.btnCrear.TabIndex = 44;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNumSala
            // 
            this.txtNumSala.Location = new System.Drawing.Point(246, 277);
            this.txtNumSala.Name = "txtNumSala";
            this.txtNumSala.Size = new System.Drawing.Size(171, 20);
            this.txtNumSala.TabIndex = 43;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSala.Location = new System.Drawing.Point(36, 259);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(163, 25);
            this.lblSala.TabIndex = 42;
            this.lblSala.Text = "Numero de sala";
            // 
            // txtValorAsiento
            // 
            this.txtValorAsiento.Location = new System.Drawing.Point(246, 216);
            this.txtValorAsiento.Name = "txtValorAsiento";
            this.txtValorAsiento.Size = new System.Drawing.Size(171, 20);
            this.txtValorAsiento.TabIndex = 41;
            // 
            // txtCantAsientos
            // 
            this.txtCantAsientos.Location = new System.Drawing.Point(246, 156);
            this.txtCantAsientos.Name = "txtCantAsientos";
            this.txtCantAsientos.ReadOnly = true;
            this.txtCantAsientos.Size = new System.Drawing.Size(171, 20);
            this.txtCantAsientos.TabIndex = 40;
            // 
            // Lbl_ValorAsiento
            // 
            this.Lbl_ValorAsiento.AutoSize = true;
            this.Lbl_ValorAsiento.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_ValorAsiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_ValorAsiento.Location = new System.Drawing.Point(36, 203);
            this.Lbl_ValorAsiento.Name = "Lbl_ValorAsiento";
            this.Lbl_ValorAsiento.Size = new System.Drawing.Size(140, 25);
            this.Lbl_ValorAsiento.TabIndex = 39;
            this.Lbl_ValorAsiento.Text = "Valor asiento";
            // 
            // lblCantAsientos
            // 
            this.lblCantAsientos.AutoSize = true;
            this.lblCantAsientos.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCantAsientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantAsientos.Location = new System.Drawing.Point(26, 151);
            this.lblCantAsientos.Name = "lblCantAsientos";
            this.lblCantAsientos.Size = new System.Drawing.Size(214, 25);
            this.lblCantAsientos.TabIndex = 38;
            this.lblCantAsientos.Text = "Cantidad de asientos";
            // 
            // lblCrear_Funcion
            // 
            this.lblCrear_Funcion.AutoSize = true;
            this.lblCrear_Funcion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCrear_Funcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCrear_Funcion.Location = new System.Drawing.Point(12, 9);
            this.lblCrear_Funcion.Name = "lblCrear_Funcion";
            this.lblCrear_Funcion.Size = new System.Drawing.Size(141, 25);
            this.lblCrear_Funcion.TabIndex = 48;
            this.lblCrear_Funcion.Text = "CREAR SALA";
            // 
            // Crear_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(429, 398);
            this.Controls.Add(this.lblCrear_Funcion);
            this.Controls.Add(this.Cbx_TIpoSala);
            this.Controls.Add(this.Lbl_TipoSala);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNumSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.txtValorAsiento);
            this.Controls.Add(this.txtCantAsientos);
            this.Controls.Add(this.Lbl_ValorAsiento);
            this.Controls.Add(this.lblCantAsientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_Sala";
            this.Text = "6_CrearSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx_TIpoSala;
        private System.Windows.Forms.Label Lbl_TipoSala;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNumSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtValorAsiento;
        private System.Windows.Forms.TextBox txtCantAsientos;
        private System.Windows.Forms.Label Lbl_ValorAsiento;
        private System.Windows.Forms.Label lblCantAsientos;
        private System.Windows.Forms.Label lblCrear_Funcion;
    }
}