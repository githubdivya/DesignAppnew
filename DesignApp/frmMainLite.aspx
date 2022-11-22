<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmMainLite.aspx.vb" Inherits="DesignApp.frmMainLite" %>
<!DOCTYPE html>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=1" />
    <meta http-equiv="X-UA-Compatible" content="IE=Edge" />
    <title>Digital Gujarat</title>
    <link rel="shortcut icon" href="Lite/images/favicon.ico"/>
    <link type="text/css" href="Lite/css/font-awesome.min.css" rel="stylesheet"/>
    <link type="text/css" href="Lite/css/style.css" rel="stylesheet"/>
    <link type="text/css" href="Lite/css/responsive.css" rel="stylesheet"/>
    <link type="text/css" href="Lite/css/font-awesome.min" rel="stylesheet"/>
    <script type="text/javascript" src="Lite/js/modernizr.js"></script>
    <script type="text/javascript" src="Lite/js/jquery-min.js"></script>
    <!--[if lte IE 9]>
  <script src="js/ie.js" type="text/javascript"></script>
<![endif]-->
</head>
<body>
    <form runat="server">
        <noscript class="jsRequired">
            This page uses Javascript. Your browser either doesn't support Javascript or you have it turned off. To see this page as it is meant to appear please use a Javascript enabled browser.
        </noscript>
        <!--#wrapper-->
        <div id="wrapper">
            <!--#header-->
            <header id="header">
                <!--.topStrip-->
                <div class="topStrip cf">
                    <div class="container">
                        <ul class="leftLink">
                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/frmmainLite.aspx">Home</a></li>

                            <li><a class="contact " href='<%=ResolveUrl("~/Citizen/ContactUs.aspx")%>'>
                                <asp:Localize ID="localize14" runat="server" meta:resourcekey="localize14Resource1" Text="Contact"></asp:Localize></a></li>
                        </ul>
                        <ul class="rightLinks">
                            <li><a runat="server" tabindex="1" href="#content">Skip to Main Content</a></li>
                            <li><a runat="server" href="#">Screen Reader Access</a></li>
                            <li class="fontResize">
                                <div id="accessControl" class="textResizeWrapper">
                                    <input type="button" name="font_normal" value="A" id="font_normal" title="Normal Font Size" class="fontScaler normal font-normal" />
                                    <input type="button" name="font_large" value="A" id="font_large" title="Normal Font Size" class="fontScaler normal font-normal" />
                                    <input type="button" name="font_larger" value="A+" id="font_larger" title="Increase Font Size" class="fontScaler large font-large" />
                                    <input type="button" name="normal" value="Standard View" id="normal" title="Standard View" class="contrastChanger normal current" />
                                    <input type="button" name="wob" value="High Contrast View" id="wob" title="High Contrast View" class="contrastChanger wob" />
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <!--/.topStrip-->
                <!--.logoAndSearch-->
                <div class="logoAndSearch">
                    <div class="container">
                        <h1 id="logo"><a runat="server" href="index.html" title="Digital Gujarat">
                            <img src="images/logo.png" alt="Digital Gujarat" width="268" height="61">
                        </a></h1>
                        <div class="headerTopRight">
                            <ul class="topPart">
                                <li>
                                    <asp:LinkButton ID="lnklogin" runat="server">
                                        <asp:Localize ID="localize8" runat="server" meta:resourcekey="localize2Resource1" Text="Login "></asp:Localize>
                                        &nbsp;<i class="fa fa-user"></i>
                                    </asp:LinkButton></li>
                                <li>
                                    <asp:LinkButton ID="lnkregistation" runat="server">
                                        <asp:Localize ID="localize9" runat="server" meta:resourcekey="localize2Resource1" Text="Registration"></asp:Localize>
                                        &nbsp;<i class="fa fa-user"></i>
                                    </asp:LinkButton></li>
                                <li><a runat="server" href="#" class="searchIcon"><i class="fa fa-search"></i></a>
                                    <div class="searchBox">
                                        <asp:TextBox ID="txtSearchCity" placeholder="Search City like Gandhinagar" runat="server" CssClass="#search"></asp:TextBox>
                                        <cc1:AutoCompleteExtender ID="AutoCitySearch" runat="server" TargetControlID="txtSearchCity"
                                            ServiceMethod="GetSearchCityList"
                                            MinimumPrefixLength="2"
                                            CompletionInterval="1"
                                            EnableCaching="true"
                                            CompletionSetCount="20"
                                            CompletionListCssClass="autocomplete_completionListElement"
                                            CompletionListItemCssClass="autocomplete_listItem"
                                            CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                                            DelimiterCharacters=";, :">
                                        </cc1:AutoCompleteExtender>
                                        <asp:Button ID="btnSearchGo" CssClass="searchBtn" runat="server" />

                                    </div>
                                </li>
                            </ul>
                            <div id="mainNav" class="mainNavigation">
                                <nav class="menuPart cf">
                                    <ul id="nav">
                                        <li><a runat="server" href="#">About Gujarat</a>
                                            <ul>
                                                <li><a href="http://gujaratindia.com/about-gujarat/gujarat-at-glance.htm" target="_blank">
                                                    <asp:Localize ID="localize24" runat="server" Text="Gujarat at a Glance " meta:resourcekey="localize24Resource1"></asp:Localize></a></li>
                                                <li><a href="http://gujaratindia.com/about-gujarat/history-1.htm" target="_blank">
                                                    <asp:Localize ID="localize25" runat="server" Text="Gujarat History " meta:resourcekey="localize25Resource1"></asp:Localize></a></li>
                                                <li><a href="http://gujaratindia.com/about-gujarat/fact-file.htm" target="_blank">
                                                    <asp:Localize ID="localize10" runat="server" Text="Gujarat Fact File" meta:resourcekey="localize5Resource1"></asp:Localize></a></li>
                                                <li><a href="http://gujaratindia.com/about-gujarat/getting-guj.htm" target="_blank">
                                                    <asp:Localize ID="localize26" runat="server" Text="Getting to Gujarat " meta:resourcekey="localize26Resource1"></asp:Localize></a></li>
                                                <li>
                                                    <asp:LinkButton ID="lnkchangecity" runat="server" Text="Office Detail " meta:resourcekey="localizeofficedetail1"></asp:LinkButton></li>
                                            </ul>
                                        </li>

                                        <li><a runat="server" href="#">Services Sectors</a>
                                            <ul>
                                                <li><a href='<%=ResolveUrl("~/Citizen/CitizenService.aspx")%>' target="_blank">
                                                    <asp:Localize ID="localize27" runat="server" Text="Citizen Services" meta:resourcekey="localize27Resource1"></asp:Localize></a></li>
                                                <li><a href="http://www.ifpgujarat.gov.in/portal/index.jsp" target="_blank">
                                                    <asp:Localize ID="localize28" runat="server" Text="Business Services" meta:resourcekey="localize28Resource1"></asp:Localize></a></li>
                                                <li><a href="http://financedepartment.gujarat.gov.in/" target="_blank">
                                                    <asp:Localize ID="localize29" runat="server" Text="Financial Services" meta:resourcekey="localize29Resource1"></asp:Localize></a></li>
                                            </ul>
                                        </li>

                                        <li><a runat="server" href="#">State</a>
                                            <ul>
                                                <li><a href="http://lpd.gujarat.gov.in/htm/acts.htm" target="_blank">
                                                    <asp:Localize ID="localize30" runat="server" Text="Acts & Rules " meta:resourcekey="localize30Resource1"></asp:Localize></a></li>
                                                <li><a href="http://financedepartment.gujarat.gov.in/Budget.html" target="_blank">
                                                    <asp:Localize ID="localize31" runat="server" Text="Budget" meta:resourcekey="localize31Resource1"></asp:Localize></a></li>
                                            </ul>
                                        </li>
                                        <li><a runat="server" href="http://www.gujaratindia.com/state-profile/awards.htm">Awards</a></li>
                                        <%--<li><a runat="server" href="#">E-Citizen</a></li>--%>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
                <!--/.logoAndSearch-->
            </header>
            <!--/#header-->
            <!--#mainBanner-->
            <section id="mainBanner" class="mainBannerWrap">
                <div class="container">
                    <!--#bannerSliderAndTagLine-->
                    <div class="bannerSliderAndTagLine cf">
                        <!--.tagLineWrap-->
                        <%-- <div class="tagLineWrap">
          <div class="tagLine"> <span class="captionText vCenter">Why Stand In Line<br>
            Come Online</span> </div>
        </div>--%>
                        <!--/.tagLineWrap-->
                        <!--.bannerSliderWrap-->
                        <div class="bannerSliderWrap">
                            <div class="counterSliderWrap">
                                <h2>Digital Gujarat</h2>
                                <div class="counterSlider">
                                    <div class="swiper-container">
                                        <div class="swiper-wrapper">
                                            <asp:Literal ID="ltcount" runat="server"></asp:Literal>
                                            <%--  <div class="swiper-slide" style="width: 24px;"><span class="count">1520</span> <span class="countTitle">Ration Card</span></div>
                                            <div class="swiper-slide" style="width: 24px;"><span class="count">1740</span> <span class="countTitle">Renewal</span></div>
                                            <div class="swiper-slide" style="width: 24px;"><span class="count">1010</span> <span class="countTitle">Certificates</span></div>
                                            <div class="swiper-slide" style="width: 24px;"><span class="count">1269</span> <span class="countTitle">E-Jamin</span></div>
                                            <div class="swiper-slide" style="width: 24px;"><span class="count">1440</span> <span class="countTitle">Scholarship</span></div>
                                            <div class="swiper-slide" style="width: 24px;"><span class="count">652</span> <span class="countTitle">Other</span></div>--%>
                                        </div>
                                    </div>
                                    <div class="swiper-button-next1"><i class="fa fa-chevron-right"></i></div>
                                    <div class="swiper-button-prev1"><i class="fa fa-chevron-left"></i></div>
                                </div>
                            </div>
                        </div>
                        <!--/.bannerSliderWrap-->
                    </div>
                    <!--/#bannerSliderAndTagLine-->
                    <!--#servicesSectorsWrap-->
                    <div class="servicesSectorsWrap cf">
                        <ul class="bannerSectors">
                            <li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" target="_blank" class="scholarship"><span class="scholarshipIcon sectorsIcon">Student Corner</span> <span class="sectorTitle">Scholarship</span></a>
                                    <div class="subMenuList singleCols cf">
                                        <ul class="orangeDotText">
                                            <li><a runat="server" href='<%=ResolveUrl("~/Citizen/CitizenService.aspx?id=0")%>'>
                                                <asp:Localize ID="localize32" runat="server" Text="Scholarship"></asp:Localize></a>



                                            </li>
                                            <li><a runat="server" href='<%=ResolveUrl("~/Tablet.aspx")%>'>
                                                <asp:Localize ID="localize35" runat="server" Text="Student Tablet"></asp:Localize></a>



                                            </li>
                                            <li><a runat="server" href='<%=ResolveUrl("~/Citizen/ServiceDescription.aspx?ServiceID=605")%>'>
                                                <asp:Localize ID="localize36" runat="server" Text="Hostel"></asp:Localize></a>



                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" class="employement hasMenu"><span class="employmentIcon sectorsIcon">Employment</span> <span class="sectorTitle">Employment</span></a>
                                    <div class="subMenuList singleCols cf">
                                        <ul class="orangeDotText">
                                            <li><a runat="server" href="https://ojas.gujarat.gov.in/" target="_blank">
                                                <asp:Localize ID="localize56" runat="server" Text="Government Jobs" meta:resourcekey="localize56Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="http://iic.gcvt.org/index.aspx#.VdwmmiWqqko" target="_blank">
                                                <asp:Localize ID="localize61" runat="server" Text="Industry Interface Cell" meta:resourcekey="localize61Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="https://empower.gujarat.gov.in/" target="_blank">
                                                <asp:Localize ID="localize64" runat="server" Text="eMpower " meta:resourcekey="localize64Resource1"></asp:Localize>
                                            </a></li>
                                        </ul>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" class="services hasMenu"><span class="servicesIcon sectorsIcon">Services</span> <span class="sectorTitle">Services</span></a>
                                    <div class="subMenuList doubleCols cf">
                                        <ul class="orangeDotText">
                                            <li><a runat="server" href="~/Citizen/CitizenService.aspx">
                                                <asp:Localize ID="localize6" runat="server" Text="Citizen Services" meta:resourcekey="localize6Resource1"></asp:Localize>
                                            </a></li>
                                            <%-- <li><a  runat="server"href='<%=ResolveUrl("~/CitizenApp/Citizen/CitizenWEBUI/Registration.aspx?City="+lbllocation.Text ) %>'>
                                                                    <asp:Localize ID="localize21" runat="server" Text="Digital Gujarat Registration" meta:resourcekey="localize21Resource1"></asp:Localize></a></li>--%>
                                            <li><a runat="server" href="https://incometaxindiaefiling.gov.in/e-Filing/Services/KnowYourPanLink.html">
                                                <asp:Localize ID="localize7" runat="server" Text="PAN Card" meta:resourcekey="localize100Resource1"></asp:Localize></a></li>

                                            <li><a runat="server" href="https://digilocker.gov.in">
                                                <asp:Localize ID="localize15" runat="server" Text="Digital Locker" meta:resourcekey="localize101Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="http://electoralsearch.in">
                                                <asp:Localize ID="localize16" runat="server" Text="Election ID" meta:resourcekey="localize102Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://vahan.nic.in/nrservices/faces/user/jsp/SearchStatus.jsp">
                                                <asp:Localize ID="localize17" runat="server" Text="Vehicle Registration Details" meta:resourcekey="localize103Resource1"></asp:Localize>
                                            </a></li>
                                           <%-- <li><a runat="server" href="https://digilocker.gov.in">
                                                <asp:Localize ID="localize1" runat="server" Text="Digital Locker" meta:resourcekey="localize101Resource1"></asp:Localize></a></li>--%>
                                            <%--<li><a runat="server" href="http://electoralsearch.in">
                                                <asp:Localize ID="localize2" runat="server" Text="Election ID" meta:resourcekey="localize102Resource1"></asp:Localize></a></li>--%>
                                           <%-- <li><a runat="server" href="https://vahan.nic.in/nrservices/faces/user/jsp/SearchStatus.jsp">
                                                <asp:Localize ID="localize3" runat="server" Text="Vehicle Registration Details" meta:resourcekey="localize103Resource1"></asp:Localize>
                                            </a></li>--%>
                                            <li><a runat="server" href="http://www.gseb.org/">
                                                <asp:Localize ID="localize18" runat="server" Text="Latest GSEB Exam Results" meta:resourcekey="localize104Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://eaadhaar.uidai.gov.in/">
                                                <asp:Localize ID="localize19" runat="server" Text="Aadhar Card" meta:resourcekey="localize105Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://anyror.gujarat.gov.in/">
                                                <asp:Localize ID="localize20" runat="server" Text="AnyRoR" meta:resourcekey="localize106Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="http://garvi.gujarat.gov.in">
                                                <asp:Localize ID="localize22" runat="server" Text="gARVI-Registered Document <br/> & Jantri Rates" meta:resourcekey="localize104Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="">
                                                <asp:Localize ID="localize23" runat="server" Text="Property Card" meta:resourcekey="localize105Resource1"></asp:Localize></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" class="revenue hasMenu"><span class="revenueIcon sectorsIcon">Revenue</span> <span class="sectorTitle">Revenue</span></a>
                                    <div class="subMenuList doubleCols cf">
                                        <ul class="orangeDotText">
                                          <%--  <li><a  runat="server"  href='<%=Convert.ToString("https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=63")%>'>
                                                                    <asp:Localize ID="localize80" runat="server" Text="Income certificate" meta:resourcekey="localize80Resource1"></asp:Localize>
                                                                </a></li>--%>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=64">
                                                <asp:Localize ID="localize81" runat="server" meta:resourcekey="localize81Resource1" Text="Socially & Educationally Backward Class Certificate "></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=65">
                                                <asp:Localize ID="localize82" runat="server" meta:resourcekey="localize82Resource1" Text="SC/ST Caste Certificate"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=82">
                                                <asp:Localize ID="localize72" runat="server" Text="Non-Creamylayer Certificate " meta:resourcekey="localize72Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=362">
                                                <asp:Localize ID="localize73" runat="server" Text="Non-Creamylayer Certificate For Central Goverment" meta:resourcekey="localize73Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=66">
                                                <asp:Localize ID="localize74" runat="server" Text="Temporary Residence Certificate" meta:resourcekey="localize74Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=71">
                                                <asp:Localize ID="localize77" runat="server" Text="Application for Varsai Certificate" meta:resourcekey="localize77Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=77">
                                                <asp:Localize ID="localize78" runat="server" Text="Senior Citizen Certificate" meta:resourcekey="localize78Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=79">
                                                <asp:Localize ID="localize79" runat="server" Text="Religious Minority Certificate" meta:resourcekey="localize79Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="~/Citizen/CitizenService.aspx">
                                                <asp:Localize ID="localize4" runat="server" Text="More" meta:resourcekey="localize89Resource1"></asp:Localize></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" class="panchayat hasMenu"><span class="panchayatIcon sectorsIcon">Panchayat</span> <span class="sectorTitle">Panchayat</span></a>
                                    <div class="subMenuList doubleCols cf">
                                        <ul class="orangeDotText">

                                            <%--<li><a runat="server" href='<%=Convert.ToString("https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=309")%>'>
                                                <asp:Localize ID="localize83" runat="server" Text="Economically Backward Certificate" meta:resourcekey="localize83Resource1"></asp:Localize>
                                            </a></li>--%>

                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=309">
                                                <asp:Localize ID="localize83" runat="server" Text="Economically Backward Certificate" meta:resourcekey="localize83Resource1"></asp:Localize>
                                            </a></li>

                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=310">
                                                <asp:Localize ID="localize84" runat="server" meta:resourcekey="localize84Resource1" Text="Widow Certificate "></asp:Localize>
                                            </a></li>

                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=307">
                                                <asp:Localize ID="localize85" runat="server" meta:resourcekey="localize85Resource1" Text="Income certificate"></asp:Localize>
                                            </a></li>

                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=311">
                                                <asp:Localize ID="localize68" runat="server" Text="SC/ST Caste Certificate" meta:resourcekey="localize72Resource1"></asp:Localize>
                                                </a></li>

                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=308">
                                                <asp:Localize ID="localize69" runat="server" Text="Religious Minority Certificate" meta:resourcekey="localize73Resource1"></asp:Localize>
                                                </a></li>

                                            <li><a runat="server" href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=366">
                                                <asp:Localize ID="localize70" runat="server" Text="Socially & Educationally Backward Class Certificate " meta:resourcekey="localize74Resource1"></asp:Localize>
                                            </a></li>

                                           <%-- <li><a runat="server" href='<%=ResolveUrl("~/Citizen/CitizenService.aspx")%>'>
                                                <asp:Localize ID="localize5" runat="server" Text="More"></asp:Localize>
                                                </a></li>--%>
                                            <li><a runat="server" href="~/Citizen/CitizenService.aspx">
                                                <asp:Localize ID="localize5" runat="server" Text="More" meta:resourcekey="localize89Resource1"></asp:Localize></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </li>

                            <%--<li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" target="_blank" class="scholarship"><span class="scholarshipIcon sectorsIcon">Student Corner</span> <span class="sectorTitle">Scholarship</span></a>
                                    <div class="subMenuList singleCols cf">
                                        <ul class="orangeDotText">
                                            <li><a runat="server" href='<%=ResolveUrl("~/Citizen/CitizenService.aspx?id=0")%>'>
                                                <asp:Localize ID="localize32" runat="server" Text="Scholarship"></asp:Localize></a>



                                            </li>
                                            <li><a runat="server" href='<%=ResolveUrl("~/Tablet.aspx")%>'>
                                                <asp:Localize ID="localize35" runat="server" Text="Student Tablet"></asp:Localize></a>



                                            </li>
                                            <li><a runat="server" href='<%=ResolveUrl("~/Citizen/ServiceDescription.aspx?ServiceID=605")%>'>
                                                <asp:Localize ID="localize36" runat="server" Text="Hostel"></asp:Localize></a>



                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </li>--%>
                            <li>
                                <div class="bannerSectorWrap">
                                    <a runat="server" href="#" class="tourism hasMenu"><span class="tourismIcon sectorsIcon">Tourism</span> <span class="sectorTitle">Tourism</span></a>
                                    <div class="subMenuList doubleCols cf">
                                        <ul class="orangeDotText">
                                            <li><a runat="server" href="http://www.gujarattourism.com" target="_blank">
                                                <asp:Localize ID="localize52" runat="server" Text="Gujarat Tourism" meta:resourcekey="localize52Resource1"></asp:Localize></a></li>
                                            <li><a runat="server" href="http://www.gujarattourism.com/hubs/" target="_blank">
                                                <asp:Localize ID="localize53" runat="server" Text="Places to visit " meta:resourcekey="localize53Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="http://www.cottage.gujarat.gov.in/eng/?page_id=487" target="_blank">
                                                <asp:Localize ID="localize54" runat="server" Text="Key Attractions" meta:resourcekey="localize54Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="https://girlion.gujarat.gov.in" target="_blank">
                                                <asp:Localize ID="localize62" runat="server" Text="GIR - Online Permit Booking" meta:resourcekey="localize62Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="http://www.somnath.org/" target="_blank">
                                                <asp:Localize ID="localize63" runat="server" Text="Somnath" meta:resourcekey="localize63Resource1"></asp:Localize>
                                            </a></li>
                                            <li><a runat="server" href="http://booking.gujarattourism.com/" target="_blank">
                                                <asp:Localize ID="localize55" runat="server" Text="State Tourism Online Booking" meta:resourcekey="localize55Resource1"></asp:Localize>
                                            </a></li>
                                        </ul>
                                    </div>
                                </div>
                        </ul>
                    </div>
                    <!--/#servicesSectorsWrap-->
                </div>
            </section>
            <!--/#mainBanner-->
            <!--#whatsNew-->
            <section class="whatsNew" id="whatsNew">
                <!--.container-->
                <div class="container">
                    <!--.latestUpdateWrap-->
                    <div class="whatsNewWrap cf">
                        <div class="whatsNewTitle">
                            <h2>Whats New</h2>
                        </div>
                        <div class="newPart">
                            <div class="marqueeScrolling newsScrollingWrap cf">
                                <ul id="js_Notification" class="marquee cf">
                                    <li><a runat="server" href="#">In Gujarat's Kutch, Children Experience The Joys Of Internet For First Time, Tuesday April 11, 2017</a></li>
                                    <li><a runat="server" href="#">In Gujarat's Kutch, Children Experience The Joys Of Internet For First Time, Tuesday April 11, 2017</a></li>
                                    <li><a runat="server" href="#">In Gujarat's Kutch, Children Experience The Joys Of Internet For First Time, Tuesday April 11, 2017</a></li>
                                    <li><a runat="server" href="#">In Gujarat's Kutch, Children Experience The Joys Of Internet For First Time, Tuesday April 11, 2017</a></li>
                                </ul>
                            </div>
                            <a runat="server" class="btnMPause alignRight" href="">Pause</a>
                        </div>
                    </div>
                    <!--/.latestUpdateWrap-->
                </div>
                <!--/.container-->
            </section>
            <!--/#whatsNew-->
            <!--/#homeContent-->
            <section id="content" class="homeContent">
                <div class="container">
                    <h2 class="displayNone">Home Content Box</h2>
                    <div class="col3Box cf">
                        <%--<div class="colBox oneThirdBox contentBlockBg">
                            <div class="minsterInfoWrap cf">
                                <div class="minsterBox cf">
                                    <div class="ministerImg">
                                        <img src="images/14gov5.jpg" width="78" height="77" alt="Om Prakash Kohli, Hon. Governor, Gujarat" title="Om Prakash Kohli, Hon. Governor, Gujarat" />
                                    </div>
                                    <div class="ministerDetail">
                                        <h3>Shree Acharya Dev Vrat </h3>
                                        <p>Hon. Governor, Gujarat</p>
                                    </div>
                                </div>
                                <div class="minsterBox cf">
                                    <div class="ministerImg">
                                        <img src="images/cm-img.png" width="78" height="77" alt="Shri Vijaybhai R. Rupani, Hon. Chief Minister, Gujarat" title="Shri Vijaybhai R. Rupani, Hon. Chief Minister, Gujarat" />
                                    </div>
                                    <div class="ministerDetail">
                                        <h3>Shri Vijaybhai R. Rupani</h3>
                                        <p>Hon. Chief Minister, Gujarat</p>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                        <div class="colBox oneThirdBox contentBlockBg">
                            <div class="importantLinksWrap">
                                <h3>New Links</h3>
                                <div class="ticker">
                                    <a runat="server" class="playPause stop" href="#" title="Pause">Pause</a>
                                   <div class="tickerDivBlock">  <%--class="tickerDivBlock">--%>
                                        <ul class="bulletText ">
                                    
                                        <%--<li>--%>
                                             <asp:Literal ID="ltLink" runat="server"></asp:Literal>

                                        <%--</li>--%>

                                           <%-- <li><a runat="server" href="http://ic.gujarat.gov.in/?page_id=363">The New Industrial Policy 2015</a></li>
                                            <li><a runat="server" href="https://dst.gujarat.gov.in/Portal/Document/1_115_Electronics%20Policy%202016-21.pdf">Electronic Policy (2016-21)</a></li>
                                            <li><a runat="server" href="http://dst.gujarat.gov.in/state-of-gujarat-policies.htm">IT/ITeS Policy (2016-21)</a></li>
                                            <li><a runat="server" href="http://ic.gujarat.gov.in/?page_id=2295">Textile Policy</a></li>
                                            <li><a runat="server" href="http://dst.gujarat.gov.in/Images/final-gujarat-egovernance-policy.pdf">eGovernance Policy 2014</a></li>
                                            <li><a runat="server" href="https://dst.gujarat.gov.in/images/pdf/Startup-Policy-2016-21.pdf">Startup-Policy (2016-21)</a></li>--%>
                                        </ul>
                                    </div>
                                </div>
                                <a runat="server" href="#" class="viewAll">View All</a>
                            </div>
                        </div>
                        <div class="colBox halfWidthBox">
                            <div class="contentIconLinksWrap">
                                <ul class="contentLinks cf">
                                    <li>
                                        <h3>Mobile<br />
                                            Application</h3>
                                        <div class="iconImgWrap">
                                            <span class="iconImg mobileApp">Mobile
                  Application</span>
                                        </div>
                                        <a runat="server" href="#" class="listIconBtn">Download</a> </li>
                                    <li>
                                        <h3>About<br />
                                            Gujarat</h3>
                                        <div class="iconImgWrap">
                                            <span class="iconImg aboutGujrat">About
                  Gujarat</span>
                                        </div>
                                        <a runat="server" href="#" class="listIconBtn">More Info</a> </li>
                                    <li>
                                        <h3>Awards &amp;<br />
                                            Recognition</h3>
                                        <div class="iconImgWrap">
                                            <span class="iconImg awards">Awards &amp;
                  Recognition</span>
                                        </div>
                                        <a runat="server" href="#" class="listIconBtn">More Info</a> </li>
                                </ul>
                                

                            </div>
                        </div>
                        <div class="colBox oneThirdBox contentBlockBg">
                            <div class="importantLinksWrap">
                                <h3>Important policies</h3>
                                <div class="ticker">
                                    <a runat="server" class="playPause stop" href="#" title="Pause">Pause</a>
                                    <div class="tickerDivBlock">
                                        <ul class="bulletText activityTicker">


                                            <li><a runat="server" href="http://ic.gujarat.gov.in/?page_id=363">the new industrial policy 2015</a></li>
                                            <li><a runat="server" href="https://dst.gujarat.gov.in/portal/document/1_115_electronics%20policy%202016-21.pdf">electronic policy (2016-21)</a></li>
                                            <li><a runat="server" href="http://dst.gujarat.gov.in/state-of-gujarat-policies.htm">it/ites policy (2016-21)</a></li>
                                            <li><a runat="server" href="http://ic.gujarat.gov.in/?page_id=2295">textile policy</a></li>
                                            <li><a runat="server" href="http://dst.gujarat.gov.in/images/final-gujarat-egovernance-policy.pdf">egovernance policy 2014</a></li>
                                            <li><a runat="server" href="https://dst.gujarat.gov.in/images/pdf/startup-policy-2016-21.pdf">startup-policy (2016-21)</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <a runat="server" href="#" class="viewAll">View All</a>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!--/#homeContent-->
            <!--/#footer-->
            <footer id="footer" class="footer">
                <!--.footerLogo-->
                <div class="footerLogo cf">
                    <div class="container">
                        <div class="footerLogoSlider swiper-container">
                            <div class="swiper-wrapper">
                                <div class="swiper-slide">
                                    <a runat="server" href="http://www.digitalindia.gov.in/" target="_blank">
                                        <img src="Lite/images/degital-india.jpg" width="129" height="56" alt="Digital India  : External website that opens in a new window" title="Digital India  : External website that opens in a new window"></a>
                                </div>
                                <div class="swiper-slide">
                                    <a runat="server" href="https://dst.gujarat.gov.in/" target="_blank">
                                        <img src="Lite/images/dst-gujarat.jpg" width="217" height="56" alt="DST Gujarat : External website that opens in a new window" title=" DST Gujarat : External website that opens in a new window"></a>
                                </div>
                                <div class="swiper-slide">
                                    <a runat="server" href="http://www.gujaratindia.com/" target="_blank">
                                        <img src="Lite/images/gujarat-official-state-portal.jpg" width="154" height="55" alt="Gujarat Official Gujarat State Portal : External website that opens in a new window" title="Gujarat Official Gujarat State Portal : External website that opens in a new window"></a>
                                </div>
                                <div class="swiper-slide">
                                    <a runat="server" href="https://artd.gujarat.gov.in" target="_blank">
                                        <img src="Lite/images/artd.jpg" width="106" height="56" alt="ARTD : External website that opens in a new window" title="ARTD : External website that opens in a new window"></a>
                                </div>
                                <div class="swiper-slide">
                                    <a runat="server" href="http://nic.gov.in/" target="_blank">
                                        <img src="Lite/images/nic.jpg" width="152" height="55" alt="National Informatics Center : External website that opens in a new window" title="National Informatics Center : External website that opens in a new window"></a>
                                </div>
                            </div>
                        </div>
                        <div class="swiper-button-next swiperControl"></div>
                        <div class="swiper-button-prev swiperControl"></div>
                    </div>
                </div>
                <!--/.footerLogo-->
                <!--.footerInfRow-->
                <div class="footerInfRow">
                    <div class="container">
                        <div class="footerLeft">
                            <ul class="footerLinks">
                                <li><a runat="server" href="https://www.digitalgujarat.gov.in/FooterPages/TermsofUse.aspx">Terms of Use</a></li>
                                <li><a runat="server" href="https://www.digitalgujarat.gov.in/FooterPages/PrivacyPolicy.aspx">Privacy Policy</a></li>
                                <li><a runat="server" href="https://www.digitalgujarat.gov.in/FooterPages/CopyRightPolicy.aspx">Copyright Policy</a></li>
                                <li><a runat="server" href="https://www.digitalgujarat.gov.in/FooterPages/HyperlinkPolicy.aspx">Hyperlinking Policy</a></li>
                            </ul>
                            <p>Copyright © 2017, www.digitalgujarat.gov.in All Rights Reserved.</p>
                        </div>
                        <div class="footerRight">
                            <p class="lastUpdate">Page last updated on : 01/03/2017 <span class="visitorCount">Visitors : 134114</span></p>
                            <div class="socialIcons cf"><a runat="server" href="#" class="facebook socialIcon"><i class="fa fa-facebook"></i></a><a runat="server" href="#" class="twitter socialIcon"><i class="fa fa-twitter"></i></a><a runat="server" href="#" class="gPlus socialIcon"><i class="fa fa-google-plus"></i></a><a runat="server" href="#" class="youTube socialIcon"><i class="fa fa-youtube"></i></a></div>

                        </div>
                    </div>
                </div>
                <!--/.footerInfRow-->
            </footer>
            <!--/#footer-->
        </div>
        <!--/#wrapper-->
        <a runat="server" href="#top" title="Back to Top" id="backtotop">Back to Top</a>
        <script type="text/javascript" src="Lite/js/functions.js"></script>
        <script type="text/javascript" src="Lite/js/general.js"></script>
        <script src="http://maps.googleapis.com/maps/api/js?sensor=false" type="text/javascript"></script>
        <cc1:ModalPopupExtender ID="ModalPopupselectCity" runat="server" TargetControlID="a2"
            PopupControlID="Panel2" BackgroundCssClass="modalBackground" BehaviorID="ModalPopupselectCity" />
        <asp:Panel ID="Panel2" runat="server" Style="display: none; background-color: White; border-width: 2px; border-color: Black; width: 55%; border-style: solid; top: 10px !important;" meta:resourcekey="Panel2Resource1">
            <div class="panel panel-default" style="top: 10px !important;">
                <div class="panel-heading clearfix">
                    <div class="form-group">
                        <div class="col-xs-3">
                            <h3 class="panel-title">
                                <asp:Label ID="Label1" CssClass="control-label  " runat="server"
                                    Text="Select City"></asp:Label></h3>
                        </div>
                        <div class="col-xs-4">
                            <asp:TextBox ID="TextBox1" placeholder="Search City like Gandhinagar" Width="215px" runat="server" CssClass="form-control "></asp:TextBox>
                            <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtSearchCity"
                                ServiceMethod="GetSearchCityList"
                                MinimumPrefixLength="2"
                                CompletionInterval="1"
                                EnableCaching="true"
                                CompletionSetCount="20"
                                CompletionListCssClass="autocomplete_completionListElement"
                                CompletionListItemCssClass="autocomplete_listItem"
                                CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                                DelimiterCharacters=";, :">
                            </cc1:AutoCompleteExtender>
                        </div>
                        <div class="col-xs-1">
                            <asp:Button ID="Button1" CssClass="btn btn-default reg" runat="server" Text="Go" />
                        </div>
                    </div>


                </div>
                <div class="panel-body">
                    <asp:Panel ID="Panel3" runat="server" ScrollBars="Auto" meta:resourcekey="Panel3Resource1">
                        <div class="panel-body table-responsive myAcctab" style="height: 60px;" id="divids" runat="server">
                            <asp:DataList ID="dlCity" runat="server" CssClass="table table-striped" RepeatColumns="6" RepeatDirection="Horizontal">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnk" runat="server" ForeColor="Black" Text='<%# Eval(IIf(Session("MyCulture") = "en-GB", "CityName", "CityNameG"))%>'></asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle CssClass="MapItem" />
                            </asp:DataList>

                        </div>
                    </asp:Panel>
                </div>

            </div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <%--  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">--%>




            <a href="abc" id="a2" runat="server"></a>
        </asp:Panel>
    </form>
</body>
</html>
