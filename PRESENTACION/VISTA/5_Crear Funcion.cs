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


namespace PRESENTACION.VISTA
{
    public partial class Crear_Funcion : Form
    {
        public Crear_Funcion()
        {
            InitializeComponent();
            getData();
            
        }
        CPelicula peli = new CPelicula();
        CSala sala = new CSala();
        List<A_Pelicula> peliculas = new List<A_Pelicula>();
        List<A_Sala> Salas = new List<A_Sala>();   
        
        Cfuncion Cfuncion = new Cfuncion();
        A_Funcion a_Funcion = new A_Funcion();
        


        private void getData()
        {
            Salas = sala.BUSCAR();
            Cbx_Sala.DataSource = Salas;
            Cbx_Sala.DisplayMember = "Id";
            Cbx_Sala.ValueMember = "Id";
            
            
           

            peliculas = peli.BUSCAR();
            Cbx_Peliculas.DataSource = peliculas;
            Cbx_Peliculas.DisplayMember = "Nombre";
            Cbx_Peliculas.ValueMember = "Id_peli";

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            a_Funcion.Id_peli = (int)Cbx_Peliculas.SelectedValue;
            a_Funcion.Num_sala = (int)Cbx_Sala.SelectedValue;
            a_Funcion.Horario= txtHorario.Text;
            a_Funcion.Disponibles = 0;
            Cfuncion.Insertar(a_Funcion);
            MessageBox.Show("Insertado");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Cbx_Peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
           int pelicula = Cbx_Peliculas.SelectedIndex;
            if (pelicula > 0) {
                MemoryStream image = new MemoryStream((byte[])peliculas[pelicula].Imagen);
                Bitmap bm = new Bitmap(image);
                pcbImagen.Image = bm;
            }
           
        }

        private void Crear_Funcion_Load(object sender, EventArgs e)
        {
            Salas = sala.BUSCAR();
            Cbx_Peliculas.DataSource = Salas;
            Cbx_Sala.DisplayMember = "Id_peli";




        }
    }
}
