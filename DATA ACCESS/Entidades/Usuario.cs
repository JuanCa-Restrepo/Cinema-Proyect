using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON_LIBRARY.ATRIBUTOS;
using DATA_ACCESS.Coneccion;

namespace DATA_ACCESS.Entidades
{
    public class Usuario
    {
        //Intancia objeto de connection database no olvidar el using
        Coneccion_Bd c = new Coneccion_Bd();
        //Comando de manejo
        SqlCommand cmd = new SqlCommand();
        //Interprete de lectura
        SqlDataReader dr;
        //Comunicacion a la vista
        DataTable td = new DataTable();

        


        public A_Usuario Ingreso ( A_Usuario obj)
        {
            A_Usuario INGRESADO = new A_Usuario();
            
            try
            {
                
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "INICIO_SESION";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CORREO", obj.Correo);
                cmd.Parameters.AddWithValue("@CONTRASENIA", obj.Contrasenia);   
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                   INGRESADO.Id = dr.GetInt32(dr.GetOrdinal("Id_user"));
                   INGRESADO.Correo = dr.GetString(dr.GetOrdinal("Correo"));
                    INGRESADO.Rol = dr.GetString(dr.GetOrdinal("Rol"));
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
            return INGRESADO;
        }


        public void Insertar(A_Usuario obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Insertar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", obj.Id);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                cmd.Parameters.AddWithValue("@Contrasenia", obj.Contrasenia);
                cmd.Parameters.AddWithValue("@Rol", obj.Rol);
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
