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
using LOGIC.CRUD;

namespace PRESENTACION.VISTA
{
    public partial class Crear_Taquillero : Form
    {
        public Crear_Taquillero()
        {
            InitializeComponent();
        }

        CUsuario usuario = new CUsuario();
        A_Usuario atributos_U = new A_Usuario();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                atributos_U.Id = Convert.ToInt32(txtIdentficacion.Text);
                atributos_U.Nombre = txtNombre.Text;
                atributos_U.Correo = txtCorreo.Text;
                atributos_U.Contrasenia = txtContrasenia.Text;
                atributos_U.Rol = "Taquillero";
                usuario.Insertar(atributos_U);               
                MessageBox.Show("Insertado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCrear_taqui_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
