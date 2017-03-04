<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sample.ascx.cs" Inherits="AzureCdnApp.layouts.Sample" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
Hi this is me 
<br />
<asp:Literal ID="test" runat ="server"></asp:Literal>
<br />
<sc:FieldRenderer ID="Image" FieldName="Image" runat="server" />

<sc:Image ID="FieldRenderer1" Field="Image" runat="server" />