<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Server.aspx.cs" Inherits="Demos.JsEvents.Server" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" enableServerEvents="true" 
        OnMarkerClick="GMap1_MarkerClick"
        OnZoomEnd="GMap1_ZoomEnd" 
        OnMapTypeChanged="GMap1_MapTypeChanged" 
        OnClick="GMap1_Click"
        OnDragEnd="GMap1_DragEnd"
        OnDragStart="GMap1_DragStart"
        OnMoveEnd="GMap1_MoveEnd"
        OnMoveStart="GMap1_MoveStart" />
    <div id="messages1"></div>
    <div id="messages2"></div>
</asp:Content>