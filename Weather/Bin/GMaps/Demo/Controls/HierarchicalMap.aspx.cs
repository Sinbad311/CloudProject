using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class HierarchicalMap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.Add(GMapType.GTypes.Physical);

            GHierarchicalMapTypeControl hierarchicalMapTypeControl = new GHierarchicalMapTypeControl();

            hierarchicalMapTypeControl.clearPreviousRelationShips = true;
            hierarchicalMapTypeControl.hierarchicalMapTypeControlRelations.Add(
                new GHierarchicalMapTypeControlRelation(GMapType.GTypes.Normal, GMapType.GTypes.Physical, "Subgurim Physical", false));
            hierarchicalMapTypeControl.hierarchicalMapTypeControlRelations.Add(
                new GHierarchicalMapTypeControlRelation(GMapType.GTypes.Satellite, GMapType.GTypes.Hybrid, "Subgurim Hybrid", false));

            GMap1.gHierarchicalMapTypeControl = hierarchicalMapTypeControl;
        }
    }
}