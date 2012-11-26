using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Clustered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(new GMapUI());
            GMap1.GZoom = 2;

            GMap2.Add(new GMapUI());
            GMap2.GZoom = 2;

            List<GMarker> markers = new List<GMarker>();

            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                GMarker gMarker = new GMarker(new GLatLng(r.Next(0, 60), r.Next(-30, 30)));
                markers.Add(gMarker);
                GListener listener = new GListener(gMarker.ID, GListener.Event.click, string.Format(@"function () {{ var w = new google.maps.InfoWindow(); w.setContent('<center>{0}</center>'); w.open({1}, {2});}}", i, GMap1.GMap_Id, gMarker.ID));
                GMap1.Add(listener);
            }

            GMap2.markerClusterer = new MarkerClusterer(markers);


            MarkerClustererStyleOptions markerClustererStyleOptions = new MarkerClustererStyleOptions();
            markerClustererStyleOptions.textColor = Color.Yellow;

            MarkerClustererOptions markerClustererOptions = new MarkerClustererOptions(60, 10);


            MarkerClustererStyleOptions styleOptionsA = new MarkerClustererStyleOptions();
            styleOptionsA.height = 36;
            styleOptionsA.width = 40;
            styleOptionsA.anchor_x = 6;
            styleOptionsA.anchor_y = 0;
            styleOptionsA.textColor = Color.Blue;
            styleOptionsA.url = "http://gmaps-utility-library.googlecode.com/svn/trunk/markerclusterer/1.0/images/conv40.png";

            MarkerClustererStyleOptions styleOptionsB = new MarkerClustererStyleOptions();
            styleOptionsB.height = 35;
            styleOptionsB.width = 35;
            styleOptionsB.anchor_x = 16;
            styleOptionsB.anchor_y = 0;
            styleOptionsB.textColor = Color.WhiteSmoke;
            styleOptionsB.url = "http://gmaps-utility-library.googlecode.com/svn/trunk/markerclusterer/1.0/images/people35.png";




            markerClustererOptions.markerClustererStylesOptions.Add(styleOptionsA);
            markerClustererOptions.markerClustererStylesOptions.Add(styleOptionsB);


            MarkerClusterer markerClusterer = new MarkerClusterer(markers, markerClustererOptions);

            GMap1.markerClusterer = markerClusterer;
        }
    }
}