using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demos.Initiation
{
    public partial class Minimization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.enablePostBackPersistence = false;
            GMap1.enableGetGMapElementById = false;
        }
    }
}