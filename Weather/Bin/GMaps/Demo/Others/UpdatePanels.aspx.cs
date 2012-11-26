using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMaps.Demos.Others
{
    public partial class UpdatePanels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int count = 0;

        protected void OnTimerTick(object sender, EventArgs e)
        {
            Panel1.Update();
        }
    }
}