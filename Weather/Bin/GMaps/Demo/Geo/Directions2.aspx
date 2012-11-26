<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Directions2.aspx.cs" Inherits="Demos.Geo.Directions2" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    Start Location: <asp:TextBox ID="tb_fromPoint" runat="server"></asp:TextBox>
    End Location: <asp:TextBox ID="tb_endPoint" runat="server"></asp:TextBox>
    <input type="button" id="bt_Go" value="Come on!" />
    <cc1:GMap ID="GMap1" runat="server" />
    <div id="div_directions"></div>
</asp:Content>