using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class Advanced : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void bt_Buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                string Key = System.Configuration.ConfigurationManager.AppSettings.Get("googlemaps.subgurim.net");

                GeoCode geocode = GMap.geoCodeRequest(TextBox1.Text, Key);
                //GeoCode geocode = GMap1.getGeoCodeRequest(TextBox1.Text);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                if ((null != geocode) && geocode.valid)
                {
                    sb.Append("<ul>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.name");
                    sb.Append("</i>: ");
                    sb.Append(geocode.name);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Status.code");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Status.code);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Status.request");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Status.request);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.address");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.address);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.accuracy");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.accuracy);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.Country.CountryNameCode");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.Country.CountryNameCode);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.Country.AdministrativeArea.AdministrativeAreaName");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.Country.AdministrativeArea.AdministrativeAreaName);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.SubAdministrativeAreaName");

                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.SubAdministrativeAreaName);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.LocalityName");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.LocalityName);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.PostalCode.PostalCodeNumber");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.PostalCode.PostalCodeNumber);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.Thoroughfare.ThoroughfareName");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.AddressDetails.Country.AdministrativeArea.SubAdministrativeArea.Locality.Thoroughfare.ThoroughfareName);
                    sb.Append("</li>");

                    sb.Append("<li>");
                    sb.Append("<i>");
                    sb.Append("geocode.Placemark.coordinates");
                    sb.Append("</i>: ");
                    sb.Append(geocode.Placemark.coordinates.ToString());
                    sb.Append("</li>");

                    sb.Append("</ul>");
                }
                else sb.Append("Ubicación no encontrada"); Label1.Text = sb.ToString();
            }
        }
    }
}