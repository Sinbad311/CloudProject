<%@ Page Title="Basics 3" Language="C#" MasterPageFile="~/Demos.Master" AutoEventWireup="true" CodeBehind="Basics3.aspx.cs" Inherits="Demos.Initiation.Basics3" %>
<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="SciptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server"> 
        <ajaxToolkit:TabPanel ID="TabPanel1" runat="server" HeaderText="1"> 
            <ContentTemplate> 
                <cc1:GMap ID="GMap1" runat="server" /> 
            </ContentTemplate> 
        </ajaxToolkit:TabPanel> 
        <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="2"> 
            <ContentTemplate> 
                Empty Tab 
            </ContentTemplate> 
        </ajaxToolkit:TabPanel> 
        <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" HeaderText="3"> 
            <ContentTemplate> 
                <cc1:GMap ID="GMap2" runat="server" /> 
            </ContentTemplate> 
        </ajaxToolkit:TabPanel> 
        <ajaxToolkit:TabPanel ID="TabPanel4" runat="server" HeaderText="4"> 
            <ContentTemplate> 
                Empty Tab 
            </ContentTemplate> 
        </ajaxToolkit:TabPanel> 
    </ajaxToolkit:TabContainer>
</asp:Content>