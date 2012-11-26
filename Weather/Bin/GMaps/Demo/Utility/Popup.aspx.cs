using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;

namespace Demos.Utility
{
    public partial class Popup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopupMarker popupMarkerA = new PopupMarker(new GLatLng(39, -7), "Answer to the Ultimate Question of Life, the Universe, and Everything");

            PopupMarkerOptions popupMarkerOptionsB = new PopupMarkerOptions(Color.WhiteSmoke, Color.DarkRed);
            PopupMarker popupMarkerB = new PopupMarker(new GLatLng(42, -5), "Maecenas a diam lectus.", popupMarkerOptionsB);

            PopupMarkerChartAPIOptions popupMarkerChartApiOptionsC = new PopupMarkerChartAPIOptions(Color.LightGreen, Color.Black, PopupMarkerChartAPIOptions.ChartStyleEnum.d_bubble_icon_text_small, PinIcons.taxi);
            PopupMarkerOptions popupMarkerOptionsC = new PopupMarkerOptions(PopupMarkerOptions.PopupMarkerOptionsStylesEnum.chart, popupMarkerChartApiOptionsC);
            popupMarkerOptionsC.draggable = true;
            PopupMarker popupMarkerC = new PopupMarker(new GLatLng(40, -4), "Hi! Drag me.", popupMarkerOptionsC);

            GInfoWindow infoWindowA = new GInfoWindow(popupMarkerA, "42 is the answer.");

            GMap1.Add(infoWindowA);
            GMap1.Add(popupMarkerB);
            GMap1.Add(popupMarkerC);
        }
    }
}