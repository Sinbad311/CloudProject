using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class GetById : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GMap1_Click(object s, GAjaxServerEventArgs e)
        {
            return new GMarker(e.point).ToString(e.map);
        }

        protected string GMap1_MarkerClick(object s, GAjaxServerEventArgs e)
        {
            string markerID = GMap1.getGMapElementById(e.who);

            string js = string.Format(@"
                if ({0}.getVisible())
                    {0}.setVisible(false);
                else
                    {0}.setVisible(true);
                ", markerID);

            js += string.Format("alert('point: ' + {0}.getPosition());", markerID);

            return js;
        }
    }
}