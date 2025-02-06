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
    public class Pelicula
    {
        //Intancia objeto de connection database no olvidar el using
        Coneccion_Bd c = new Coneccion_Bd();
        //Comando de manejo
        SqlCommand cmd = new SqlCommand();
        //Interprete de lectura
        SqlDataReader dr;
        //Comunicacion a la vista
        DataTable td = new DataTable();
        public void Insertar(A_Pelicula obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_INSERTAR_PELICULA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre);
                cmd.Parameters.AddWithValue("@DESCRIPCION", obj.Descripcion);
                cmd.Parameters.AddWithValue("@IMAGEN", obj.Imagen);
                cmd.Parameters.AddWithValue("@DURACION", obj.Duracion);
                cmd.Parameters.AddWithValue("@GENERO", obj.Genero);
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
        public List<A_Pelicula> BUSCAR()
        {
            List<A_Pelicula> peliculas = new List<A_Pelicula>();

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_BUSCAR_PELI";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                

                A_Pelicula INICIAL = new A_Pelicula();
                INICIAL.Nombre = "SELECCIONAR";
                peliculas.Add(INICIAL);

                while (dr.Read())
                {
                    A_Pelicula pelicula = new A_Pelicula();
                    pelicula.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    pelicula.Id_peli = dr.GetInt32(dr.GetOrdinal("Id_peli"));
                    pelicula.Imagen = dr.IsDBNull(dr.GetOrdinal("Imagen")) ? null : (byte[])dr["Imagen"];
                    peliculas.Add(pelicula);
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
            return peliculas;
        }
        public List<A_Pelicula> cartelera()
        {
            List<A_Pelicula> cartelera = new List<A_Pelicula>();

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "CARTELERA";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    A_Pelicula pelicula = new A_Pelicula();
                    pelicula.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    pelicula.Id_peli = dr.GetInt32(dr.GetOrdinal("Id_peli"));
                    pelicula.Imagen = dr.IsDBNull(dr.GetOrdinal("Imagen")) ? null : (byte[])dr["Imagen"];
                    cartelera.Add(pelicula);
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
            return cartelera;
        }
        public A_Pelicula busqueda( int id )
        {
            A_Pelicula pelicula = new A_Pelicula();
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "PELI_SELECT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( "@ID_PELI", id );    
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                pelicula.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                pelicula.Id_peli = dr.GetInt32(dr.GetOrdinal("Id_peli"));
                pelicula.Imagen = dr.IsDBNull(dr.GetOrdinal("Imagen")) ? null : (byte[])dr["Imagen"];
            }
            return pelicula;
        }
    }
}
