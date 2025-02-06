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
    public class CUsuario
    {
        Usuario usuario = new Usuario();

        public A_Usuario Ingreso (A_Usuario obj) 
        {
          A_Usuario INGRESADO = new A_Usuario();
          INGRESADO=usuario.Ingreso(obj);
            
           return INGRESADO;
        }

        public void Insertar(A_Usuario obj)
        {
            usuario.Insertar(obj);
        }

    }
}
