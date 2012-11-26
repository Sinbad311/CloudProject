using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.InfoWindows
{
    public partial class InfoWindowOptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlng = new GLatLng(44, 9);
            GLatLng relativo = new GLatLng(2, -6);
            GMarker marker1 = new GMarker(latlng + relativo);
            GMarker marker2 = new GMarker(latlng - relativo);
            GMarker marker3 = new GMarker(latlng + relativo + relativo);

            GMap1.setCenter(latlng, 4, GMapType.GTypes.Hybrid);

            GInfoWindow window = new GInfoWindow(latlng, "InfoWindow. Close me please.");
            GInfoWindowOptions options1 = new GInfoWindowOptions();
            options1.onCloseFn = "function(){alert('Thanks! You have closed me ;D')}";
            window.options = options1;
            GMap1.Add(window);
        }
    }
}