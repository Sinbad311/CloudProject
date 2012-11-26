<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Custom.aspx.cs" Inherits="Demos.JsEvents.Custom" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" />
    <input type="button" id="Button1" value="Añadir icono" onclick="subgurim_Add()" />
    <input type="button" id="Button2" value="Borrar último icono" onclick="subgurim_Delete()" />
    <input type="button" id="Button3" value="Borrar todos los iconos" onclick="subgurim_Remove()" />
</asp:Content>