using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Inverse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.arreglarMapa();
            }
        }

        private void arreglarMapa()
        {
            GMap1.Add(new GControl(GControl.preBuilt.LargeMapControl));
            GMap1.enableHookMouseWheelToZoom = true;

            StringBuilder sb = new StringBuilder();
            sb.Append("function(marker, point) {");
            GLatLng latlng = new GLatLng("point");
            GInfoWindow window = new GInfoWindow(latlng, "<div style=\"height:140px;\"><blink>Loading...</blink></div>");
            sb.Append(window.ToString(GMap1.GMap_Id));
            sb.Append("}");

            GMap1.Add(new GListener(GMap1.GMap_Id, GListener.Event.click, sb.ToString()));

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("function goTo(point){");
            GLatLng point = new GLatLng("point");
            sb2.AppendFormat("{0}.setZoom(11);", GMap1.GMap_Id);
            GMove move = new GMove(1, point);
            sb2.Append(move.ToString(GMap1.GMap_Id));
            GMarker marker = new GMarker(point);
            sb2.Append(marker.ToString(GMap1.GMap_Id));
            sb2.Append("}");
            GMap1.Add(sb2.ToString());
        }

        protected string GMap1_Click(object s, GAjaxServerEventArgs e)
        {
            inverseGeocodingManager igeoManager = new inverseGeocodingManager(e.point, "es");
            inverseGeocoding iGeos = igeoManager.inverseGeoCodeRequest();
            geoName geo;
            if (iGeos.geonames.Count > 0)
            {
                geo = iGeos.geonames[0];

                StringBuilder sb = new StringBuilder();
                sb.Append("<div align=\"left\">");
                sb.Append("<b>Nearest Place</b>");
                sb.Append("<br />");
                sb.AppendFormat("Place name: <i>{0}</i> ", geo.name);
                sb.Append("<br />");
                sb.AppendFormat("Point: <i>{0}</i>", geo.nearestPlacePoint.ToString());
                sb.Append("<br />");
                sb.AppendFormat("Elevation: <i>{0}</i>", geo.nearestPlaceElevation > -9000 ? geo.nearestPlaceElevation.ToString() : "No info");
                sb.Append("<br />");
                sb.AppendFormat("Country Name (Code): <i>{0} ({1})</i>", geo.countryName, geo.countryCode);
                sb.Append("<br />");
                sb.AppendFormat("Click point - Nearest Place distance (Km): <i>{0}</i>", Math.Round(geo.distance, 3));
                sb.Append("</div>");

                sb.Append("<br />");
                sb.Append("<div align=\"left\">");
                sb.Append("<b>Click point</b>");
                sb.Append("<br />");
                sb.AppendFormat("Point: <i>{0}</i>", geo.initialPoint.ToString());
                sb.Append("<br />");
                sb.AppendFormat("Elevation: <i>{0}</i>", geo.initialPointElevation > -9000 ? geo.initialPointElevation.ToString() : "No info");
                sb.Append("<br />");
                sb.Append("</div>");

                GInfoWindow window = new GInfoWindow(e.point, sb.ToString(), true);
                return window.ToString(e.map);
            }
            else return string.Empty;
        }
    }
}