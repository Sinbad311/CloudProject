<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Advanced.aspx.cs" Inherits="Demos.Geo.Advanced" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:Literal ID="Literal1" runat="server">Buscar una dirección</asp:Literal>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="bt_Buscar_Click" />
    <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>