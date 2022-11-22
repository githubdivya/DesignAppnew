<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="TermsofUse.aspx.vb" Inherits="DesignApp.TermsofUse" meta:resourcekey="PageResource1" %>

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
                <asp:Label runat="server" ID="lbltermsof" Text="Terms of Use" meta:resourcekey="lbltermsofResource1"></asp:Label></h1>
           
           </div>
                        <div class="serviceDetail">
                            <p><asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="When you register for any services on"></asp:Localize> <a href="http://digitalgujarat.gov.in" style="color: blue">http://digitalgujarat.gov.in</a> <asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="we ask you for your name, contact information, preferences, and certain demographic information. This information enables us to provide personalized
 services and communicate separately with you. We also use aggregated information about the use of our services to evaluate our user's preferences, improve our programming and content delivery.
                      "></asp:Localize>  </p>
                            <br /><asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="We do not share or sell personally identifiable data with other service providers, who can use such information for commercial promotion. Our newsletter and other mailers are sent to you on your explicit instruction and you can opt out of it at any time.
                                "></asp:Localize>
                       </div>
                    </div>
                </div>
            </div>
            <div class="page text-center">
              
            </div>
        </div>

    </section>

    
        <script src="../js/bootstrap.min.js"></script>
        <script src="../js/general.js"></script>
        <script src="../js/function.js"></script>
</asp:Content>
