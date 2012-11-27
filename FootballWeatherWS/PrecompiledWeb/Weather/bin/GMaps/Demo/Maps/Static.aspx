<%@ Page Title="Static Map" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Static.aspx.cs" Inherits="Demos.Maps.Static" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:StaticGMap ID="StaticGMap1" runat="server" Width="500" Height="500" Language="en" format="png32" />
</asp:Content>