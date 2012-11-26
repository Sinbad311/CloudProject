using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Marker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latLng = new GLatLng(50, 10);
            GMap1.setCenter(latLng);

            GIcon icon = new GIcon();
            icon.image = "http://gmaps-samples.googlecode.com/svn/trunk/markers/circular/greencirclemarker.png";
            icon.iconSize = new GSize(32, 32);
            icon.iconAnchor = new GPoint(16, 16);
            icon.infoWindowAnchor = new GPoint(25, 7);

            LabeledMarker labeledMarker = new LabeledMarker(latLng);
            labeledMarker.options.labelText = "S";
            labeledMarker.options.labelOffset = new GSize(-4, -7);
            labeledMarker.options.icon = icon;

            GInfoWindow window = new GInfoWindow(labeledMarker, "You can use the Labeled Marker as any other marker");
            GMap1.Add(window);
        }
    }
}