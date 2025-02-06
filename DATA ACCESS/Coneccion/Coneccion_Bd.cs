using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCESS.Coneccion
{
    public class Coneccion_Bd
    {
        private SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=Sistema_cine;Integrated Security=True");
        public SqlConnection OpenConnection()
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }

        public SqlConnection CloseConnection()
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;
        }
    }
}
