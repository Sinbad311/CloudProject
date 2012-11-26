using System;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class DraggableObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExtDraggableObject draggable = new ExtDraggableObject(draggableElement.ClientID);
            
            GMap1.Add(draggable);
        }
    }
}