using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class ScreenOverlay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng sw = new GLatLng(64, 20);
            GLatLng ne = new GLatLng(65, 29);

            GMap1.setCenter((sw / 2) + (ne / 2));

            GScreenOverlay screenOverlay = new GScreenOverlay("http://googlemaps.subgurim.net/images/logo.jpg",
                                                              new GScreenPoint(0, 21, unitEnum.pixels, unitEnum.pixels),
                                                              new GScreenPoint(0, 0),
                                                              new GScreenSize(0, 0));

            GMap1.Add(screenOverlay);
        }
    }
}