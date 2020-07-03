using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CAPA_DATOS
{
    public class D_conexion
    {
        private static D_conexion conexion = null;
        private D_conexion() { }
        public static D_conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new D_conexion();
            }
            return conexion;
        }

        public SqlConnection ConxionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source =DESKTOP-3GC35CO\\EFI_SERVER; Initial Catalog=Bd_Login; User ID=sa; Password=sa";
            return conexion;
        }

    }
}
