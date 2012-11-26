using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.InfoWindows
{
    public partial class MapBlowUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlon = new GLatLng(41.65, 0.91);
            GMap1.setCenter(latlon, 4);

            GInfoWindowOptions options = new GInfoWindowOptions();
            options.zoomLevel = 14;
            options.mapType = GMapType.GTypes.Hybrid;

            GShowMapBlowUp mBlowUp = new GShowMapBlowUp(new GMarker(latlon), options);

            GMap1.Add(mBlowUp);
        }
    }
}