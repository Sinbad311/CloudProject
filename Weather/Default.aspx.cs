using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        GLatLng latLng = new GLatLng(39.1, -94.58);
        //creating markers with latitude and logitude, plus pushpin window and adding window in Gmap Control
        GIcon icon = new GIcon();
        icon.markerIconOptions = new MarkerIconOptions(20, 40);
        //Stadium pins with window info
        GMarker marker = new GMarker(new GLatLng(36.166461, -86.771289), icon);
        GInfoWindow window = new GInfoWindow(marker, "Titans");
        GMap1.Add(window);
        GMarker marker1 = new GMarker(new GLatLng(40.812194, -74.076983), icon);
        GInfoWindow window1 = new GInfoWindow(marker1, "Giants");
        GMap1.Add(window1);
        GMarker marker2 = new GMarker(new GLatLng(40.446786, -80.015761), icon);
        GInfoWindow window2 = new GInfoWindow(marker2, "Steelers");
        GMap1.Add(window2);
        GMarker marker3 = new GMarker(new GLatLng(35.225808, -80.852861), icon);
        GInfoWindow window3 = new GInfoWindow(marker3, "Panthers");
        GMap1.Add(window3);
        GMarker marker4 = new GMarker(new GLatLng(39.277969, -76.622767), icon);
        GInfoWindow window4 = new GInfoWindow(marker4, "Ravens");
        GMap1.Add(window4);
        GMarker marker5 = new GMarker(new GLatLng(27.975967, -82.50335), icon);
        GInfoWindow window5 = new GInfoWindow(marker5, "Buccaneers");
        GMap1.Add(window5);
        GMarker marker6 = new GMarker(new GLatLng(39.760056, -86.163806), icon);
        GInfoWindow window6 = new GInfoWindow(marker6, "Colts");
        GMap1.Add(window6);
        GMarker marker7 = new GMarker(new GLatLng(44.973881, -93.258094), icon);
        GInfoWindow window7 = new GInfoWindow(marker7, "Vikings");
        GMap1.Add(window7);
        GMarker marker8 = new GMarker(new GLatLng(33.5277, -112.262608), icon);
        GInfoWindow window8 = new GInfoWindow(marker8, "Cardinals");
        GMap1.Add(window8);
        GMarker marker9 = new GMarker(new GLatLng(32.747778, -97.092778), icon);
        GInfoWindow window9 = new GInfoWindow(marker9, "Cowboys");
        GMap1.Add(window9);
        GMarker marker10 = new GMarker(new GLatLng(33.757614, -84.400972), icon);
        GInfoWindow window10 = new GInfoWindow(marker10, "Falcons");
        GMap1.Add(window10);
        GMarker marker11 = new GMarker(new GLatLng(40.812194, -74.076983), icon);
        GInfoWindow window11 = new GInfoWindow(marker11, "Jets");
        GMap1.Add(window11);
        GMarker marker12 = new GMarker(new GLatLng(39.743936, -105.020097), icon);
        GInfoWindow window12 = new GInfoWindow(marker12, "Broncos");
        GMap1.Add(window12);
        GMarker marker13 = new GMarker(new GLatLng(25.957919, -80.238842), icon);
        GInfoWindow window13 = new GInfoWindow(marker13, "Dolphinss");
        GMap1.Add(window13);
        GMarker marker14 = new GMarker(new GLatLng(39.900775, -75.167453), icon);
        GInfoWindow window14 = new GInfoWindow(marker14, "Eagles");
        GMap1.Add(window14);
        GMarker marker15 = new GMarker(new GLatLng(41.862306, -87.616672), icon);
        GInfoWindow window15 = new GInfoWindow(marker15, "Bears");
        GMap1.Add(window15);
        GMarker marker16 = new GMarker(new GLatLng(42.090925, -71.26435), icon);
        GInfoWindow window16 = new GInfoWindow(marker16, "Patriots");
        GMap1.Add(window16);
        GMarker marker17 = new GMarker(new GLatLng(38.907697, -76.864517), icon);
        GInfoWindow window17 = new GInfoWindow(marker17, "Redskins");
        GMap1.Add(window17);
        GMarker marker18 = new GMarker(new GLatLng(44.501306, -88.062167), icon);
        GInfoWindow window18 = new GInfoWindow(marker18, "Packers");
        GMap1.Add(window18);
        GMarker marker19 = new GMarker(new GLatLng(32.783117, -117.119525), icon);
        GInfoWindow window19 = new GInfoWindow(marker19, "Chargers");
        GMap1.Add(window19);
        GMarker marker20 = new GMarker(new GLatLng(29.950931, -90.081364), icon);
        GInfoWindow window20 = new GInfoWindow(marker20, "Saints");
        GMap1.Add(window20);
        GMarker marker21 = new GMarker(new GLatLng(29.684781, -95.410956), icon);
        GInfoWindow window21 = new GInfoWindow(marker21, "Texans");
        GMap1.Add(window21);
        GMarker marker22 = new GMarker(new GLatLng(42.773739, -78.786978), icon);
        GInfoWindow window22 = new GInfoWindow(marker22, "Bills");
        GMap1.Add(window22);
        GMarker marker23 = new GMarker(new GLatLng(37.713486, -122.386256), icon);
        GInfoWindow window23 = new GInfoWindow(marker23, "49ers");
        GMap1.Add(window23);
        GMarker marker24 = new GMarker(new GLatLng(30.323925, -81.637356), icon);
        GInfoWindow window24 = new GInfoWindow(marker24, "Jaguars");
        GMap1.Add(window24);
        GMarker marker25 = new GMarker(new GLatLng(41.506022, -81.699564), icon);
        GInfoWindow window25 = new GInfoWindow(marker25, "Browns");
        GMap1.Add(window25);
        GMarker marker26 = new GMarker(new GLatLng(37.751411, -122.200889), icon);
        GInfoWindow window26 = new GInfoWindow(marker26, "Raiders");
        GMap1.Add(window26);
        GMarker marker27 = new GMarker(new GLatLng(39.048914, -94.484039), icon);
        GInfoWindow window27 = new GInfoWindow(marker27, "Chiefs");
        GMap1.Add(window27);
        GMarker marker28 = new GMarker(new GLatLng(38.632975, -90.188547), icon);
        GInfoWindow window28 = new GInfoWindow(marker28, "Rams");
        GMap1.Add(window28);
        GMarker marker29 = new GMarker(new GLatLng(47.595153, -122.331625), icon);
        GInfoWindow window29 = new GInfoWindow(marker29, "Seahawks");
        GMap1.Add(window29);
        GMarker marker30 = new GMarker(new GLatLng(39.095442, -84.516039), icon);
        GInfoWindow window30 = new GInfoWindow(marker30, "Bengals");
        GMap1.Add(window30);
        GMarker marker31 = new GMarker(new GLatLng(42.340156, -83.045808), icon);
        GInfoWindow window31 = new GInfoWindow(marker31, "Lions");
        GMap1.Add(window31);
        
        GMap1.Height = 350;
        GMap1.Width = 990;
        GMap1.GCenter = latLng;
        GMap1.GZoom  = 4;
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String zip = TextBox1.Text;
        Weather.Weather myservice = new Weather.Weather();
        Label1.Text = myservice.GetCityWeatherByZIP(zip).Description;
        Label2.Text = myservice.GetCityWeatherByZIP(zip).Temperature;
        Label3.Text = myservice.GetCityWeatherByZIP(zip).City;
        Label4.Text = myservice.GetCityWeatherByZIP(zip).State;
        int k= myservice.GetCityWeatherByZIP(zip).WeatherID;

        if (k == 1)
        {
            Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/thunderstorms.gif";
        }
        if (k == 2)
        {
            Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
        }
        if (k == 3)
        {
            Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudly.gif";
        }
        if (k == 4)
        {
            Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/sunny.gif";
        }
        if (k == 5)
        {
            Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
            if (k == 6)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/showers.gif";
            }
            if (k == 7)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/haze.gif";
            }
            if (k == 9)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudy.gif";
            }
            if (k == 10)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
            }
            if (k == 11)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/sunny.gif";
            }
            if (k == 12)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
            }
            if (k == 14)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudy.gif";
            }
            if (k == 14)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/mostlycloudy.gif";
            }
            if (k == 15)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/na.gif";
            }
            if (k == 17)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/drizzle.gif";
            }
            if (k == 18)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/fog.gif";
            }
            if (k == 20)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
            }
            if (k == 21)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
            }
            if (k == 26)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
            }
            if (k == 27)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/snow.gif";
            }
            if (k == 28)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
            }
            if (k == 29)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
            }
            if (k == 32)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
            }
            if (k == 33)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/rain.gif";
            }
            if (k == 34)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/na.gif";
            }
            if (k == 35)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/blowingsnow.gif";
            }
            if (k == 36)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/na.gif";
            }
            if (k == 37)
            {
                Image1.ImageUrl = "http://ws.cdyne.com/WeatherWS/Images/partlycloudy.gif";
            }

        }
    }
}