<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="CopyRightPolicy.aspx.vb" Inherits="DesignApp.CopyRightPolicy" meta:resourcekey="PageResource1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="service-page">

        <div class="onlineService">
            <div class="container">
                <div class="row">

                    <div class="serviceList">
                        <div class="serviceName">
                           <%-- <div class="col-md-12">--%>
                                <h1>
                                    <asp:Label runat="server" ID="Label1" Text="Copyright Policy" meta:resourcekey="Label1Resource1"></asp:Label></h1>
                           <%-- </div>--%>
                        </div>
                        <div class="serviceDetail">
                            <p><asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="
                                Material featured on this website may be reproduced free of charge after taking proper permission by sending a mail to us. However, the material has to be reproduced accurately and not to be used in a derogatory manner or in a misleading context. Wherever
 the material is being published or issued to others, the source must be prominently acknowledged. However, the permission to reproduce this material shall not extend to any material which is identified as being copyright of a third party. Authorisation to
 reproduce such material must be obtained from the departments/copyright holders concerned.
                                "></asp:Localize>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="page text-center">
            </div>
        </div>

    </section>
</asp:Content>
