<%@ Page Title="StreetViewPanorama" Language="C#" MasterPageFile="~/Demos.Master"
    AutoEventWireup="true" CodeBehind="StreetView.aspx.cs" Inherits="Demos.Maps.StreetView" %>

<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <script type="text/javascript">
        function writeMessage(text) {
            var textarea = $('#jsmessages');
            var originalText = textarea.html();

            textarea.html(originalText + '<br />' + text);

            textarea.scrollTop(textarea[0].scrollHeight - textarea.height());
        }

    </script>
    <cc1:GStreetviewPanorama ID="GStreetviewPanorama1" runat="server" />
    <div id="jsmessages" style="overflow: auto; height: 200px; width: 600px;">
    </div>
</asp:Content>
