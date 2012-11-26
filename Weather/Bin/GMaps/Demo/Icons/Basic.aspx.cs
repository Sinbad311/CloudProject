using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Icons
{
    public partial class Basic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlng = new GLatLng(42.12, -1.145);
            GMap1.setCenter(latlng, 5, GMapType.GTypes.Hybrid);

            GMarker marker = new GMarker(latlng);
            GInfoWindowOptions windowOptions = new GInfoWindowOptions(12, GMapType.GTypes.Normal);
            //GShowMapBlowUp mbUp = new GShowMapBlowUp(marker, false, IWoptions);
            //GMap1.addShowMapBlowUp(mbUp);
            GInfoWindow mbUp = new GInfoWindow(marker, "I'm an infoWindow", windowOptions);
            GMap1.Add(mbUp);

            GMap1.Add(new GMarker(latlng + new GLatLng(2, 1)));

            GMarkerOptions markerOptions = new GMarkerOptions();
            markerOptions.clickable = false;
            GMarker marker2 = new GMarker(latlng + new GLatLng(-1, 2.5), markerOptions);
            GMap1.Add(marker2);

            GMarker markerDraggable = new GMarker(latlng + new GLatLng(-2, -1));
            GMarkerOptions mOpts = new GMarkerOptions();
            mOpts.draggable = true;
            markerDraggable.options = mOpts;
            // string jsStart = "function() {" + GMap1.GMap_Id + ".closeInfoWindow();}";
            // string jsEnd = "function() {" + markerDraggable.ID + ".openInfoWindowHtml('<a href=\"http://www.playsudoku.biz\" target=\"_blank\">Play Sudoku</a>');}";
            string jsStart = "function() { if (myInfoWindow) {myInfoWindow.close(); } }";
            string jsEnd = "function() { myInfoWindow = new google.maps.InfoWindow({ content: '<a href=\"http://www.playsudoku.biz\" target=\"_blank\">Play Sudoku</a>' }); myInfoWindow.open(" + GMap1.GMap_Id + "," + markerDraggable.ID + "); }";
            GMap1.Add(new GListener(markerDraggable.ID, GListener.Event.dragstart, jsStart));
            GMap1.Add(new GListener(markerDraggable.ID, GListener.Event.dragend, jsEnd));
            GMap1.Add(markerDraggable);
        }
    }
}