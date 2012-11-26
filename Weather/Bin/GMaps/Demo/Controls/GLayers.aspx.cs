using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;

namespace Demos.Controls
{
    public partial class GLayers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GWeatherLayerOptions options = new GWeatherLayerOptions()
                                               {
                                                   TemperatureUnits = GWeatherLayerOptions.TemperatureUnit.Celsius,
                                                   WindSpeedUnits = GWeatherLayerOptions.WindSpeedUnit.MetersPerSecond
                                               };

            GLayer layerWeather = new GLayer(GLayerType.Weather, options);
            GMap1.Add(layerWeather);

            GLayer layerPanoramio = new GLayer(GLayerType.Panoramio);
            GMap2.Add(layerPanoramio);

            //GLayer layerClouds = new GLayer(GLayerType.Clouds);
            //GMap2.Add(layerClouds);
        }
    }
}