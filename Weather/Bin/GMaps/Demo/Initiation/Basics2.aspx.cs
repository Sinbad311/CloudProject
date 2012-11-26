using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Subgurim.Controles;

namespace Demos.Initiation
{
    public partial class Basics2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(41, 2), 6);

            GMap2.Height = 456;
            GMap2.Width = 300;
            GMap2.setCenter(new GLatLng(20, 15), 2);
        }
    }
}