using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMMON_LIBRARY.ATRIBUTOS;
using LOGIC.CRUD;

namespace PRESENTACION.VISTA
{
    public partial class Crear_pelicula : Form
    {
        public Crear_pelicula()
        {
            InitializeComponent();
        }
        CPelicula pelicula = new CPelicula();
        A_Pelicula atributos_p = new A_Pelicula();
        private void btnCrear_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pcbImagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] data = ms.ToArray();

            atributos_p.Nombre=txtNombre.Text;
            atributos_p.Descripcion=txtDescripcion.Text;
            atributos_p.Duracion=txtDuracion.Text;
            atributos_p.Genero=txtgenero.Text;
            atributos_p.Imagen = data;
            pelicula.Insertar(atributos_p);
            MessageBox.Show("Insertado");

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "archivos de image(*jpg;*png;)|*jpg; *png;";
            if(file.ShowDialog() == DialogResult.OK)
            {
                pcbImagen.Image=Image.FromFile(file.FileName);
            }
        }
    }
}
