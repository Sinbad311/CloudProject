using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Bar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GGoogleBarOptions googleBarOptions = new GGoogleBarOptions();
            googleBarOptions.resultList = GGoogleBarResultListEnum.supress;
            googleBarOptions.linkTarget = GGoogleBarLinkTargetEnum._blank;
            googleBarOptions.onSearchCompleteCallback = "alert('onSearchCompleteCallback');";
            googleBarOptions.onMarkersSetCallback = "alert('onMarkersSetCallback');";

            googleBarOptions.googleBarAdsOptions = new GGoogleBarAdsOptions("pub-2713758978561919");
            googleBarOptions.googleBarAdsOptions.helpSubgurim = GAdsManager.HelpSubgurimEnum._75percentHelp;
            googleBarOptions.googleBarAdsOptions.adsafe = GGoogleBarAdsOptions.AdSafeEnum.off;

            GMap1.Add(googleBarOptions);
        }
    }
}