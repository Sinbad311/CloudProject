using System;
using System.Collections.Generic;
using System.Drawing;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class ClusteredPlus : System.Web.UI.Page
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

            GMap2.markerClusterer = new MarkerClustererPlus(markers);
            
            MarkerClustererPlusStyleOptions markerClustererStyleOptions = new MarkerClustererPlusStyleOptions();
            markerClustererStyleOptions.textColor = Color.Yellow;

            MarkerClustererPlusOptions markerClustererOptions = new MarkerClustererPlusOptions(60, 10);
            
            MarkerClustererPlusStyleOptions styleOptionsA = new MarkerClustererPlusStyleOptions();
            styleOptionsA.height = 36;
            styleOptionsA.width = 40;
            styleOptionsA.anchor_x = 6;
            styleOptionsA.anchor_y = 0;
            styleOptionsA.textColor = Color.Blue;
            styleOptionsA.FontFamily = "Verdana";
            styleOptionsA.url = "http://gmaps-utility-library.googlecode.com/svn/trunk/markerclusterer/1.0/images/conv40.png";

            MarkerClustererPlusStyleOptions styleOptionsB = new MarkerClustererPlusStyleOptions();
            styleOptionsB.height = 35;
            styleOptionsB.width = 35;
            styleOptionsB.anchor_x = 16;
            styleOptionsB.anchor_y = 0;
            styleOptionsB.textColor = Color.WhiteSmoke;
            styleOptionsB.TextDecoration = "underline";
            styleOptionsB.url = "http://gmaps-utility-library.googlecode.com/svn/trunk/markerclusterer/1.0/images/people35.png";
            
            markerClustererOptions.markerClustererStylesOptions.Add(styleOptionsA);
            markerClustererOptions.markerClustererStylesOptions.Add(styleOptionsB);

            markerClustererOptions.Title = "Using Clusterer Plus";

            MarkerClustererPlus markerClusterer = new MarkerClustererPlus(markers, markerClustererOptions);

            GMap1.markerClusterer = markerClusterer;
        }
    }
}