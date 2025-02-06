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
using PRESENTACION.VISTA;

namespace PRESENTACION
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        CUsuario usuario = new CUsuario();
        A_Usuario atributos_U = new A_Usuario();
        
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            atributos_U.Correo = txtCorreo.Text;
            atributos_U.Contrasenia = txtContrasenia.Text;
            atributos_U= usuario.Ingreso(atributos_U);

           
            switch (atributos_U.Rol)
            {
                case "Taquillero":

                    _10_MENUTAQUILLERO taquillero = new _10_MENUTAQUILLERO();
                    taquillero.Show();
                    this.Hide();
                    break;
                case "admin":
                    MENUADMIN admin = new MENUADMIN();
                    admin.Show();
                    this.Hide();

                    break;
            }












        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }
    }
}
