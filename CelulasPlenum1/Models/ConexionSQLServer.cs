using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CelulasPlenum1.Models
{
    public class ConexionSQLServer
    {
       private static string connectionString = "Data Source = LAPTOP-OL2HNRM1; Initial Catalog=CELULASPLENUM;" +
           "Integrated Security=True";
        

       public static SqlConnection conexion()
        {
            SqlConnection conectarbd = new SqlConnection(connectionString);
            return conectarbd;
        }


        
    }
}

