using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class Custom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            GLatLng center = new GLatLng(44, 5);
            GMap1.setCenter(center);

            sb.Append("var markers=[];");
            sb.Append("function subgurim_Add()");
            sb.Append("{");
            GMarker marker = new GMarker(GMap1.GMap_Id + ".getCenter()");
            sb.Append(marker.ToString(GMap1.GMap_Id));
            sb.AppendFormat("markers.push({0})", marker.ID);
            sb.Append("}");

            sb.Append("function subgurim_Delete()");
            sb.Append("{");
            sb.Append("if (markers.length > 0) { markers.pop().setMap(null); }");
            sb.Append("}");

            sb.Append("function subgurim_Remove()");
            sb.Append("{");
            sb.Append("for (var i = 0; i < markers.length; i++) { markers[i].setMap(null); }");
            sb.Append("markers = [];");
            sb.Append("}");

            GMap1.Add(sb.ToString());
        }
    }
}