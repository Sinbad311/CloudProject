using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Subgurim.Controles;

namespace Demos.Initiation
{
    public partial class Basics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.enableDragging = false;
            GMap1.enableGoogleBar = true;
            GMap1.Language = "es";
            GMap1.BackColor = Color.White;
        }
    }
}