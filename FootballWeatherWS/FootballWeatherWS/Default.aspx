<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FootballWeatherWS._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false">
    function initialize() {
        var latlng = new google.maps.LatLng(-34.397, 150.644);
        var options =
    {
    var marker = new google.maps.Marker
(
    {
        position: new google.maps.LatLng(-34.397, 150.644),
        map: map,
        title: 'Click me'
    }
);
        zoom: 3,
        center: new google.maps.LatLng(37.09, -95.71),
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        mapTypeControl: true,
        mapTypeControlOptions:
        {
            style: google.maps.MapTypeControlStyle.DROPDOWN_MENU,
            poistion: google.maps.ControlPosition.TOP_RIGHT,
            mapTypeIds: [google.maps.MapTypeId.ROADMAP,
              google.maps.MapTypeId.TERRAIN,
              google.maps.MapTypeId.HYBRID,
              google.maps.MapTypeId.SATELLITE]
        },
        navigationControl: true,
        navigationControlOptions:
        {
            style: google.maps.NavigationControlStyle.ZOOM_PAN
        },
        scaleControl: true,
        disableDoubleClickZoom: true,
        draggable: false,
        streetViewControl: true,
        draggableCursor: 'move'
    };
        var map = new google.maps.Map(document.getElementById("map"), options);
    }
    window.onload = initialize;
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
