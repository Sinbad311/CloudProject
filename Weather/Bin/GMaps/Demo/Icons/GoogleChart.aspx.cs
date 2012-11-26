using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;

namespace Demos.Icons
{
    public partial class GoogleChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlng = new GLatLng(41, -3.2);
            GMap1.setCenter(latlng, 5);

            PinLetter pinLetter = new PinLetter("A", Color.Yellow, Color.Black);
            XPinLetter xPinLetter = new XPinLetter(PinShapes.pin_star, "B", Color.Blue, Color.White, Color.Chocolate);
            PinIcon pinIcon = new PinIcon(PinIcons.home, Color.Cyan);
            XPinIcon xPinIcon = new XPinIcon(PinShapes.pin, PinIcons.home, Color.LightGreen, Color.BlueViolet);
            SPin sPin = new SPin(0.5, -10, Color.Green, 8, PinFontStyle.normal, "C");

            GMap1.Add(new GMarker(latlng, new GMarkerOptions(new GIcon(pinLetter.ToString(), pinLetter.Shadow()))));
            GMap1.Add(new GMarker(latlng + new GLatLng(2, 2), new GMarkerOptions(new GIcon(xPinLetter.ToString(), xPinLetter.Shadow()))));
            GMap1.Add(new GMarker(latlng + new GLatLng(2, -2), new GMarkerOptions(new GIcon(pinIcon.ToString(), pinIcon.Shadow()))));
            GMap1.Add(new GMarker(latlng + new GLatLng(-2, 2), new GMarkerOptions(new GIcon(xPinIcon.ToString(), xPinIcon.Shadow()))));

            GMap1.Add(new GMarker(latlng + new GLatLng(-2, -2), new GMarkerOptions(new GIcon(sPin.ToString()))));
        }
    }
}