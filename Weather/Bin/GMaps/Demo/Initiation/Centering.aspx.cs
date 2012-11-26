using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Initiation
{
    public partial class Centering : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlong = new GLatLng(15.2, 10.9);
            GMapType.GTypes maptype = GMapType.GTypes.Hybrid;
            //GMap1.setCenter(latlong);
            //GMap1.setCenter(latlong, 4);
            GMap1.setCenter(latlong, 4, maptype);

            GMap1.Add(new GControl(GControl.extraBuilt.TextualCoordinatesControl));
        }
    }
}