using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class CustomInside : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            GLatLng center = new GLatLng(44, 5);
            GMap1.setCenter(center, 8);

            //GMap1.Add("addRandom();", true);
            GMap1.Add("addRandom();", true);

            sb.Append("var max = 10;");
            sb.Append("function addRandom()");
            sb.Append("{");
            GMarker marker = new GMarker(
            string.Format("new google.maps.LatLng({0}.getCenter().lat() + Math.random() - 0.5, {0}.getCenter().lng() + Math.random() - 0.5)", GMap1.GMap_Id));
            sb.Append(marker.ToString(GMap1.GMap_Id));
            sb.Append("if (max-- > 0)");
            sb.Append("setTimeout('addRandom()', 1000)");
            sb.Append("}");

            GMap1.Add(sb.ToString());
        }
    }
}