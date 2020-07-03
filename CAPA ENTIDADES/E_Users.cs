using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_Users
    {
        public int idUsuario { get; set; }
        public String usuario { get; set; }
        public String pass { get; set; }

        public E_Users() { }

        public E_Users(int idUsuario, String usuario, String pass)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.pass = pass;
        }
    }
}
