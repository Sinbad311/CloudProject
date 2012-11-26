using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Icons
{
    public partial class Markers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(41, 3), 3);
            GMap1.Add(new GControl(GControl.preBuilt.LargeMapControl));

            GMarker m1 = new GMarker(new GLatLng(41, 3));

            MarkerManager mManager = new MarkerManager();

            mManager.Add(m1, 2);

            List<GMarker> mks = new List<GMarker>();

            List<GInfoWindow> iws = new List<GInfoWindow>();

            Random r = new Random();

            double ir1, ir2;
            GMarker mkr;

            for (int i = 0; i < 10; i++)
            {
                ir1 = (double)r.Next(40) / 10.0 - 2.0;
                ir2 = (double)r.Next(40) / 10.0 - 2.0;

                mkr = new GMarker(m1.point + new GLatLng(ir1, ir2));
                mks.Add(mkr);

                GMap1.Add(new GListener(mkr.ID, GListener.Event.click, "function(){alert('" + i + "');}"));
            }

            for (int i = 0; i < 5; i++)
            {
                ir1 = (double)r.Next(40) / 20.0 - 1;
                ir2 = (double)r.Next(40) / 20.0 - 1;

                mkr = new GMarker(m1.point + new GLatLng(ir1, ir2));
                GInfoWindow window = new GInfoWindow(mkr, i.ToString());
                iws.Add(window);
            }

            mManager.Add(mks, 6, 8);
            mManager.Add(iws, 7, 8);
            
            GMap1.markerManager = mManager;
        }
    }
}