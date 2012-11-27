<%@ Page Title="Mars Map" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Mars.aspx.cs" Inherits="Demos.Maps.Mars" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMarsMap ID="GMarsMap1" runat="server" />
</asp:Content>