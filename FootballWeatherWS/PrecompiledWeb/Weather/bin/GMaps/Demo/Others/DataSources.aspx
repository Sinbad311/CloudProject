<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="DataSources.aspx.cs" Inherits="Demos.Others.DataSources" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" 
        DataSourceID="SqlDataSource1" DataSourceType="PolylinesAndMarkers"  
        DataLatField="Lat" DataLngField="Lng" DataGInfoWindowTextField="InfoWindowText"  
        DataGIconImageField="IconImage" DataGIconShadowField="IconShadow"  
        DataGIconAnchorField="IconAnchor" DataGIconSizeField="IconSize" DataGIconShadowSizeField="IconShadowSize" DataGInfoWindowAnchorField="InfoWindowAnchor" /> 

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MapTest %>" 
        SelectCommand="SELECT Lat, Lng, InfoWindowText, IconImage, IconShadow, IconAnchor, IconSize, IconShadowSize, InfoWindowAnchor FROM [MapTestTable]"></asp:SqlDataSource> 
</asp:Content>