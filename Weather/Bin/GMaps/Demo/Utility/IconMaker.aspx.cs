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
    public partial class IconMaker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latLng = new GLatLng(50, 10);
            GMap1.setCenter(latLng, 4);

            GIcon icon = new GIcon();
            icon.markerIconOptions = new MarkerIconOptions(50, 50, Color.Blue);
            GMarker marker = new GMarker(latLng, icon);
            GInfoWindow window = new GInfoWindow(marker, "You can use the Map Icon Maker as any other marker");
            GMap1.Add(window);

            GIcon icon2 = new GIcon();
            icon2.labeledMarkerIconOptions = new LabeledMarkerIconOptions(Color.Gold, Color.White, "A", Color.Green);
            GMarker marker2 = new GMarker(latLng + new GLatLng(3, 3), icon2);
            GInfoWindow window2 = new GInfoWindow(marker2, "You can use the Map Icon Maker as any other marker");
            GMap1.Add(window2);

            GIcon icon3 = new GIcon();
            icon3.flatIconOptions = new FlatIconOptions(25, 25, Color.Red, Color.Black, "B", Color.White, 15,
                                                        FlatIconOptions.flatIconShapeEnum.roundedrect);
            GMarker marker3 = new GMarker(latLng + new GLatLng(-3, -3), icon3);
            GInfoWindow window3 = new GInfoWindow(marker3, "You can use the Map Icon Maker as any other marker");
            GMap1.Add(window3);
        }
    }
}