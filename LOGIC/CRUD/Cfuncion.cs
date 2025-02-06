using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON_LIBRARY.ATRIBUTOS;
using DATA_ACCESS.Entidades;

namespace LOGIC.CRUD
{
    public class Cfuncion
    { 
        Funcion funcion = new Funcion();
        public void Insertar(A_Funcion obj)
        {
            funcion.Insertar(obj);
        }
        public List<A_Funcion> busqueda(int peli)
        {

            return funcion.busqueda(peli);
        }

        public A_Sala buscartiposala(int sala)
        {
            return funcion.buscartiposala(sala);
        }
        public void ModificarAsientos(A_Funcion obj)
        {
            funcion.ModificarAsientos(obj);
        }

    }
}
