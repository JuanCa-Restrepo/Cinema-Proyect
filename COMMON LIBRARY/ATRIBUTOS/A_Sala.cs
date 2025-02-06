using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON_LIBRARY.ATRIBUTOS
{
    public class A_Sala
    {
        private int id;
        private int cant_asientos;
        private string tipo_sala;
        private int precio;

        public int Id { get => id; set => id = value; }
        public int Cant_asientos { get => cant_asientos; set => cant_asientos = value; }
        public string Tipo_sala { get => tipo_sala; set => tipo_sala = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
