using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libreria.EN;
using Libreria.CAD;

namespace Profoon
{
    public partial class Loguearse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
  
                bool clienteesta = ClientesEN.clienteesta(UserName.Text, Password.Text);

                 if (!clienteesta)
                     throw new Exception("El usuario no existe con esa contraseña");
                 else
                 {
                     Session["Cliente"] = ClientesEN.clientelogueado(UserName.Text);

                     Response.Redirect("inicio.aspx");
                 }

    
        }
    }
}