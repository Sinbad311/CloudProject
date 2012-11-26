using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.InfoWindows
{
    public partial class InfoWindowBasic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlon = new GLatLng(10.2, 22);
            GMap1.setCenter(latlon, 4);

            GInfoWindow window = new GInfoWindow(latlon, "Ejemplo de <b>infoWindow</b>");
            GMap1.Add(window);
        }
    }
}