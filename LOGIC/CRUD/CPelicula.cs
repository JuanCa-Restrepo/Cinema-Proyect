using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON_LIBRARY.ATRIBUTOS;
using DATA_ACCESS.Entidades;

namespace LOGIC.CRUD
{
    public class CPelicula
    {
        Pelicula pelicula =new Pelicula();
        public void Insertar(A_Pelicula obj)
        {
            pelicula.Insertar(obj);
        }
        public List<A_Pelicula> BUSCAR()
        {
            return pelicula.BUSCAR();
        }
        public List<A_Pelicula> cartelera()
        {
            return pelicula.cartelera();
        }
        public A_Pelicula busqueda(int id)
        {
            return pelicula.busqueda(id);
        }
    }
}
