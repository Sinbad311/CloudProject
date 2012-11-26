using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Snap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Height = 500;

            GLatLng latlng = new GLatLng(46, 21);
            GMap1.setCenter(latlng, 4);

            List<GLatLng> points = new List<GLatLng>();
            points.Add(latlng + new GLatLng(0, 8));
            points.Add(latlng + new GLatLng(-0.5, 4.2));
            points.Add(latlng);
            points.Add(latlng + new GLatLng(3.5, -4));
            points.Add(latlng + new GLatLng(4.79, +2.6));
            GPolyline line = new GPolyline(points, "FF0000", 2);
            GMap1.Add(line);


            GMarker marker = new GMarker(latlng);
            GMap1.Add(marker);


            GInfoWindowOptions options = new GInfoWindowOptions();
            options.zoomLevel = 14;
            options.mapType = GMapType.GTypes.Hybrid;
            GShowMapBlowUp mBlowUp = new GShowMapBlowUp(new GLatLng(string.Format("{0}.getLatLng()", marker.ID)), options);


            GListener listener = new GListener(GMap1.GMap_Id, GListener.Event.click, string.Format(@"function(){{{0};}}", mBlowUp.ToString(GMap1.GMap_Id)));

            GMap1.Add(listener);

            GMap1.Add(new SnapToToute(marker, line));
        }
    }
}