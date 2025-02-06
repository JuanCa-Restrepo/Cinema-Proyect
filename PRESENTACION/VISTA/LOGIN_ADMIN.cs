using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION.VISTA
{
    public partial class LOGIN_ADMIN : Form
    {
        public LOGIN_ADMIN()
        {
            InitializeComponent();
        }

        private void LOGIN_ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            INICIO regresar = new INICIO();
            regresar.Show();
           MENUADMIN cerrar = new MENUADMIN();
            cerrar.Hide();
          
        }
    }
}
