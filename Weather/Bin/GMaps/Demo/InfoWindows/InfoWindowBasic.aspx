<%@ Page Title="InfoWindow" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="InfoWindowBasic.aspx.cs" Inherits="Demos.InfoWindows.InfoWindowBasic" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" />
</asp:Content>