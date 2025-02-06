using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON_LIBRARY.ATRIBUTOS
{
    public class A_Usuario
    {
        private int id;
        private string nombre;        
        private string correo;
        private string contrasenia;
        private string rol;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
