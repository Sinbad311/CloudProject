using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Maps
{
    public partial class Mars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMarsMap1.Add(new GControl(GControl.preBuilt.MapTypeControl));
        }
    }
}