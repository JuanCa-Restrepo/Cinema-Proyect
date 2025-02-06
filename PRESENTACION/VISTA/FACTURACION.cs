using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMMON_LIBRARY.ATRIBUTOS;

namespace PRESENTACION.VISTA
{
    public partial class FACTURACION : Form
    {
        A_Usuario usuario = new A_Usuario();
        public FACTURACION()
        {
            InitializeComponent();
            TxtFuncion.Text = usuario.Nombre;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {

            _10_MENUTAQUILLERO Volver = new _10_MENUTAQUILLERO();
            Volver.Show();
            this.Hide();

        }
    }
}
