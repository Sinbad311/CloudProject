<%@ Page Title="GInfoWindowOptions" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="InfoWindowOptions.aspx.cs" Inherits="Demos.InfoWindows.InfoWindowOptions" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <script type="text/javascript">
        function abiertoSMBU() {
            alert('Has abierto el ShowMapBlowUp');
        }
    </script> 

    <cc1:GMap ID="GMap1" runat="server" />
</asp:Content>