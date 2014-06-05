using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libreria.EN;

namespace Profoon
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected ClientesEN cliente = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton2.Visible = false;
            ImageButton1.Visible = false;
            sinlog.Visible = false;
            conlog.Visible = false;
            if ((ClientesEN)Session["Cliente"] != null)
            {
                cliente = (ClientesEN)Session["Cliente"];
                sinlog.Visible = false;
                conlog.Visible = true;
                ImageButton2.Visible = true;
                ImageButton1.Visible = false;

            }
            else
            {
                sinlog.Visible = true;
                conlog.Visible = false;
                ImageButton2.Visible = false;
                ImageButton1.Visible = true;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Loguearse.aspx");
        }

    }
}
