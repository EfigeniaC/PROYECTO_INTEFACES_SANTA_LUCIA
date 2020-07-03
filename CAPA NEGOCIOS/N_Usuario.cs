using CAPA_DATOS;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class N_Usuario
    {
        #region "patron Singleton"
        private static N_Usuario objUsuario = null;
        private N_Usuario() { }
        public static N_Usuario getInstance()
        {
            if (objUsuario == null)
            {
                objUsuario = new N_Usuario();
            }
            return objUsuario;
        }
        #endregion 

        public E_Users AccesoSistema(String user, String pass)
        {
            try
            {
                return D_Usuario.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
