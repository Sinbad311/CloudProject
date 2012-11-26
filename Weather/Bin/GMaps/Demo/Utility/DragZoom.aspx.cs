using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class DragZoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DragZoomControl dragZoomControl = new DragZoomControl();

            DragZoomOtherOptions dragZoomOtherOptions = new DragZoomOtherOptions();
            dragZoomOtherOptions.backButtonEnabled = true;
            dragZoomOtherOptions.backButtonHTML = "Go back";
            dragZoomOtherOptions.buttonHTML = "Zoom";
            dragZoomOtherOptions.minDragSize = 5;
            dragZoomControl.dragZoomOtherOptions = dragZoomOtherOptions;
            dragZoomControl.dragZoomOtherOptions = dragZoomOtherOptions;

            DragZoomCallbacks dragZoomCallbacks = new DragZoomCallbacks();
            dragZoomCallbacks.buttonclick = "function(){alert('Button Click')}";
            dragZoomControl.dragZoomCallbacks = dragZoomCallbacks;

            DragZoomBoxStyleOptions dragZoomBoxStyleOptions = new DragZoomBoxStyleOptions();
            dragZoomBoxStyleOptions.opacity = 0.5;
            dragZoomBoxStyleOptions.fillColor = Color.Red;
            dragZoomControl.dragZoomBoxStyleOptions = dragZoomBoxStyleOptions;

            GControl dragzoom = new GControl(dragZoomControl, new GControlPosition(GControlPosition.position.Top_Left));

            GMap1.Add(dragzoom);
        }
    }
}