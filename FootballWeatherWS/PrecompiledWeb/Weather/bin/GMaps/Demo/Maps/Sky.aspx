<%@ Page Title="Sky Map" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Sky.aspx.cs" Inherits="Demos.Maps.Sky" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GSkyMap ID="GSkyMap1" runat="server" />
</asp:Content>