<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="frmServiceGroup.aspx.vb" Inherits="DesignApp.frmServiceGroup" meta:resourcekey="PageResource1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="back"><asp:LinkButton runat="server" OnClick="Unnamed1_Click" Visible="False" meta:resourcekey="LinkButtonResource1"> <asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1">Back</asp:Localize>
</asp:LinkButton></div>
     <div class="search">
        <div class="search_part1">
            <div class="search-form">
                <label for="txtkeyword"> <asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="Search Online Services"></asp:Localize></label>
                <asp:TextBox runat="server" CssClass="txtkeyword" ID="txtkeyword" Placeholder="Search.." meta:resourcekey="txtkeywordResource1"></asp:TextBox>
                <asp:Button runat="server" CssClass="go" ID="go" Text="GO" meta:resourcekey="goResource1" />
            </div>
        </div>
        <div class="search_part2">
            <div class="filter">
                <label for="txtkeyword"> <asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="Filter Services"></asp:Localize></label>
                <asp:DropDownList ID="service_group" runat="server" AutoPostBack="True" meta:resourcekey="service_groupResource1"></asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="service-links" style="margin-top:20px;">
            <ul class="certificate_group" runat="server" id="ServiceGroup"></ul>
            <ul class="certificate_group" runat="server" id="ServiceSearch"></ul>
    </div>
</asp:Content>
