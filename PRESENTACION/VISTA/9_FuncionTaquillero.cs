using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMMON_LIBRARY.ATRIBUTOS;
using LOGIC.CRUD;
using PRESENTACION.VISTA;

namespace TAQUILLERO
{
    public partial class Form1 : Form
    {
        public Form1(int pelicula)
        {
            InitializeComponent();
            this.pelicula = pelicula;

            getData();
        }
        int pelicula;
       
        List<A_Funcion> funcions= new List<A_Funcion>();
        A_Sala lsalas = new A_Sala ();
        Cfuncion funcion = new Cfuncion();
        A_Pelicula peli = new A_Pelicula();
        CPelicula pelicula1 = new CPelicula();
        A_Funcion Funcion1 = new A_Funcion();
      

        private void obtenerdata()
        {
            int sal = int.Parse(LblDetalleSala.Text);
            lsalas = funcion.buscartiposala(sal);
        }
        private void obtenerdatas()
        {
        
        }
        private void getData()
        {

           
            funcions = funcion.busqueda(pelicula);
          
            CbxSeleccionarFuncion.DataSource = funcions;
            CbxSeleccionarFuncion.DisplayMember = "id";
            CbxSeleccionarFuncion.ValueMember = "id";

            peli = pelicula1.busqueda(pelicula);
            LblDetalleNombre.Text = peli.Nombre;
            MemoryStream image = new MemoryStream((byte[])peli.Imagen);
            Bitmap bm = new Bitmap(image);
            pcbpelicula.Image = bm;



        }

        private void CbxSeleccionarFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fun = CbxSeleccionarFuncion.SelectedIndex;
            LblDetalleHorario.Text = funcions[fun].Horario;
            LblDetalleSala.Text = funcions[fun].Num_sala.ToString();
            Txt_Disponibles.Text = funcions[fun].Disponibles.ToString();

            obtenerdata();



            LblDetallePrecio.Text = lsalas.Precio.ToString();
        }

        private void BtnGenerarTiquete_Click(object sender, EventArgs e)
        {

            Funcion1.Id = int.Parse(CbxSeleccionarFuncion.Text);        

            Funcion1.Disponibles = int.Parse(Txt_Disponibles.Text) - 1;

            if (Funcion1.Disponibles != -1)
            {

                funcion.ModificarAsientos(Funcion1);

                FACTURACION datos = new FACTURACION();
                datos.TxtHorario.Text = LblDetalleHorario.Text;
                datos.TxtFuncion.Text = CbxSeleccionarFuncion.Text;
                datos.Txt_Nombre.Text = LblDetalleNombre.Text;
                datos.TxtSala.Text = LblDetalleSala.Text;
                datos.TxtPrecio.Text = LblDetallePrecio.Text;

                datos.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lo sentimos asientos no disponibles");

                _10_MENUTAQUILLERO Volver = new _10_MENUTAQUILLERO();
                Volver.Show();
                this.Hide();
            }

           
        }

        private void LblDetalleSala_Click(object sender, EventArgs e)
        {
           
        }
    }
}
