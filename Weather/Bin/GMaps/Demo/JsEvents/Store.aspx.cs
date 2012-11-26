using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.JsEvents
{
    public partial class Store : System.Web.UI.Page
    {
        private static int _i = 0;
        public static int i
        {
            get
            {
                return _i++;
            }
        } 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GMap2.Add(new GListener(GMap2.GMap_Id, GListener.Event.zoomend,
                string.Format(@"   
                    function(oldZoom, newZoom) 
                    {{ 
                        var store = new Store('{0}_Store'); 
                        store.Set(Math.random(), oldZoom + '-' + newZoom);   
                    }}             
                    ", GMap2.GMap_Id)));

                GMap2.Add(new GControl(GControl.preBuilt.SmallZoomControl));
            }

            GMap1.Store.Add(i.ToString(), DateTime.Now.ToString()); 
        }

        protected string GMap_Click(object s, GAjaxServerEventArgs e)
        {
            e.store[i.ToString()] = DateTime.Now.ToString();
            return string.Format("alert('{0} Store items: {1}')", e.map, e.store.Count);
        }
    }
}