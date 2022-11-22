<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="CitizenService.aspx.vb" Inherits="DesignApp.CitizenService" meta:resourcekey="PageResource1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /*.onlineService .serviceList .serviceDetail .detailDes.service_image{
            background-image:url('../images/ration.png');
            background-repeat:no-repeat;
            background-position:left top;
            padding:0px 0px 10px 85px;
        }
        .onlineService .serviceList:hover .serviceDetail .detailDes.service_image:hover{
            background-repeat:no-repeat;
            background-position:left top;
            padding:0px 0px 10px 85px;
        }*/
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="service-page">

        <div class="bannerArea">
            <!--Banner area start-->
            <div class="container">
                <div class="row">
                    <div class="ban">
                        <div class="col-md-6 col-sm-8">
                            <div class="row">
                                <div class="roundArea">
                                    <div class="col-md-4 col-sm-4">
                                        <div class="roundone">
                                            <div class="innerNum">
                                               <asp:Label ID ="lblservicecount" runat ="server" Text=""></asp:Label>
                                            </div>
                                        </div>
                                        <div class="roundtwo">
                                            <div class="innerNum">
                                                426
                                            </div>
                                            <div class="caror">
                                                crore
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-8 col-sm-8">
                                        <div class="dashLine">
                                            <div class="dash">
                                                <h1><span class="red">
                                                     <asp:Localize ID="localize3" runat="server" meta:resourcekey="localize11Resource1" Text="Online"></asp:Localize>
                                                    </span> <asp:Localize ID="localize4" runat="server" meta:resourcekey="localize12Resource1" Text="Government Services"></asp:Localize></h1>
                                                <p><span class="blu"><asp:Localize ID="localize5" runat="server" meta:resourcekey="localize13Resource1" Text="Jan Seva Kendra"></asp:Localize></span>
                                                     <asp:Localize ID="localize6" runat="server" meta:resourcekey="localize14Resource1" Text="provides one stop solutions"></asp:Localize>
                                                         </p>
                                            </div>
                                            <div class="botDash">
                                                <h1><span class="yellow"><asp:Localize ID="localize7" runat="server" meta:resourcekey="localize11Resource1" Text="Online"></asp:Localize></span></h1>
                                                <h1><span class="blu borderOver"><asp:Localize ID="localize8" runat="server" meta:resourcekey="localize15Resource1" Text="e"></asp:Localize></span>
                                                     - <asp:Localize ID="localize9" runat="server" meta:resourcekey="localize16Resource1" Text="Transactions"></asp:Localize></h1>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 col-sm-4 pull-right">
                        <img style="width:100%"; src="../images/service_banner.png" title="Digital Gujarat Banner"/>
                    </div>
                </div>
            </div>
        </div>
       <!--Banner area end-->

        <div class="searchArea">
            <div class="container">
                <div class="row">
                    <div class="form-inline">
                        <div class="form-group searchBoxService col-md-7">
                            <asp:Label runat="server" CssClass="servicelabel" meta:resourcekey="LabelResource1" Text="Search Online Services"></asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtsearch" placeholder="Search Digital gujarat" meta:resourcekey="txtsearchResource1"></asp:TextBox>
                            <span>
                                <button runat="server" id="go" class="btn btn-info" type="button">
                                    <asp:Localize ID="localize2" runat="server" meta:resourcekey="localize2Resource1" Text="GO"></asp:Localize>
                                </button>
                            </span>
                        </div>
                        <div class="form-group searchBoxService">
                            <asp:Label runat="server" CssClass="servicelabel" meta:resourcekey="LabelResource2" Text="Filter Services"></asp:Label>
                            <div class="form-group ">
                                <asp:DropDownList ID="service_group" class="selectpicker"
                                    runat="server" AutoPostBack="True" meta:resourcekey="service_groupResource1">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div class="onlineService">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <asp:Localize ID="localize1" runat="server" meta:resourcekey="localize1Resource1" Text="Online Services"></asp:Localize>
                    </div>

                    <div runat="server" id="service_list">
                        <%--<div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Application for New Ration Card</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes ration">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Economically Backward Certificate</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes ebackward">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Farmer Certificate</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes farmar">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Senior Citizen Certificate</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes senior">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Income Certificate</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes income">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Hotel License Renewal</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes hotel">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Caste Converted into Buddhism</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes buddh">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Educationally Backward Class Certificate</h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes eduback">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-4 col-sm-6">
                            <a href="#">
                                <div class="serviceList">
                                    <div class="serviceName">
                                        <h3>Renewal of Arms Licence </h3>
                                    </div>
                                    <div class="serviceDetail">
                                        <div class="detailDes arm">
                                            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>--%>
                    </div>
                </div>
            </div>
            <%--<div class="page text-center">
                <nav>
                    <ul class="pagination">
                        <li class="disabled"><a href="#" aria-label="Previous"><i class="fa fa-chevron-left"></i></a></li>
                        <li class="active"><a href="#">1 <span class="sr-only">
                            <asp:Localize ID="localize3" runat="server" meta:resourcekey="localize3Resource1" Text="(current)"></asp:Localize></span></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize4" runat="server" meta:resourcekey="localize4Resource1" Text="1"></asp:Localize></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize5" runat="server" meta:resourcekey="localize5Resource1" Text="2"></asp:Localize></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize6" runat="server" meta:resourcekey="localize6Resource1" Text="3"></asp:Localize></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize7" runat="server" meta:resourcekey="localize7Resource1" Text="4"></asp:Localize></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize8" runat="server" meta:resourcekey="localize8Resource1" Text="5"></asp:Localize></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize9" runat="server" meta:resourcekey="localize9Resource1" Text="6"></asp:Localize></a></li>
                        <li><a href="#">
                            <asp:Localize ID="localize10" runat="server" meta:resourcekey="localize10Resource1" Text="7"></asp:Localize></a></li>
                        <li><a href="#" aria-label="Next"><i class="fa fa-chevron-right"></i></a></li>
                    </ul>
                </nav>
            </div>--%>
        </div>
    </section>
    <script src="../js/jquery.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/general.js"></script>
    <script src="../js/function.js"></script>
    <%--    <script src="../js/search.min.js"></script>--%>
    <script src="../js/MapsOnline.js"></script>
    </span>
                                                    </span>
    </section>
                                                    </span>
    </section>
</asp:Content>
