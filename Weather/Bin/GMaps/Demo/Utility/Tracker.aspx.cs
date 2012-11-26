using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Tracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latLng = new GLatLng(40, 0);
            GMarker marker = new GMarker(latLng);
            marker.AddMarkerTracker();

            GMap1.Add(marker);

            GMap1.GCenter = latLng + new GLatLng(8, 8);
        }
    }
}