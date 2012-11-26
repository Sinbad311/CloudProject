using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlng = new GLatLng(41, -3.2);
            GMap1.setCenter(latlng, 5, GMapType.GTypes.Satellite);

            GMarkerOptions mOpts = new GMarkerOptions();
            mOpts.draggable = true;
            GMarker marker = new GMarker(latlng, mOpts);
            GMap1.Add(marker);
            GListener listener = new GListener(marker.ID, GListener.Event.dragend, "alertame");
            GMap1.Add(listener);

            GMarker mkr = new GMarker();
            mkr.options = mOpts;
            mkr.javascript_GLatLng = "mouseEvent.latLng";
            listener = new GListener(mkr.ID, GListener.Event.dragend, "alertame");
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("function(mouseEvent) {");
            sb.Append(mkr.ToString(GMap1.GMap_Id));
            sb.Append(listener.ToString());
            sb.Append("}");

            GListener listener2 = new GListener(GMap1.GMap_Id, GListener.Event.click, sb.ToString());
            GMap1.Add(listener2);

            GMap1.Add(new GListener(GMap1.GMap_Id, GListener.Event.moveend, "function() {alert('I Love Elvis :9P');}"));

            GPolygon polygon = new GPolygon();
            polygon.Add(latlng + new GLatLng(1, 1));
            polygon.Add(latlng + new GLatLng(2, 3));
            polygon.Add(latlng + new GLatLng(4, 4));
            polygon.close();
            GMap1.Add(polygon);

            GListener listener3 = new GListener(polygon.PolygonID, GListener.Event.click, "function(mouseEvent) {alert('Polygon clicked');}");
            GMap1.Add(listener3);
        }
    }
}