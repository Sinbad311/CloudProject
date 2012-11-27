<%@ Page Title="Moon Map" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Moon.aspx.cs" Inherits="Demos.Maps.Moon" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMoonMap ID="GMoonMap1" runat="server" />
</asp:Content>