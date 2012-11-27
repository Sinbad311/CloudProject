<%@ Page Title="InfoBox" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="InfoBoxes.aspx.cs" Inherits="Demos.Utility.InfoBoxes" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .box {
            border: 1px solid black;
            background: yellow;
            padding: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" />
</asp:Content>
