using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class Lines : System.Web.UI.Page
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
            GPolyline linea = new GPolyline(puntos, "FF0000", 2);
            GMap1.Add(linea);

            List<GLatLng> puntos2 = new List<GLatLng>();
            puntos2.Add(latlng + new GLatLng(5, -8));
            puntos2.Add(latlng + new GLatLng(5, -6));
            puntos2.Add(latlng + new GLatLng(5, -4));
            puntos2.Add(latlng);
            puntos2.Add(latlng + new GLatLng(-5, 0));
            GPolyline linea2 = new GPolyline(puntos2);
            linea2.weight = 4;
            GMap1.Add(linea2);

            List<GLatLng> puntos3 = new List<GLatLng>();
            puntos3.Add(latlng + new GLatLng(5, -20));
            puntos3.Add(latlng + new GLatLng(5, 20));
            GPolyline linea3 = new GPolyline(puntos3, Color.DarkViolet, 4);
            linea3.geodesic = true;
            GMap1.Add(linea3);
        }
    }
}