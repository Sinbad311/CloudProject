using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class StreetView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(35.014975, 135.782479), 17);

            ExtStreetViewControl extStreetViewControl = new ExtStreetViewControl();
            //extStreetViewControl.controlStatus = ExtStreetViewControl.ControlStatusEnum.MINI; 
            //extStreetViewControl.hidden = true; 
            //extStreetViewControl.latlng = new GLatLng(35, 135.7); 
            extStreetViewControl.mainContent = ExtStreetViewControl.MainContentEnum.STREETVIEW;
            //extStreetViewControl.pov = new GPov(1, 1, 1); 
            extStreetViewControl.size = new GSize(200, 150);

            GMarker marker = new GMarker(new GLatLng(35.014975, 135.782479));
            extStreetViewControl.marker = marker;

            GMap1.Add(new GControl(extStreetViewControl));
        }
    }
}