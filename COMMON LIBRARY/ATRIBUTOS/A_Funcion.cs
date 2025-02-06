using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON_LIBRARY.ATRIBUTOS
{     
         public  class A_Funcion
    {
        private int id;
        private int id_peli;
        private int num_sala;
        private string horario;
        private int disponibles;

        public int Id { get => id; set => id = value; }
        public int Id_peli { get => id_peli; set => id_peli = value; }
        public int Num_sala { get => num_sala; set => num_sala = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Disponibles { get => disponibles; set => disponibles = value; }
    }
}
