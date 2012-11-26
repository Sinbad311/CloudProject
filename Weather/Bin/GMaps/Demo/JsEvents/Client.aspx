<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="Demos.JsEvents.Client" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <script type="text/javascript">
        function alertame() 
        { 
            alert('Quedas alertado'); 
        } 
    </script> 
    <cc1:GMap ID="GMap1" runat="server" />
</asp:Content>