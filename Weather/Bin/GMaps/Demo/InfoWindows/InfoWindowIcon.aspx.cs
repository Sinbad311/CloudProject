using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.InfoWindows
{
    public partial class InfoWindowIcon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlon = new GLatLng(10.2, 22);
            GMap1.setCenter(latlon, 4);

            GMarker icono = new GMarker(latlon);

            GInfoWindow window = new GInfoWindow(icono, "Ejemplo de <b>infoWindow</b>", false, GListener.Event.mouseover);
            GMap1.Add(window);

            GPolygon polygon = new GPolygon();
            polygon.points.Add(new GLatLng(9, 25));
            polygon.points.Add(new GLatLng(3, 22));
            polygon.points.Add(new GLatLng(1, 26));
            polygon.close();

            GPolyline polyline = new GPolyline(polygon);

            GInfoWindow window2 = new GInfoWindow();
            //window2.gPolygon = polygon;
            //window2.html = "GPolygon";
            window2.gPolyline = polyline;
            window2.html = "polyline";

            window2.opened = true;
            window2.sourceEvent = GListener.Event.click;
            GMap1.Add(window2);
        }
    }
}