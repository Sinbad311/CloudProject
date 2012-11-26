using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class Postback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.setupMap();
            }

            if (GMap1.IsAjaxPostBack)
            {
                // GMaps Ajax PostBack 
            }
        }

        private void setupMap()
        {
            GLatLng latLng = new GLatLng(40, 10);

            GMap1.GCenter = latLng;

            GMarker marker = new GMarker(latLng);
            GMap1.Add(marker);
        }

        protected string GMap1_Click(object s, GAjaxServerEventArgs e)
        {
            GMap1.GZoom = 1;

            GInfoWindow window = new GInfoWindow(e.point, "Clicked");
            GMap1.Add(window);

            return string.Empty;
        }

        protected string GMap1_MarkerClick(object s, GAjaxServerEventArgs e)
        {
            GLatLng latLng = new GLatLng(40, 10);

            GMap1.GCenter = latLng;
            GMap1.resetInfoWindows();

            GMap1.GZoom = 6;
            return string.Empty;
        }
    }
}