using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Others
{
    public partial class Bounds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng sw = new GLatLng(40, 15);
            GLatLng ne = sw + new GLatLng(5, -10.2);
            GLatLngBounds latlngbounds = new GLatLngBounds(sw, ne);

            GMap1.Add(new GMarker(latlngbounds.getNorthEast()));
            GMap1.Add(new GMarker(latlngbounds.getSouthWest()));

            GMap1.GZoom = GMap1.getBoundsZoomLevel(latlngbounds);
            GMap1.setCenter(latlngbounds.getCenter());

            GLatLng sw2 = new GLatLng(42, 7);
            GLatLng ne2 = sw2 + new GLatLng(5, 5);
            GLatLngBounds latlngbounds2 = new GLatLngBounds(sw2, ne2);

            GLatLng swBig = new GLatLng(35, 0);
            GLatLng neBig = swBig + new GLatLng(15, 15);
            GLatLngBounds latlngboundsBig = new GLatLngBounds(swBig, neBig);

            GLatLng inside = latlngbounds.getCenter();
            GLatLng outside = neBig + new GLatLng(10, 10);

            bool isInside = latlngbounds.contains(inside);
            bool isOutSide = !latlngbounds.contains(outside);
            bool intersect = latlngbounds.intersects(latlngbounds2);
            bool contains = latlngboundsBig.containsBounds(latlngbounds); 
        }
    }
}