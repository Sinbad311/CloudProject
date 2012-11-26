using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class Polygons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlng = new GLatLng(46, 21);
            GMap1.setCenter(latlng, 4);

            List<GLatLng> puntos = new List<GLatLng>();
            puntos.Add(latlng + new GLatLng(0, 8));
            puntos.Add(latlng + new GLatLng(-0.5, 4.2));
            puntos.Add(latlng);
            puntos.Add(latlng + new GLatLng(3.5, -4));
            puntos.Add(latlng + new GLatLng(4.79, +2.6));
            GPolygon poligono = new GPolygon(puntos, "557799", 3, 0.5, "237464", 0.5);
            poligono.close();
            GMap1.Add(poligono);

            List<GLatLng> puntos2 = new List<GLatLng>();
            puntos2.Add(latlng + new GLatLng(5, -8));
            puntos2.Add(latlng + new GLatLng(5, -6));
            puntos2.Add(latlng + new GLatLng(5, -4));
            puntos2.Add(latlng);
            puntos2.Add(latlng + new GLatLng(-5, 0));
            GPolygon poligono2 = new GPolygon(puntos2, "000000", 3, 1, "654321", 1);
            GMap1.Add(poligono2);

            GPolygon poligono3 = new GPolygon(new List<GLatLng>(), "00ff00", 3, 1, "ff0044", 1);
            poligono3.createPolygon(latlng + new GLatLng(-6, -7.5), 7, 4, Math.PI / 3);
            GMap1.Add(poligono3);
        }
    }
}