using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace trabajoooao
{
    internal class sql
    {
        SqlConnection coneccion = new SqlConnection("PINEDA\\SQLEXPRESS01;database=empresa; integrated security=true ");
    }
}
