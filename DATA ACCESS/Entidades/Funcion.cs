using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS.Coneccion;
using COMMON_LIBRARY.ATRIBUTOS;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace DATA_ACCESS.Entidades
{
    public class Funcion
    {
        //Intancia objeto de connection database no olvidar el using
        Coneccion_Bd c = new Coneccion_Bd();
        //Comando de manejo
        SqlCommand cmd = new SqlCommand();
        //Interprete de lectura
        SqlDataReader dr;
        //Comunicacion a la vista
        DataTable td = new DataTable();

        public void Insertar(A_Funcion obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_INSERTAR_FUNCION";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PELICULA", obj.Id_peli);
                cmd.Parameters.AddWithValue("@NUM_SALA", obj.Num_sala);
                cmd.Parameters.AddWithValue("@HORARIO", obj.Horario);
                cmd.Parameters.AddWithValue("ASIENTOS", obj.Disponibles);
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

        public A_Sala buscartiposala(int sala)
        {
            A_Sala listaSalas = new A_Sala();

            try
            {

                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SELECT_TIPO_SALA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Numero_sala", sala);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    A_Sala a_Sala = new A_Sala();
                   a_Sala.Precio = dr.GetInt32(dr.GetOrdinal("Precio"));
                    listaSalas = a_Sala;
                }


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
           return listaSalas;

        }
        public List<A_Funcion> busqueda(int peli)
        {
            List<A_Funcion> funcions = new List<A_Funcion>();

            try
            {
                
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "Consulta_funciones";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPeli", peli);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    A_Funcion funcion = new A_Funcion();
                    funcion.Id = dr.GetInt32(dr.GetOrdinal("Numero_funcion"));
                    funcion.Horario = dr.GetString(dr.GetOrdinal("Horario"));
                    funcion.Num_sala = dr.GetInt32(dr.GetOrdinal("Num_sala"));
                    funcion.Disponibles = dr.GetInt32(dr.GetOrdinal("asientos_disponibles"));
                    funcions.Add(funcion);
                }


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
            return funcions;

        }

        public void ModificarAsientos (A_Funcion obj)
        {
           
                try
                {
                    cmd.Connection = c.OpenConnection();
                    cmd.CommandText = "SP_MODIFICAR_ASIENTOS";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NUMERO_FUNCION", obj.Id);
                    cmd.Parameters.AddWithValue("@DISPONIBLES", obj.Disponibles);                    
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
    }
}
