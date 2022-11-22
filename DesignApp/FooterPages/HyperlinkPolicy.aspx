<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="HyperlinkPolicy.aspx.vb" Inherits="DesignApp.HyperlinkPolicy" meta:resourcekey="PageResource1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="service-page">

        <div class="onlineService">
            <div class="container">
                <div class="row">

                    <div class="serviceList">
                        <div class="serviceName">
                            <h1>
                                <asp:Label runat="server" ID="lbltermsof" Text="Hyperlinking Policy" meta:resourcekey="lbltermsofResource1"></asp:Label></h1>
                        </div>
                        <div class="serviceDetail">
                            <p><asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="
                                At many places in this website, you shall find links to other websites/portals. This links have been placed for your convenience. 
 Mere presence of the link or its listing on this website should not be assumed as endorsement of any kind. We cannot guarantee that these links will work all the time and we have no control
 over availability of linked pages.
                            "></asp:Localize></p>
                            <br />
                            <p>Prior permission is required before hyperlinks are directed from any website/portal to this site. Permission for the same, stating the nature of the content on the pages from where the link has to be given and the exact language of the Hyperlink should be obtained by sending a request here</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="page text-center">
            </div>
        </div>

    </section>

</asp:Content>
