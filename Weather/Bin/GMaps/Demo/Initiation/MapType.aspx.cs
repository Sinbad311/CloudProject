using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Initiation
{
    public partial class MapType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(37.339085, -121.8914807), 18);
            GMap1.mapType = GMapType.GTypes.Hybrid;
            GMap1.Add(GMapType.GTypes.Physical);
            GMap1.Add(new GControl(GControl.preBuilt.MapTypeControl));
            GMap1.enableRotation = true;
        }
    }
}