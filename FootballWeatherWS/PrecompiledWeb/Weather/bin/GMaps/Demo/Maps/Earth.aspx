<%@ Page Title="GoogleEarth Map" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Earth.aspx.cs" Inherits="Demos.Maps.Earth" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GEarthMap ID="GEarthMap1" runat="server" Height="400" />
</asp:Content>