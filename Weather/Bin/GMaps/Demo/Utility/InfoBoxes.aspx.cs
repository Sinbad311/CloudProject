using System;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class InfoBoxes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMarker marker = new GMarker(new GLatLng(35.68, 139.69));

            InfoBoxOptions options = new InfoBoxOptions();

            options.PixelOffset = new GSize(-140, 0);
            options.BoxStyle = "{ opacity: 0.75, width: '280px' }";

            InfoBox infoBox = new InfoBox(marker, "<div class=\"box\">I'm an info box!</div>", true, options);

            GMap1.Add(new GControl(GControl.preBuilt.ScaleControl));

            GMap1.setCenter(new GLatLng(35.68, 139.69));

            GMap1.Add(infoBox);
        }
    }
}