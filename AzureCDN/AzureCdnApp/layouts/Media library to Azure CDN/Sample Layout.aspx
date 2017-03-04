<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample Layout.aspx.cs" Inherits="AzureCdnApp.layouts.AzureCdnSample" %>
<%@ OutputCache Location="None" VaryByParam="none" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Welcome to Sitecore</title>
    <style>
        header, footer {
        padding: 1em;
        color: white;
        background-color: black;
        clear: left;
        text-align: center;
    }
        img {
        width: 100%;
    }
    </style>
 </head>
<body> 
  <form id="mainform" method="post" runat="server">
    <div id="MainPanel">
        <header>
   <h1>Sitecore MediaLibrary to Azure CDN Sample Page</h1>
</header>

    <br />
    <sc:Image ID="Image" Field="Image" runat="server" Height="500" />
    </div>
  </form>
 </body>
</html>
