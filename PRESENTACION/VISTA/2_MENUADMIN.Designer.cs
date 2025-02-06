namespace PRESENTACION
{
    partial class MENUADMIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARTAQUILLEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARPELICULAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARFUNCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARSALAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.cREARTAQUILLEROToolStripMenuItem,
            this.cREARPELICULAToolStripMenuItem,
            this.cREARFUNCIONToolStripMenuItem,
            this.cREARSALAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iNICIOToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // cREARTAQUILLEROToolStripMenuItem
            // 
            this.cREARTAQUILLEROToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.cREARTAQUILLEROToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.cREARTAQUILLEROToolStripMenuItem.Name = "cREARTAQUILLEROToolStripMenuItem";
            this.cREARTAQUILLEROToolStripMenuItem.Size = new System.Drawing.Size(166, 21);
            this.cREARTAQUILLEROToolStripMenuItem.Text = "CREAR TAQUILLERO";
            this.cREARTAQUILLEROToolStripMenuItem.Click += new System.EventHandler(this.cREARTAQUILLEROToolStripMenuItem_Click);
            // 
            // cREARPELICULAToolStripMenuItem
            // 
            this.cREARPELICULAToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cREARPELICULAToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.cREARPELICULAToolStripMenuItem.Name = "cREARPELICULAToolStripMenuItem";
            this.cREARPELICULAToolStripMenuItem.Size = new System.Drawing.Size(146, 21);
            this.cREARPELICULAToolStripMenuItem.Text = "CREAR PELICULA";
            this.cREARPELICULAToolStripMenuItem.Click += new System.EventHandler(this.cREARPELICULAToolStripMenuItem_Click);
            // 
            // cREARFUNCIONToolStripMenuItem
            // 
            this.cREARFUNCIONToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.cREARFUNCIONToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.cREARFUNCIONToolStripMenuItem.Name = "cREARFUNCIONToolStripMenuItem";
            this.cREARFUNCIONToolStripMenuItem.Size = new System.Drawing.Size(139, 21);
            this.cREARFUNCIONToolStripMenuItem.Text = "CREAR FUNCION";
            this.cREARFUNCIONToolStripMenuItem.Click += new System.EventHandler(this.cREARFUNCIONToolStripMenuItem_Click);
            // 
            // cREARSALAToolStripMenuItem
            // 
            this.cREARSALAToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cREARSALAToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold);
            this.cREARSALAToolStripMenuItem.Name = "cREARSALAToolStripMenuItem";
            this.cREARSALAToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.cREARSALAToolStripMenuItem.Text = "CREAR SALA";
            this.cREARSALAToolStripMenuItem.Click += new System.EventHandler(this.cREARSALAToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 411);
            this.panel1.TabIndex = 1;
            // 
            // MENUADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENUADMIN";
            this.Text = "MENUADMIN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARTAQUILLEROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARPELICULAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARFUNCIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARSALAToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}