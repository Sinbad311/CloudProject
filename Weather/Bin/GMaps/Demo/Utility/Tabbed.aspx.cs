using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Tabbed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<GInfoWindowTabbedMaxContentTab> tabs = new List<GInfoWindowTabbedMaxContentTab>();

            tabs.Add(new GInfoWindowTabbedMaxContentTab("Label 1", "Html 1"));
            tabs.Add(new GInfoWindowTabbedMaxContentTab("Label 2", "Html 2"));
            tabs.Add(new GInfoWindowTabbedMaxContentTab("Label 3", "Html 3"));
            tabs.Add(new GInfoWindowTabbedMaxContentTab("Label 4", "Html 4"));

            GInfoWindowTabbedMaxContent infoWindowTabbedMaxContent = new GInfoWindowTabbedMaxContent(new GMarker(new GLatLng(40, 0)), tabs, true);

            infoWindowTabbedMaxContent.minHtml = "min HTML";
            infoWindowTabbedMaxContent.summaryHtml = "summary <b>HTML</b>";

            GMap1.Add(infoWindowTabbedMaxContent);
        }
    }
}