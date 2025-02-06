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
using TAQUILLERO;

namespace PRESENTACION.VISTA
{
    public partial class _10_MENUTAQUILLERO : Form
    {
        public _10_MENUTAQUILLERO()
        {
            InitializeComponent();
        }
        CPelicula pelis = new CPelicula();
        List<A_Pelicula> a_Peliculas = new List<A_Pelicula>();
        int BUSQUEDA;

        private void Btn_Seleccionar1_Click(object sender, EventArgs e)
        {
            BUSQUEDA = a_Peliculas[0].Id_peli;

            Form1 taquillero = new Form1(BUSQUEDA);
            taquillero.Show();
            this.Hide();
        }

        private void _10_MENUTAQUILLERO_Load(object sender, EventArgs e)
        {
            a_Peliculas = pelis.cartelera();
            MemoryStream image1 = new MemoryStream((byte[])a_Peliculas[0].Imagen);
            Bitmap bm1 = new Bitmap(image1);
            Ptb_Pelicula1.Image= bm1;
            MemoryStream image2 = new MemoryStream((byte[])a_Peliculas[1].Imagen);
            Bitmap bm2 = new Bitmap(image2);
            Ptb_Pelicula2.Image = bm2;
            MemoryStream image3 = new MemoryStream((byte[])a_Peliculas[2].Imagen);
            Bitmap bm3 = new Bitmap(image3);
            Ptb_Pelicula3.Image = bm3;



        }

        private void Btn_Seleccionar2_Click(object sender, EventArgs e)
        {
            BUSQUEDA = a_Peliculas[1].Id_peli;

            Form1 taquillero = new Form1(BUSQUEDA);
            taquillero.Show();
            this.Hide();
        }

        private void Btn_Seleccionar3_Click(object sender, EventArgs e)
        {
            BUSQUEDA = a_Peliculas[2].Id_peli;

            Form1 taquillero = new Form1(BUSQUEDA);
            taquillero.Show();
            this.Hide();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            INICIO regresar = new INICIO();
            regresar.Show();
            this.Hide();

        }
    }
}
