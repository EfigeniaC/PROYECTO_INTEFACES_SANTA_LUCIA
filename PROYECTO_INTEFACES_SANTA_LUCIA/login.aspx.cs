using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class login : System.Web.UI.Page
    {
        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            E_Users objUsuario = N_Usuario.getInstance().AccesoSistema(txtUsers.Text, txtpass.Text);
            if (objUsuario != null)
            {
                Response.Write("<script>alert('USUARIO CORRECTO')</script>");
                Response.Redirect("PanelGeneral.aspx");
            }
            else
            {
                Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            }
            #region "Prueba"
            //string User = txtUsers.Text;
            //string pass = txtpass.Text;
            //string userName = "jose";
            //string passName = "123";
            //if(User.Equals(userName)&& pass.Equals(passName))
            //{
            //    Response.Write("<script>alert('USUARIO CORRECTO')</script>");
            //}
            //else
            //{
            //    Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            //}
            #endregion

        }

    }
}