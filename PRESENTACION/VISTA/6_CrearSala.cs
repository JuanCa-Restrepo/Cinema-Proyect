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
    public partial class Crear_Sala : Form
    {
        public Crear_Sala()
        {
            InitializeComponent();
            txtCantAsientos.Text = "9";
           

        }


        CSala sala = new CSala();
        A_Sala atributos_S = new A_Sala();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            atributos_S.Tipo_sala = Cbx_TIpoSala.Text;
            
            atributos_S.Cant_asientos= int.Parse(txtCantAsientos.Text);
            atributos_S.Precio =int.Parse( txtValorAsiento.Text);
            atributos_S.Id =int.Parse(txtNumSala.Text);
            sala.Insertar(atributos_S);
            MessageBox.Show("insertado");
        }

        private void Cbx_TIpoSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_TIpoSala.SelectedIndex >= 0 && Cbx_TIpoSala.SelectedIndex < 3)
            {
                switch (Cbx_TIpoSala.SelectedIndex)
                {
                    case 0:
                        txtValorAsiento.Text = "8000";
                        break;
                    case 1:
                        txtValorAsiento.Text = "11000";
                        break;
                    case 2:
                        txtValorAsiento.Text = "15000";
                        break;
                }

            }
        }
    }
}
