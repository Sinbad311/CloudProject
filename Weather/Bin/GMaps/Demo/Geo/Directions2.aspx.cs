using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Directions2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GDirection direction = new GDirection();
                direction.autoGenerate = false;
                direction.buttonElementId = "bt_Go";
                direction.fromElementId = tb_fromPoint.ClientID;
                direction.toElementId = tb_endPoint.ClientID;
                direction.divElementId = "div_directions"; direction.clearMap = true;


                // Optional
                // direction.locale = "es-ES";

                GMap1.Add(direction);
            }
        }
    }
}