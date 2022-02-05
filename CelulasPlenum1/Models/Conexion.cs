using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelulasPlenum1.Models
{
    public class Conexion
    {
        public static MySqlConnection conexion()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=celulas;SslMode=none;";

            try
            {

                MySqlConnection conexcionBD = new MySqlConnection(connectionString);

                return conexcionBD;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
    }
}
