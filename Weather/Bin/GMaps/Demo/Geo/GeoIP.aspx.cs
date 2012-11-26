using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class GeoIP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string databaseFile = Server.MapPath("~/App_Data/GeoIP/GeoLiteCity.dat");
            LookupService service = new LookupService(databaseFile);
            Location location = service.getLocation(Request.UserHostAddress);

            if (location != null)
            {
                GLatLng latlng = new GLatLng(location.latitude, location.longitude);
                GMap1.setCenter(latlng, 10);

                string infoWindowHTML = string.Format(@" 
                    <div style=""text-align:left""> 
                        <b>GEOIP PROPERTIES</b> 
                        <br /> 
                        <b>Area Code</b>: {0} 
                        <br /> 
                        <b>City</b>: {1} 
                        <br /> 
                        <b>Country Code</b>: {2} 
                        <br /> 
                        <b>Country Name</b>: {3} 
                        <br /> 
                        <b>DMA Code</b>: {4} 
                        <br /> 
                        <b>Postal Code</b>: {5} 
                        <br /> 
                        <b>Region</b>: {6} 
                    </div> 
                    ",
                     location.area_code,
                     location.city,
                     location.countryCode,
                     location.countryName,
                     location.dma_code,
                     location.postalCode,
                     location.region);

                GMap1.Add(new GInfoWindow(new GMarker(latlng), infoWindowHTML));
            } 
        }
    }
}