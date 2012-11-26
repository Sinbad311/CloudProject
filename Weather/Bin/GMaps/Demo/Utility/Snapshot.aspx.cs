using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Snapshot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(new GMarker(new GLatLng(40, 0)));

            SnapShotControl snapShotControl = new SnapShotControl();
            //snapShotControl.buttonLabelHtml = "Take a photo!"; 
            //snapShotControl.format = SnapShotControl.SnapShotControlImageFormatEnum.jpg; 
            //snapShotControl.hidden = true; 
            //snapShotControl.language = "es"; 
            //snapShotControl.maptype = SnapShotControl.SnapShotControlValidMapTypesEnum.satellite; 
            //snapShotControl.useAutoDetectMarker = false; 
            //snapShotControl.usePolylineEncode = true; 


            GMap1.Add(new GControl(snapShotControl));
        }
    }
}