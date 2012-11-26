using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Others
{
    public partial class GenericAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng ll1 = new GLatLng(41, 1);
            GLatLng ll2 = new GLatLng(39, 0);

            GMap1.Add(new GControl(GControl.preBuilt.SmallMapControl));
            GMap1.Add(new GCustomCursor(cursor.crosshair, cursor.help));
            GMap1.Add(new GControl(GControl.extraBuilt.TextualOnClickCoordinatesControl, new GControlPosition(GControlPosition.position.Top_Right)));
            GMap1.Add(new GInfoWindow(ll1, "Hello!!"));
            GMap1.Add(new GMove(1500, ll2));
            GMap1.Add(new GMove(2000, ll1));
            GMap1.Add(new GeoCoding());
        }
    }
}