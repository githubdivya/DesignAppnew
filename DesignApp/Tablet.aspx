<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="Tablet.aspx.vb" Inherits="DesignApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            width: 211px;
        }
    </style>
    <script>

        $("#upload").fileinput({
            allowedFileExtensions: ['jpg', 'png', 'gif'],
            showUpload: 'false'
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">

        <section id="formMain">
            <!--Registration page start-->

            <%--<div class="container">
                <div class="row">
                    <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                        <div class="form uploadDoc">
                            <h2><asp:Localize ID="localize16"   runat="server" meta:resourcekey="localize16Resource1" Text="Error Page"></asp:Localize></h2>

                            <p><asp:Localize ID="localize17"   runat="server" meta:resourcekey="localize17Resource1" Text="You are not permitted to view the requested Page."></asp:Localize></p>
                            <hr />
                            <div class="form-horizontal">
                             
                                    <p> <asp:Localize ID="localize18"   runat="server" meta:resourcekey="localize18Resource1" Text=" Go back to "></asp:Localize><a id="ahref" runat="server"><asp:Localize ID="localize19"   runat="server" meta:resourcekey="localize19Resource1" Text="Home page"></asp:Localize></a> <asp:Localize ID="localize20"   runat="server" meta:resourcekey="localize20Resource1" Text="and try with your User credentials."></asp:Localize></p>
                                
                            </div>
                        </div>
                    </div>
                </div>

            </div>--%>
            <div class="container">
                <div class="row">
                    <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                        <div class="form uploadDoc">
                            <h2>Dear Students,</h2>

                            <p>To Avail the Branded Tablet, Pl. deposit Rs. 1000/- at the institute / College where you have taken the admission.</p>
                            <p>Helpline No. 079-26566000</p>
                              <p>Timing : 11 am to 5pm</p>
                              <p>Education Department Government of Gujarat</p>
                            <hr />
                            
                        </div>
                    </div>
                </div>

            </div>
        </section><!--Registration page end-->

    </div>   
     <script src="../js/jquery.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/general.js"></script>
    <script src="../js/function.js"></script>
    <%--    <script src="../js/search.min.js"></script>--%>
    <script src="../js/MapsOnline.js"></script>
</asp:Content>
