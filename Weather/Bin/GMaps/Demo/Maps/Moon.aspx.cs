using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Maps
{
    public partial class Moon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMoonMap1.Add(new GControl(GControl.preBuilt.MapTypeControl));
        }
    }
}