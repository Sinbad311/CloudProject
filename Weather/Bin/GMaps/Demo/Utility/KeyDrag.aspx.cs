using System;
using Subgurim.Controles;
using Subgurim.Controles.Core.Utilities;

namespace Demos.Utility
{
    public partial class KeyDrag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KeyDragZoom keyDragZoom = new KeyDragZoom();
            keyDragZoom.key = KeyDragZoom.HotKeyEnum.ctrl;
            keyDragZoom.boxStyle = "{border: '4px solid #FFFF00'}";
            // keyDragZoom.paneStyle = "{backgroundColor: 'black', opacity: 0.2, cursor: 'crosshair'}";
            keyDragZoom.VeilStyle = "{backgroundColor: 'black', opacity: 0.2, cursor: 'crosshair'}";

            //keyDragZoom.VisualClass = "cssclass";
            keyDragZoom.VisualEnabled = true;
            //keyDragZoom.VisualPosition = ControlPosition.Top_Right;
            //keyDragZoom.VisualPositionIndex = 0;
            //keyDragZoom.VisualPositionOffset = new Size(30, 0);
            //keyDragZoom.VisualSize = new Size(20, 20);
            //keyDragZoom.VisualSprite = "http://maps.gstatic.com/mapfiles/ftr/controls/dragzoom_btn.png";
            //keyDragZoom.VisualTips = "{on: 'Turn on', off: 'Turn off'}";


            GMap1.Add(keyDragZoom);
        }
    }
}