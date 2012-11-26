using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Basic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This commented line is enough to make it work!!!
            // GMap1.addGeoCode(new GeoCoding());

            GMap1.GZoom = 9;
            GMap1.Add(new GControl(GControl.preBuilt.LargeMapControl));

            GeoCoding geoCoding = new GeoCoding();
            
            geoCoding.show = GeoCoding.ShowEnum.infowindow;
            geoCoding.openedOnLoad = true;
            geoCoding.errorText = "No tá";
            geoCoding.buttonText = "Buscar";
            geoCoding.infoText = "Buscar GeoCode";

            GMap1.Add(geoCoding);
        }
    }
}