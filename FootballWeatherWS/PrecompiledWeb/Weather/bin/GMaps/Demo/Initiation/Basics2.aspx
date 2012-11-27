<%@ Page Title="Basics 2" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Basics2.aspx.cs" Inherits="Demos.Initiation.Basics2" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" Width="90%" Height="250px" />
    <cc1:GMap ID="GMap2" runat="server" />
</asp:Content>
