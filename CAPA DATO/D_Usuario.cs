using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
    public class D_Usuario
    {

        private static D_Usuario daoUsuario = null;
        private D_Usuario() { }
        public static D_Usuario getInstance()
        {
            if(daoUsuario == null)
            {
                daoUsuario = new D_Usuario();
            }
            return daoUsuario;
        }
        public E_Users AccesoSistema(String user, String pass)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            E_Users objUsuario = null;
            SqlDataReader dr = null;
            try 
            {
                cn = D_conexion.getInstance().ConxionBD();
                cmd = new SqlCommand("SELUSUSUARIO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new E_Users();
                    objUsuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                    objUsuario.usuario = dr["usuario"].ToString();
                    objUsuario.pass = dr["pass"].ToString();
                }

            }
            catch (Exception e)
            {
                objUsuario = null;
                throw e;
            }
            finally
            {
                cn.Close();
            }
            return objUsuario;
        }
        
    }
}
