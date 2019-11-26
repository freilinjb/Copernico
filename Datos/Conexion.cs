using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DTRN4IK\endy2;Initial Catalog=Matriz;Integrated Security=True");
    }
}
