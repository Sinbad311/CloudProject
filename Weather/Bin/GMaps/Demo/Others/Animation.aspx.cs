using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Others
{
    public partial class Animation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMove move = new GMove(500, 1, -1);
            GMap1.Add(move);

            GMove move2 = new GMove();
            move2.deltaMiliseconds = 2500;
            move2.goTo = new GLatLng(51, 44);

            GMap1.Add(move2);

            GMap1.Add(new GMove(2500, new GLatLng(51, 20)));

            GMap1.Add(new GMove(1500, 2, 3));
        }
    }
}