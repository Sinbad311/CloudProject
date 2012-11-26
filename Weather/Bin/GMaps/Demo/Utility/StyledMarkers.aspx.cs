using System;
using System.Drawing;
using Subgurim.Controles;
using Subgurim.Controles.Classes.UtilityLibrary;
using Subgurim.Controles.Classes.UtilityLibrary.Options;

namespace Demos.Utility
{
    public partial class StyledMarkers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latLng = new GLatLng(50, 10);
            GMap1.setCenter(latLng);

            GIcon icon = new GIcon();
            icon.image = "http://gmaps-samples.googlecode.com/svn/trunk/markers/circular/greencirclemarker.png";
            icon.iconSize = new GSize(32, 32);
            icon.iconAnchor = new GPoint(16, 16);
            icon.infoWindowAnchor = new GPoint(25, 7);

            

            StyledIconOptions iconOptions1 = new StyledIconOptions()
                                                {
                                                    Text = "Hi",
                                                    Color = Color.Blue,
                                                    Fore = Color.Red,
                                                    StarColor = Color.Green
                                                };

            StyledIcon icon1 = new StyledIcon(StyledIconType.Marker, iconOptions1);
            
            StyledMarker styledMarker1 = new StyledMarker(latLng, icon1);

            StyledIconOptions iconOptions2 = new StyledIconOptions()
                                                {
                                                    Text = "Hi, I'm a bubble!",
                                                    Color = Color.Orange,
                                                    Fore = Color.PaleGreen,
                                                };

            StyledIcon icon2 = new StyledIcon(StyledIconType.Bubble, iconOptions2);

            StyledMarker styledMarker2 = new StyledMarker(latLng + new GLatLng(1.0, 1.0), icon2);
            
            GInfoWindow window1 = new GInfoWindow(styledMarker1, "You can user StyledMarker as any other marker!");
            GInfoWindow window2 = new GInfoWindow(styledMarker2, "You can user StyledMarker as any other marker!");

            GMap1.Add(window1);
            GMap1.Add(window2);
        }
    }
}