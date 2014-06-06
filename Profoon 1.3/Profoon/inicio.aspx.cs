using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Libreria.EN;
using Libreria.CAD;

namespace Profoon
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable da = ArticulosEN.llenar();
            DataList1.DataSource = da;
            DataList1.DataBind();
        }
    }
}