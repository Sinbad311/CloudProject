using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demos.Initiation
{
    public partial class Zoom2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Both properties are enabled by default, to disable:
            // GMap1.enableContinuousZoom = false; 
            // GMap1.enableDoubleClickZoom = false; 
            GMap1.enableHookMouseWheelToZoom = true;
        }
    }
}