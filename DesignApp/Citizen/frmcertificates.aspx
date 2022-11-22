<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="frmcertificates.aspx.vb" Inherits="DesignApp.frmcertificates" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="back">
        <asp:LinkButton runat="server" OnClick="Unnamed1_Click" Visible="False" meta:resourcekey="LinkButtonResource1"><asp:Localize ID="localize1" runat="server" meta:resourcekey="localize1Resource1">Back</asp:Localize>
</asp:LinkButton></div>
   
    <div class="service-links">
        <ul class="certificate_group" runat="server" id="ServiceGroup"></ul>
    </div>
</asp:Content>
