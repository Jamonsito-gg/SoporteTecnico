using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SoporteTecnico.Modelo
{
    class Conexion
    {
        string cadenaConexion = "Data Source = DESKTOP-KDAHIVO\\SQLEXPRESS;initial Catalog=BaseSoporte; Integrated Security = true";
        public SqlConnection conectar = new SqlConnection();

        public Conexion()
        {
            conectar.ConnectionString = cadenaConexion;
        }

        public void abrir()
        {
            if (conectar.State == 0)
            {
                conectar.Open();
            }
        }

        public void cerrar()
        {
            if (conectar.State != 0)
            {
                conectar.Close();
            }
        }
    }
}
