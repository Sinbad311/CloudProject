using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class Tiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(37.4419, -122.1419), 13);

            GCopyrightCollection myCopyright = new GCopyrightCollection("© ");
            myCopyright.Add(new GCopyright("Demo",
                                            new GLatLngBounds(new GLatLng(-90, -180), new GLatLng(90, 180)),
                                            0,
                                           "©2008 Subgurim"));


            GTileLayerOptions tileLayerOptions = new GTileLayerOptions();
            tileLayerOptions.tileUrlTemplate = "http://gmaps-samples-flash.googlecode.com/svn/trunk/demos/TileDetectorDemo/srcview/source/tile_crosshairs.png.html";

            GTileLayer tilelayer = new GTileLayer(myCopyright, 10, 10, tileLayerOptions);

            GTileLayerOverlay myTileLayer = new GTileLayerOverlay(tilelayer);

            GMap1.Add(myTileLayer);
        }
    }
}