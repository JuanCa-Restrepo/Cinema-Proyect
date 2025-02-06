using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS.Coneccion;
using COMMON_LIBRARY.ATRIBUTOS;

namespace DATA_ACCESS.Entidades
{
    public class Sala
    {

        //Intancia objeto de connection database no olvidar el using
        Coneccion_Bd c = new Coneccion_Bd();
        //Comando de manejo
        SqlCommand cmd = new SqlCommand();
        //Interprete de lectura
        SqlDataReader dr;
        //Comunicacion a la vista
        DataTable td = new DataTable();
        public void Insertar(A_Sala obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Insertar_Sala";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NUMERO_SALA", obj.Id);
                cmd.Parameters.AddWithValue("@CANTIDAD_ASIENTOS", obj.Cant_asientos);
                cmd.Parameters.AddWithValue("@TIPO_SALA", obj.Tipo_sala);
                cmd.Parameters.AddWithValue("@PRECIO", obj.Precio);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }


        }
        public List<A_Sala> BUSCAR()
        {
            List<A_Sala> salas = new List<A_Sala>();

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_BUSCAR_SALA";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();


                A_Sala INICIAL = new A_Sala();
                INICIAL.Id = 0;
                salas.Add(INICIAL);


                while (dr.Read())
                {
                    A_Sala sala = new A_Sala();
                    sala.Id = dr.GetInt32(dr.GetOrdinal("Numero_sala"));
                    sala.Tipo_sala=dr.GetString(dr.GetOrdinal("Tipo_sala"));
                    sala.Cant_asientos = dr.GetInt32(dr.GetOrdinal("Cantidad_asientos"));
                    
              
                    salas.Add(sala);
                }

            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return salas;
        }
    }
}
