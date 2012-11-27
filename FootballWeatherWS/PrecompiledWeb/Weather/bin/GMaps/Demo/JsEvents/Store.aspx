<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="Demos.JsEvents.Store" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" enableServerEvents="true" enableStore="true" OnClick="GMap_Click" serverEventsType="AspNetPostBack" /> 
    <cc1:GMap ID="GMap2" runat="server" enableServerEvents="true" enableStore="true" OnClick="GMap_Click" />
</asp:Content>