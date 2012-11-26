<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>American Football Weather</title>
</head>
<body>
    <form id="form1" runat="server">
<h1>
    <asp:Image ID="NFL" ImageUrl="images/NFL.jpg" runat="server" Height="83px" 
        Width="921px" />
    </h1>
    <asp:ScriptManager 
    ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
 
    <div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <cc1:GMap ID="GMap1" runat="server" Width="400px" Height="300px"
        enableHookMouseWheelToZoom="True"  />
        
    </ContentTemplate>
    </asp:UpdatePanel>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server">Enter Zip Code</asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Enter Zip &amp; Click" />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server"></asp:Label>
    <br />
    
    <asp:Image ID="Image1" runat="server" Height="115px" Width="102px" 
        BorderStyle="None" />
    <br />
    </form>
</body>
</html>
