using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Others
{
    public partial class PostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(new GControl(GControl.preBuilt.LargeMapControl));
            GMap1.Add(new GControl(GControl.preBuilt.MapTypeControl));

            GLatLng latlng = new GLatLng(42.12, -1.145);

            if (!Page.IsPostBack)
            {
                GMap1.setCenter(latlng, 5, GMapType.GTypes.Hybrid);
            }

            GMap1.Add(new GMarker(latlng + new GLatLng(2, 1)));
        }
    }
}