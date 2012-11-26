using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Utility
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ContextMenuControl contextMenuControl = new ContextMenuControl();

            contextMenuControl.dirsFromText = "Desde aquí";
            contextMenuControl.dirsToText = "Hasta aquí";
            contextMenuControl.addDestinationText = "Añadir destino";
            contextMenuControl.centerMapText = "Centrar mapa";
            contextMenuControl.removePointText = "Eliminar punto";
            contextMenuControl.whatsHereText = "¿Qué hay aquí?";
            contextMenuControl.zoomInText = "Acercar";
            contextMenuControl.zoomOutText = "Alejar";
            contextMenuControl.fromText = "desde aquí hasta";
            contextMenuControl.toText = "hasta aquí desde";
            contextMenuControl.startAddressText = "Dirección inicial";
            contextMenuControl.endAddressText = "Dirección final";

            contextMenuControl.byCarText = "En coche";
            contextMenuControl.avoidHighwaysText = "Evitar autopistas";
            contextMenuControl.dragOrText = "Arrastrar o";
            contextMenuControl.removeThisPointText = "eliminar este punto";
            contextMenuControl.getDirectionText = "Buscar";
            contextMenuControl.directionText = "Dirección";

            contextMenuControl.previousText = "previo";
            contextMenuControl.nextText = "posterior";

            contextMenuControl.addressText = "Dirección";

            GMap1.Add(new GControl(contextMenuControl));
        }
    }
}