<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample Layout.aspx.cs" Inherits="AzureCdnApp.layouts.AzureCdnSample" %>
<%@ OutputCache Location="None" VaryByParam="none" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Welcome to Sitecore</title>
 </head>
<body> 
  <form id="mainform" method="post" runat="server">
    <div id="MainPanel">
      <strong>Sitecore MediaLibrary to Azure CDN Sample Page</strong>
    <br />
    <sc:Image ID="Image" FieldName="Image" runat="server" width = "150" height = "100"/>
    </div>
  </form>
 </body>
</html>
