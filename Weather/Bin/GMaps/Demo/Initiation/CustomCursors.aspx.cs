using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Initiation
{
    public partial class CustomCursors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GCustomCursor customCursor = new GCustomCursor(cursor.crosshair, cursor.text);
            GMap1.Add(customCursor);
        }
    }
}