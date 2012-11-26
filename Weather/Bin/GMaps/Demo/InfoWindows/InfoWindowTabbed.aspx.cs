using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.InfoWindows
{
    public partial class InfoWindowTabbed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GLatLng latlon = new GLatLng(10.2, 22);
            GMap1.setCenter(latlon, 4);

            /****** INFOWINDOWTAB 1 ******/

            GInfoWindowTabs iwTabs = new GInfoWindowTabs();
            iwTabs.point = latlon;

            List<GInfoWindowTab> tabs = new List<GInfoWindowTab>();
            for (int i = 0; i < 3; i++)
            {
                tabs.Add(new GInfoWindowTab("Tab " + i.ToString(), i.ToString()));
            }

            iwTabs.tabs = tabs;
            GMap1.Add(iwTabs);

            /****** INFOWINDOWTAB 2 ******/

            GInfoWindowTabs iwTabs2 = new GInfoWindowTabs();

            GMarker icono = new GMarker(new GLatLng(5, 19));

            iwTabs2.gMarker = icono;
            iwTabs2.tabs = tabs;
            GMap1.Add(iwTabs2);
        }
    }
}