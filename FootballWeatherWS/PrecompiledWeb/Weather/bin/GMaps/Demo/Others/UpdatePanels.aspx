<%@ Page Title="" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="UpdatePanels.aspx.cs" Inherits="GMaps.Demos.Others.UpdatePanels" %>
<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True"></asp:ScriptManager>
    
    <asp:Button runat="server" Text="Update first panel" ID="Button1"/>

    <asp:UpdatePanel runat="server" ID="Panel1" UpdateMode="Conditional">
        <ContentTemplate>
            <div style="border: 1px solid red; padding: 6px">
                <p><strong>First panel</strong></p>
                <p><%=DateTime.Now.ToString() %></p>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

    <asp:UpdatePanel runat="server" ID="Panel2" UpdateMode="Conditional" EnableViewState="True">
        <ContentTemplate>
            <div style="border: 1px solid blue; padding: 6px">
                <p><strong>Second panel</strong></p>
                <cc1:GMap ID="GMap1" runat="server" />
                <p><%=DateTime.Now.ToString() %></p>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    
    <asp:UpdatePanel runat="server" ID="Panel3" UpdateMode="Conditional">
        <ContentTemplate>
            <div style="border: 1px solid green; padding: 6px">
                <p><strong>Third panel</strong></p>
                <p><%=DateTime.Now.ToString() %></p>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
