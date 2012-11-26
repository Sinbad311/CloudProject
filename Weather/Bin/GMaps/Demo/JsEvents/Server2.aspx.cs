using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class Server2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GMap1.Add(new GListener(GMap1.GMap_Id, GListener.Event.click,
                 string.Format(@"
               function(event)
               {{
                  if (!event) return;
                  var ev = new serverEvent('Click', {0});
                  ev.addArg({0}.getDiv().offsetWidth);
                  ev.addArg({0}.getDiv().offsetHeight);
                  ev.addArg(event.latLng.lat());
                  ev.addArg(event.latLng.lng());
                  ev.send();
               }}
               ", GMap1.GMap_Id)));
//                GMap1.addListener(new GListener(GMap1.GMap_Id, GListener.Event.infowindowclose,
//                 string.Format(@"
//                   function()
//                   {{
//                      var ev = new serverEvent('InfoWindowClose', {0});
//                      ev.addArg('My Argument');
//                       ev.send();
//                   }}
//                   ", GMap1.GMap_Id)));
            }
        }

        protected string GMap1_ServerEvent(object s, GAjaxServerEventOtherArgs e)
        {
            string js = string.Empty;
            switch (e.eventName)
            {
                case "Click":
                    GLatLng latlng = new GLatLng(
                    Convert.ToDouble(e.eventArgs[2], new System.Globalization.CultureInfo("en-US", false)),
                    Convert.ToDouble(e.eventArgs[3], new System.Globalization.CultureInfo("en-US", false)));
                    GInfoWindow window = new GInfoWindow(latlng, string.Format("Window Size (px): ({0},{1}). Close Me.", e.eventArgs[0], e.eventArgs[1]));
                    GListener listener = new  GListener(window.ID, GListener.Event.infowindowclose,
                                                    string.Format(
                                                        @"
                                                           function()
                                                           {{
                                                              var ev = new serverEvent('InfoWindowClose', {0});
                                                              ev.addArg('My Argument');
                                                               ev.send();
                                                           }}
                                                        ",
                                                        window.ID));
                    js = window.ToString(e.who) + listener.ToString();
                    break;
                case "InfoWindowClose":
                    js = string.Format
                    ("alert('{0}: {1} - {2} - {3}')", e.eventName, e.point, e.eventArgs[0], DateTime.Now);
                    break;
            }
            return js;
        }
    }
}