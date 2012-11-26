<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="DraggableObject.aspx.cs" Inherits="Demos.Utility.DraggableObject" %>
<%@ Register TagPrefix="cc1" Namespace="Subgurim.Controles" Assembly="GMaps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <cc1:GMap ID="GMap1" runat="server" />
    
    <div runat="server" id="draggableElement" style="width:100px; height:25px; background:#BBBBBB; border:1px solid black;">Drag Me!</div></asp:Content>
