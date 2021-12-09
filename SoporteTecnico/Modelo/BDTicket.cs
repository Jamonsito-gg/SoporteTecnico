using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SoporteTecnico.Controlador;

namespace SoporteTecnico.Modelo
{
    class BDTicket
    {
        public void mostrar(ref DataTable DT)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.abrir();
                SqlDataAdapter DA = new SqlDataAdapter("mostrar_ticket_tabla", conn.conectar);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.cerrar();
            }
        }

        public bool insertar(ESTicket nuevo)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.abrir();
                SqlCommand insert = new SqlCommand("insertar_ticket", conn.conectar);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("@Nombre", nuevo.Nombre1);
                insert.Parameters.AddWithValue("@Apellido", nuevo.Apellido1);
                insert.Parameters.AddWithValue("@Correo", nuevo.Correo1);
                insert.Parameters.AddWithValue("@Estado", nuevo.Estado1);
                insert.Parameters.AddWithValue("@Dispositivo", nuevo.Dispositivo1);
                insert.Parameters.AddWithValue("@Descripción", nuevo.Descripción1);
                insert.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.cerrar();
            }
        }

        public bool eliminar(int NumTicket)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_ticket", conn.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumTicket", NumTicket);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.cerrar();
            }
        }
        public bool modificar(ESTicket nuevo1)
        {
            Conexion conn = new Conexion();

            try
            {
                conn.abrir();
                SqlCommand modify = new SqlCommand("modificar_ticket", conn.conectar);
                modify.CommandType = CommandType.StoredProcedure;
                modify.Parameters.AddWithValue("@Nombre", nuevo1.Nombre1);
                modify.Parameters.AddWithValue("@Apellido", nuevo1.Apellido1);
                modify.Parameters.AddWithValue("@Correo", nuevo1.Correo1);
                modify.Parameters.AddWithValue("@Estado", nuevo1.Estado1);
                modify.Parameters.AddWithValue("@Descripción", nuevo1.Descripción1);
                modify.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.cerrar();
            }
        }
    }
}
