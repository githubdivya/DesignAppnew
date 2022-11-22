<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Home.aspx.vb" Inherits="DesignApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Digital Gujarat</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Bootstrap Core CSS -->
    <link type="text/css" href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome CSS -->
    <link type="text/css" href="css/font-awesome.min.css" rel="stylesheet" />
    <!-- Custom CSS -->
    <link type="text/css" href="css/animate.css" rel="stylesheet" />
    <!-- Custom CSS -->
    <link type="text/css" href="css/style.css" rel="stylesheet" />
    <!-- Template js -->
    <script src="js/jquery-2.1.1.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/jquery.appear.js"></script>
    <script src="js/contact_me.js"></script>
    <script src="js/jqBootstrapValidation.js"></script>
    <script src="js/modernizr.custom.js"></script>
    <script src="js/script.js"></script>
</head>
<body>
    <form id="form1" runat="server">


        <div class="header">
                        <div class="header_top">
                            <div class="logo">
                                <ul>
                                    <li id="logo_one"><a href="#">
                                        <img src="Images/Logo.svg.png" alt="RCPS" /></a></li>
                                    <li id="logo_two">
                                        <img src="Images/diguj.png" alt="" />
                                    </li>
                                </ul>
                            </div>
                            <div class="menu">
                                <ul class="nav-menu">
                                    <li>
                                        <a style="background-color: #6ea12f;" href="/frmMain.aspx">
                                            <asp:Localize ID="localize1" runat="server" meta:resourcekey="localize1Resource1" Text="Home"></asp:Localize></a>
                                    </li>

                                    <li>
                                        <a style="background-color: #dc6800;" href="/CitizenApp/Citizen/CitizenWEBUI/CitizenLogin.aspx">
                                            <asp:Localize ID="localize3" runat="server" meta:resourcekey="localize3Resource3" Text="Citizen Login"></asp:Localize></a>
                                    </li>
                                    <li>
                                        <a style="background-color: #008bbb;" href="/OfficeApp/frmMain.aspx">
                                            <asp:Localize ID="localize4" runat="server" meta:resourcekey="localize4Resource1" Text="Office Login"></asp:Localize></a>
                                    </li>
                                    <li>
                                        <a style="background-color: #14b3b9;" href="#">
                                            <asp:Localize ID="localize5" runat="server" meta:resourcekey="localize5Resource1" Text="Contact Us"></asp:Localize></a>
                                    </li>
                                    <li>
                                        <a style="background-color: #fba714;" href="#">
                                            <asp:Localize ID="localize6" runat="server" meta:resourcekey="localize6Resource1" Text="About Us"></asp:Localize></a>
                                    </li>
                                </ul>
                                <div class="language">
                                    <label>Select Language : </label>
                                    <asp:DropDownList runat="server" ID="language" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" AutoPostBack="True">
                                        <asp:ListItem>English</asp:ListItem>
                                        <asp:ListItem>Gujarati</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </div>
        <!-- Start Logo Section -->

        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    
                </div>
            </div>
        </div>

        <!-- End Logo Section -->


        <!-- Start Main Body Section -->
        <div class="mainbody-section text-center">
            <div class="container">
                <div class="row">

                    <div class="col-md-3">

                        <div class="menu-item blue">
                            <a href="#feature-modal" data-toggle="modal">
                                <i class="fa fa-magic"></i>
                                <div>
                                    <asp:LinkButton ID="LinkButton1" runat="server"><p>Get Certificate</p></asp:LinkButton>
                                </div>

                            </a>
                        </div>

                        <div class="menu-item green">
                            <a href="#portfolio-modal" data-toggle="modal">
                                <i class="fa fa-file-photo-o"></i>
                                <p>Portfolio</p>
                            </a>
                        </div>

                        <div class="menu-item light-red">
                            <a href="#about-modal" data-toggle="modal">
                                <i class="fa fa-user"></i>
                                <p>About Us</p>
                            </a>
                        </div>

                    </div>

                    <div class="col-md-6">

                        <!-- Start Carousel Section -->
                        <div class="home-slider">
                            <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="padding-bottom: 30px;">
                                <!-- Indicators -->
                                <ol class="carousel-indicators">
                                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                                </ol>

                                <!-- Wrapper for slides -->
                                <div class="carousel-inner">
                                    <div class="item active">
                                        <img src="images/about-03.jpg" class="img-responsive" alt="">
                                    </div>
                                    <div class="item">
                                        <img src="images/about-02.jpg" class="img-responsive" alt="">
                                    </div>
                                    <div class="item">
                                        <img src="images/about-01.jpg" class="img-responsive" alt="">
                                    </div>

                                </div>

                            </div>
                        </div>
                        <!-- Start Carousel Section -->

                        <div class="row">
                            <div class="col-md-6">
                                <div class="menu-item color responsive">
                                    <a href="#service-modal" data-toggle="modal">
                                        <i class="fa fa-area-chart"></i>
                                        <p>Services</p>
                                    </a>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="menu-item light-orange responsive-2">
                                    <a href="#team-modal" data-toggle="modal">
                                        <i class="fa fa-users"></i>
                                        <p>Team</p>
                                    </a>
                                </div>
                            </div>

                        </div>

                    </div>

                    <div class="col-md-3">

                        <div class="menu-item light-red">
                            <a href="#contact-modal" data-toggle="modal">
                                <i class="fa fa-envelope-o"></i>
                                <p>Contact</p>
                            </a>
                        </div>

                        <div class="menu-item color">
                            <a href="#testimonial-modal" data-toggle="modal">
                                <i class="fa fa-comment-o"></i>
                                <p>Testimonial</p>
                            </a>
                        </div>

                        <div class="menu-item blue">
                            <a href="#news-modal" data-toggle="modal">
                                <i class="fa fa-mortar-board"></i>
                                <p>Latest News</p>
                            </a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <!-- End Main Body Section -->

        <!-- Start Copyright Section -->
        <div class="copyright text-center">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div>Design & Developed by NIC</div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Copyright Section -->
    </form>
</body>
</html>
