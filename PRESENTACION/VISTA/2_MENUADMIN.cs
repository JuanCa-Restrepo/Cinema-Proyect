using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRESENTACION.VISTA;

namespace PRESENTACION
{
    public partial class MENUADMIN : Form
    {
        public MENUADMIN()
        {
            InitializeComponent();
            LOGIN_ADMIN lOGIN_ADMIN = new LOGIN_ADMIN();
            lOGIN_ADMIN.TopLevel = false;
            panel1.Controls.Add(lOGIN_ADMIN);
            lOGIN_ADMIN.Show();

        }

        private void cREARTAQUILLEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Crear_Taquillero taquillero = new Crear_Taquillero();
            taquillero.TopLevel = false;
            panel1.Controls.Add(taquillero);
            taquillero.Show();
        }

        private void cREARPELICULAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Crear_pelicula pelicula = new Crear_pelicula();
            pelicula.TopLevel = false;
            panel1.Controls.Add(pelicula);
            pelicula.Show();
        }

        private void cREARFUNCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Crear_Funcion funcion = new Crear_Funcion();
            funcion.TopLevel = false;
            panel1.Controls.Add(funcion);
            funcion.Show();
        }

        private void cREARSALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Crear_Sala sala = new Crear_Sala();
            sala.TopLevel = false;
            panel1.Controls.Add(sala);
            sala.Show();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LOGIN_ADMIN lOGIN_ADMIN = new LOGIN_ADMIN();
            lOGIN_ADMIN.TopLevel = false;
            panel1.Controls.Add(lOGIN_ADMIN);
            lOGIN_ADMIN.Show();
        }
    }
}
