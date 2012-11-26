using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Directions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GDirection gdirection = new GDirection(true);
            gdirection.errorMessage = "Ups";
            GMap1.Add(gdirection);
        }
    }
}