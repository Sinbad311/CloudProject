using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class Extras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GControl control = new GControl(GControl.extraBuilt.NumericalZoomControl);
            GMap1.Add(control);

            GMap1.Add(new GControl(GControl.extraBuilt.TextualCoordinatesControl, new GControlPosition(GControlPosition.position.Top_Right)));
            GMap1.Add(new GControl(GControl.extraBuilt.TextualOnClickCoordinatesControl, new GControlPosition(GControlPosition.position.Bottom_Right)));
        }
    }
}