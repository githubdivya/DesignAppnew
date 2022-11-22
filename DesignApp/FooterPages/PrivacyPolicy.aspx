<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="PrivacyPolicy.aspx.vb" Inherits="DesignApp.PrivacyPolicy" meta:resourcekey="PageResource1" %>

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
                                <asp:Label runat="server" ID="lbltermsof" Text="Privacy Policy" meta:resourcekey="lbltermsofResource1"></asp:Label>
                            </h1>

                        </div>
                        <div class="serviceDetail">
                            <p><asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="
                                As a general rule, this website does not collect Personal Information about you when you visit the site. You can generally visit the site without revealing Personal Information, unless you choose to provide such information.
                            "></asp:Localize></p>
                            <br />

                            <h3><asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="Site Visit Data"></asp:Localize></h3>
                             <br />
                            <p>
                                <asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="
                                This website records your visit and logs the following information for statistical purposes your server's address; the name of the top-level domain from which you access the Internet (for example, .gov, .com, .in, etc.); the type of browser you use; the
 date and time you access the site; the pages you have accessed and the documents downloaded and the previous Internet address from which you linked directly to the site.
                           "></asp:Localize>
                            </p>
                            <br />


                           <%-- <p><asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize4Resource1" Text="We will not identify users or their browsing activities, except when a law enforcement agency may exercise a warrant to inspect the service provider's logs."></asp:Localize></p>
                            <br />--%>
                            <%--<h3><asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize5Resource1" Text="Cookies"></asp:Localize></h3>
                             <br />
                            <p><asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize6Resource1" Text="A cookie is a piece of software code that an internet web site sends to your browser when you access information at that site. This site does not use cookies."></asp:Localize></p>
                            <br />
                            <h3><asp:Localize ID="localize7"   runat="server" meta:resourcekey="localize7Resource1" Text="Collection of Personal Information"></asp:Localize></h3>
                            <br />
                            <p><asp:Localize ID="localize8"   runat="server" meta:resourcekey="localize8Resource1" Text="
                                If you are asked for any other Personal Information you will be informed how it will be used if you choose to give it. If at any time you believe the principles referred to in this privacy statement have not been followed, or have any other comments on these
 principles, please notify the webmaster through the contact us page.
                                "></asp:Localize>
                            </p>--%>
                        </div>
                    </div>
                </div>
            </div>
            <div class="page text-center">
            </div>
        </div>

    </section>

</asp:Content>
