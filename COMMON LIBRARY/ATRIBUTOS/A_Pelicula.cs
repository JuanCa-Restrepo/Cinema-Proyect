using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace COMMON_LIBRARY.ATRIBUTOS
{
    public class A_Pelicula
    {
        private int id_peli;
        private string nombre;
        private string descripcion;
        private byte[] imagen;
        private string duracion;
        private string genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        
        public string Duracion { get => duracion; set => duracion = value; }
        public string Genero { get => genero; set => genero = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public int Id_peli { get => id_peli; set => id_peli = value; }
    }
}
