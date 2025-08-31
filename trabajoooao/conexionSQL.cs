using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoooao

{
    public static class CONEXION_SQL
    {
        public static MySqlConnection conectarSQL()
        {
            string connectionString = "SERVER=193.203.175.250;PORT=3306;DATABASE=u700978481_basepineda;UID=u700978481_pineda;PWD=Pineda123456*";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open(); 
             return connection;
        }
    }
}

