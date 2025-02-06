using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON_LIBRARY.ATRIBUTOS;
using DATA_ACCESS.Entidades;
namespace LOGIC.CRUD
{
    public class CSala
    {
        Sala sala = new Sala();
        public void Insertar(A_Sala obj)
        {
            sala.Insertar(obj);
        }
        public List<A_Sala> BUSCAR()
        {
            return sala.BUSCAR();
        }
    }
}
