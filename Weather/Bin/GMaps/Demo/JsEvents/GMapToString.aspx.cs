using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class GMapToString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GMap1_Click(object s, Subgurim.Controles.GAjaxServerEventArgs e)
        {
            GMap gmap = new GMap(e.map);

            // GMarker and GInfoWindow
            GMarker marker = new GMarker(e.point);
            GInfoWindow window = new GInfoWindow(marker, "Cool!!", true);
            gmap.Add(window);

            // Movement
            //gmap.addMovement(1000, e.point + new GLatLng(25, 38));
            //gmap.addMovement(1000, e.point);

            // Polylines
            if (e.point != e.center)
            {
                List<GLatLng> points = new List<GLatLng>();
                points.Add(e.center);
                points.Add(e.point);

                gmap.Add(new GPolyline(points, Color.Yellow));
            }

            // Controls
            gmap.Add(new GControl(GControl.extraBuilt.MarkCenter));
            gmap.Add(new GControl(GControl.preBuilt.LargeMapControl));
            gmap.Add(new GControl(GControl.preBuilt.MapTypeControl));

            // Maybe... anything? ;)
            gmap.enableHookMouseWheelToZoom = false;
            gmap.mapType = GMapType.GTypes.Satellite;

            return gmap.ToString();
        }
    }
}