<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="MoreDepartment.aspx.vb" Inherits="DesignApp.MoreDepartment" meta:resourcekey="PageResource1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<script src="../js/jquery.min.js"></script>--%>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/general.js"></script>
    <script src="../js/function.js"></script>
   <%-- <script src="../js/search.min.js"></script>--%>
    <script src="../js/MapsOnline.js"></script>
    <section id="form">
         
        <!--Service page start-->
        <div class="container">

            <div class="row">
                <div class="col-md-12">
                    <br />
                            <h1> <asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="Departments of the Government"></asp:Localize></h1>
                </div>
            </div>
            <div class="row">
                <ul class="list-group">
                            <li class="list-group-item list-group-item-success"><a href="http://www.agri.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="Agriculture"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://geda.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="Climate Change"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://gujarat-education.gov.in" target="_blank">
                                <h4><asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize4Resource1" Text="Education"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://guj-epd.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize5Resource1" Text="Energy &amp; Petrochemicals"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://financedepartment.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize6Resource1" Text="Finance"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://www.fcsca.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize7"   runat="server" meta:resourcekey="localize7Resource1" Text="Food &amp; Civil Supplies Department"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://www.envforguj.in/" target="_blank">
                                <h4><asp:Localize ID="localize8"   runat="server" meta:resourcekey="localize8Resource1" Text="Forest &amp; Environment"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://gad.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize9"   runat="server" meta:resourcekey="localize9Resource1" Text="General Administration Department"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://gujhealth.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize10"   runat="server" meta:resourcekey="localize10Resource1" Text="Health &amp; Family Welfare"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://home.gujarat.gov.in/homedepartment/frmMain.aspx" target="_blank">
                                <h4><asp:Localize ID="localize11"   runat="server" meta:resourcekey="localize11Resource1" Text="Home"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://imd-gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize12"   runat="server" meta:resourcekey="localize12Resource1" Text="Industries &amp; Mines"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://www.gujaratinformation.net/" target="_blank">
                                <h4><asp:Localize ID="localize13"   runat="server" meta:resourcekey="localize13Resource1" Text="Information"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://www.labour.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize14"   runat="server" meta:resourcekey="localize14Resource1" Text="Labour &amp; Employment"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://lpd.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize15"   runat="server" meta:resourcekey="localize15Resource1" Text="Legeslative &amp; Parliamentary"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://panchayat.gujarat.gov.in/panchayatvibhag/" target="_blank">
                                <h4><asp:Localize ID="localize16"   runat="server" meta:resourcekey="localize16Resource1" Text="Panchayat"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://pnt.gujarat.gov.in/pnt/frmMain.aspx" target="_blank">
                                <h4><asp:Localize ID="localize17"   runat="server" meta:resourcekey="localize17Resource1" Text="Ports &amp; Transport"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://revenuedepartment.gujarat.gov.in" target="_blank">
                                <h4><asp:Localize ID="localize18"   runat="server" meta:resourcekey="localize18Resource1" Text="Revenue"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://rnbgujarat.org/" target="_blank">
                                <h4><asp:Localize ID="localize19"   runat="server" meta:resourcekey="localize19Resource1" Text="Road &amp; Building"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://dst.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize20"   runat="server" meta:resourcekey="localize20Resource1" Text="Science &amp; Technology"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://sje.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize21"   runat="server" meta:resourcekey="localize21Resource1" Text="Social Justice &amp; Empowerment"></asp:Localize><</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://www.sycd.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize22"   runat="server" meta:resourcekey="localize22Resource1" Text="Sports"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://tribal.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize23"   runat="server" meta:resourcekey="localize23Resource1" Text="Tribal"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://udd.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize24"   runat="server" meta:resourcekey="localize24Resource1" Text="Urban"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://wcd.gujarat.gov.in/" target="_blank">
                                <h4><asp:Localize ID="localize25"   runat="server" meta:resourcekey="localize25Resource1" Text="Women &amp; Child"></asp:Localize></h4>
                            </a></li>
                        </ul>
            </div>
        </div>

    </section>
</asp:Content>
