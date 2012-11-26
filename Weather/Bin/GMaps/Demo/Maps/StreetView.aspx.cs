using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Maps
{
    public partial class StreetView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GStreetviewPanorama1.StreetviewPanoramaOptions = new GStreetviewPanoramaOptions(new GPov(-180, -15, 1));

            GStreetviewListener zoomlistener = new GStreetviewListener(
                GStreetviewPanorama1.GMap_Id,
                GStreetviewListener.Event.zoomchanged,
                "function() { var pov = this.getPov(); writeMessage('Zoom changed to ' + pov.zoom); }");

            GStreetviewListener yawlistener = new GStreetviewListener(
                GStreetviewPanorama1.GMap_Id,
                GStreetviewListener.Event.yawchanged,
                "function() { var pov = this.getPov(); writeMessage('Heading changed to ' + pov.heading); }");

            GStreetviewListener pitchlistener = new GStreetviewListener(
                GStreetviewPanorama1.GMap_Id,
                GStreetviewListener.Event.pitchchanged,
                "function() { var pov = this.getPov(); writeMessage('Pitch changed to ' + pov.pitch); }");

            GStreetviewListener positionListener = new GStreetviewListener(
                GStreetviewPanorama1.GMap_Id,
                GStreetviewListener.Event.positionchanged,
                "function() { var pos = this.getPosition(); writeMessage('Position changed to ' + pos.lat() + ',' + pos.lng()); }");

            GStreetviewPanorama1.Add(yawlistener);
            GStreetviewPanorama1.Add(pitchlistener);
            GStreetviewPanorama1.Add(zoomlistener);
            GStreetviewPanorama1.Add(positionListener);
        }
    }
}