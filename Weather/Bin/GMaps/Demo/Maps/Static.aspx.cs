using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Maps
{
    public partial class Static : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latLng = new GLatLng(41, -7);

            int colorEnumLength = 11;
            int sizeEnumLength = 3;
            double latStep = -1;
            double lngStep = 0.4;
            string msg = "Subgurim Google Maps";

            int iLat = 0;
            int iLng = 0;

            Random r = new Random();
            foreach (char c in msg)
            {
                if (c == ' ')
                {
                    iLat++;
                    continue;
                }

                GLatLng latlngAux = latLng + new GLatLng(latStep * iLat + r.NextDouble() * 0.4, lngStep * iLng);

                int randomColor = r.Next(colorEnumLength);
                StaticGMarker.ColorEnum color = (StaticGMarker.ColorEnum)randomColor;

                int randomSize = r.Next(2, sizeEnumLength);
                StaticGMarker.SizeEnum size = (StaticGMarker.SizeEnum)randomSize;

                StaticGMarker staticGMarker = new StaticGMarker(latlngAux, size, color, c);
                StaticGMap1.addStaticGMarker(staticGMarker);

                iLng++;
            }

            //StaticGMap1.GZoom = 5; 

            StaticPath path = new StaticPath();
            path.colorNet = Color.FromArgb(255, 0, 80);
            path.weight = 5;
            path.alpha = 150;

            path.points.Add(new GLatLng(41, -5));
            path.points.Add(new GLatLng(41, -4));
            path.points.Add(new GLatLng(40, -4));
            path.points.Add(new GLatLng(39, -2));

            StaticGMap1.addStaticPath(path);
        }
    }
}