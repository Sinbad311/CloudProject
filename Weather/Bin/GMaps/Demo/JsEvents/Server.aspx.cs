using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class Server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GMap1.Add(new GControl(GControl.preBuilt.LargeMapControl));
                GMap1.Add(new GControl(GControl.preBuilt.MapTypeControl));
            }
        }

        protected string GMap1_Click(object s, GAjaxServerEventArgs e)
        {
            GMarker marker = new GMarker(e.point);

            GInfoWindow window = new GInfoWindow(marker,
                string.Format(@"<b>GLatLngBounds</b><br />SW = {0}<br/>NE = {1}",
                e.bounds.getSouthWest().ToString(),
                e.bounds.getNorthEast().ToString())
            , true);

            return window.ToString(e.map);
        }

        protected string GMap1_MarkerClick(object s, GAjaxServerEventArgs e)
        {
            return string.Format("alert('MarkerClick: {0} - {1}')", e.point.ToString(), DateTime.Now);
        }

        protected string GMap1_MoveStart(object s, GAjaxServerEventArgs e)
        {
            return "document.getElementById('messages1').innerHTML= 'MoveStart at " + e.point.ToString() + " - " + DateTime.Now.ToString() + "';";
        }

        protected string GMap1_MoveEnd(object s, GAjaxServerEventArgs e)
        {
            return "document.getElementById('messages2').innerHTML= 'MoveEnd at " + e.point.ToString() + " - " + DateTime.Now.ToString() + "';";
        }

        protected string GMap1_DragStart(object s, GAjaxServerEventArgs e)
        {
            GMarker marker = new GMarker(e.point);
            GInfoWindow window = new GInfoWindow(marker, "DragStart - " + DateTime.Now.ToString(), false);
            return window.ToString(e.map);
        }

        protected string GMap1_DragEnd(object s, GAjaxServerEventArgs e)
        {
            GMarker marker = new GMarker(e.point);
            GInfoWindow window = new GInfoWindow(marker, "DragEnd - " + DateTime.Now.ToString(), false);
            return window.ToString(e.map);
        }

        protected string GMap1_ZoomEnd(object s, GAjaxServerEventZoomArgs e)
        {
            return string.Format("alert('oldLevel/newLevel: {0}/{1} - {2}')", e.oldLevel, e.newLevel, DateTime.Now);
        }

        protected string GMap1_MapTypeChanged(object s, GAjaxServerEventMapArgs e)
        {
            return string.Format("alert('{0}')", e.mapType.ToString());
        }
    }
}