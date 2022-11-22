<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Schem.Master" CodeBehind="frmMain1.aspx.vb" Inherits="DesignApp.frmMain1" Culture="auto"  UICulture="auto" meta:resourcekey="PageResource1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <section class="search-section">
        <div class="container">
            <div class="row">

                <div class="col-12 col-lg-3">
                    <div class="dg-cm-msg-box">
                       <%-- <div class="dg-cm-box position-relative mb-2">
                            <div class="dg-cm-photo position-relative">
                                <img src="frmMain1/images/cm-photo.jpg" alt="digital gujarat" />
                            </div>
                            <!-- dg-cm-photo ends -->
                            <div class="dg-box-design-top position-absolute bg-delta"></div>
                            <div class="dg-box-design-bottom position-absolute bg-delta"></div>
                        </div>--%>
                        <!-- dg-cm-box ends -->
                        <%--<div class="clear"></div>
                        <h3 class="dg-cm-name text-md weight-600 text-center text-alpha"><asp:Localize ID="localize1Resource24"   runat="server" meta:resourcekey="localize1Resource24" Text="Shri Vijaybhai Rupani"></asp:Localize></h3>
                        <h4 class="dg-cm-salutation weight-600 text-center text-sm text-alpha"><asp:Localize ID="localize1resource25"   runat="server" meta:resourcekey="localize1Resource25" Text="Search Gujarat Government Services"></asp:Localize></h4>
                        <div class="social-login">
                            <%--<button class="btn facebook-btn social-btn" type="button"><i class="fab fa-facebook-f"></i>Facebook</button>
                            <button class="btn google-btn social-btn" type="button"><i class="fab fa-twitter"></i>Twitter</button>--%>
                         <%--</div>--%>
                        <%-- <h3 class="mt-3">Welcome, Citizens</h3>
                        <p class="dg-cm-message">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. In vehicula semper dolor, 
                            eu interdum leo pulvinar vel. Donec sit amet consectetur velit, ut pharetra urna.
                             Pellentesque feugiat quam nec quam rutrum, ac ullamcorper nisl dictum. In facilisis massa purus, 
                            in maximus ante venenatis eu. Sed risus nisi, molestie et sollicitudin eu, porttitor ut neque.
                             Aliquam ut efficitur massa. Vestibulum id tortor quis tellus suscipit tempor eget ut leo.
                             Etiam bibendum eleifend congue. Integer quis ornare eros, ac fringilla enim.
                        </p>
                        <div class="mt-3">
                            <button type="button" class="btn dg-btn btn-primary">Read More</button>
                        </div>--%>
                    </div>
                    <!-- dg-cm-msg-box ends -->
                </div>
                <div class="dg-search-box col-12 col-md-12 col-lg-5 col-xl-5">
                    <h1 class="text-center text-2xl text-capitalize weight-700 mb-4 text-beta"><asp:Localize ID="localize1Resource23" runat="server" meta:resourcekey="localize1Resource23" Text="Search Gujarat Government Services"></asp:Localize></h1>
                    <div class="input-group autocomplete">
                        <asp:TextBox runat="server" ID="myInput" class="form-control" placeholder="Type here..." autocomplete="off" meta:resourcekey="myInputResource1" />
                        <div class="input-group-append">
                            <asp:Button class="btn btn-outline-light bg-blue text-white" runat="server" Text="Search" ID="btnSearch" OnClick="btnSearch_Click" meta:resourcekey="btnSearchResource1"></asp:Button>
                        </div>
                        <cc1:AutoCompleteExtender
                            runat="server"
                            BehaviorID="AutoCompleteEx"
                            ID="autoComplete1"
                            TargetControlID="myInput"
                            ServiceMethod="GetCompletionList"
                            MinimumPrefixLength="2"
                            CompletionSetCount="20"
                            CompletionListCssClass="autocomplete_completionListElement"
                            CompletionListItemCssClass="autocomplete_listItem"
                            CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                            DelimiterCharacters=";, :"
                            ShowOnlyCurrentWordInCompletionListItem="True" Enabled="True" ServicePath="">
                        </cc1:AutoCompleteExtender>

                        <!-- input-group-append ends -->
                    </div>
                </div>
                <div class="col-12 col-lg-4">

                    <div class="dg-whats-new">
                        <h1 class="text-center text-2xl text-capitalize weight-700 mb-4 text-beta">
                            <asp:Localize ID="localize1Resource22"   runat="server" meta:resourcekey="localize1Resource22" Text="what's new"></asp:Localize>
                        </h1>
                          <marquee scrolldelay="150" direction="right" width="100%" height="35px" align="center" marquee scrollamount="10" scrollamount="3" onmouseover="stop();"  onmouseout="start();" ><asp:PlaceHolder ID="phnews" runat ="server" ></asp:PlaceHolder></marquee>
                    
                        <%--<div class="list-group list-group-flush">
                            <div class="carousel-inner-data">
                                <ul>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#" class="active">
                                            <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</span>
                                            <span class="badge badge-warning badge-pill text-blink">New</span>
                                        </a>
                                    </li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Duis lacinia ipsum vitae tellus commodo.</span>
                                            <span class="badge badge-warning badge-pill text-blink">New</span>
                                        </a></li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Duis ut erat vehicula, fringilla diam a, aliquam sem.</span>
                                        </a></li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Phasellus posuere libero non ante interdum venenatis.</span>
                                        </a>
                                    </li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Etiam blandit erat ut sem iaculis, sed molestie orci varius.</span>
                                        </a>
                                    </li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Donec viverra enim eget mauris feugiat, vel efficitur purus cursus.</span>
                                        </a>
                                    </li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Phasellus posuere libero non ante interdum venenatis.</span>
                                        </a>
                                    </li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Etiam blandit erat ut sem iaculis, sed molestie orci varius.</span>
                                        </a>
                                    </li>
                                    <li class="list-group-item list-group-item-action">
                                        <a href="#">
                                            <span>Donec viverra enim eget mauris feugiat, vel efficitur purus cursus.</span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>--%>
                    </div>
                </div>
                <!-- col ends -->
            </div>
            <!-- row ends -->
        </div>
        <!-- container ends -->
    </section>
    <br />
    <br />
    <br />
    


     <div class="container">
            <h1 class="text-center text-2xl text-capitalize weight-700 mb-4 text-beta"  >
                <asp:Localize ID="localize111"  runat="server" meta:resourcekey="localize1Resource111" Text="popular services"></asp:Localize></h1>
          <%--  <div class="row no-gutters">--%>
                <div class="two-column-carousel-2 owl-carousel p-3  owl-theme owl-dots-none">
                    <a href="#" class="dg-services-card"  runat ="server" visible ="false" id ="div1">
                        <div class="dg-service-icon mb-3">
                       <%--   <asp:Label ID="Label1" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>--%>
                         <%--<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("UserName","~/images/{0}.jpg") %>' />--%>
                              <asp:Image ID="imagefirst" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                        <div class="dg-services-name weight-600 text-capitalize">
                            
                       <asp:Label id="lblfirst" runat ="server"  ></asp:Label><br />
                      <%-- <asp:Label id="lblfirstcount" runat ="server"   ></asp:Label>--%>

                        </div>
                    </a>
                  <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div2">
                        <div class="dg-service-icon mb-3">
                         <asp:Image ID="imagesecond" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                       <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblsecond" runat ="server"   ></asp:Label><br />
                     <%--  <asp:Label id="lblsecondcount" runat ="server"   ></asp:Label>--%>
                           </div>
                          
                    </a>
                     <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div3">
                        <div class="dg-service-icon mb-3">
                           <asp:Image ID="imagethird" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                         <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblthird" runat ="server"   ></asp:Label><br />
                      <%-- <asp:Label id="lblthirdcount" runat ="server"   ></asp:Label>--%>
                             </div>
                    </a>
                      <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div4">
                        <div class="dg-service-icon mb-3">
                            
                            <asp:Image ID="imageforth" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                          <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblfour" runat ="server"   ></asp:Label><br />
                     <%--  <asp:Label id="lblfourcount" runat ="server"   ></asp:Label>--%>
                              </div>
                    </a>
                     <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div5">
                        <div class="dg-service-icon mb-3">
                          <asp:Image ID="imagefifth" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                         <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblfive" runat ="server"   ></asp:Label><br />
                       <%--<asp:Label id="lblfivecount" runat ="server"   ></asp:Label>--%>
                             </div>
                    </a>
                     <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div6">
                        <div class="dg-service-icon mb-3">
                          <asp:Image ID="imagesix" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                         <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblsix" runat ="server"   ></asp:Label><br />
                      <%-- <asp:Label id="lblsixcount" runat ="server"   ></asp:Label>--%>
                             </div>
                    </a>
                      <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div7">
                        <div class="dg-service-icon mb-3">
                          <asp:Image ID="imageseven" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                          <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblseven" runat ="server"   ></asp:Label><br />
                      <%-- <asp:Label id="lblsevencount" runat ="server"   ></asp:Label>--%>
                              </div>
                    </a>
                     <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div8">
                        <div class="dg-service-icon mb-3">
                           <asp:Image ID="imageeight" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                         <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lbleight" runat ="server"   ></asp:Label><br />
                     <%--  <asp:Label id="lbleightcount" runat ="server"   ></asp:Label>--%>
                             </div>
                    </a>
                     <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div9">

                        <div class="dg-service-icon mb-3">
                          <asp:Image ID="imagenine" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                         <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblnine" runat ="server"   ></asp:Label><br />
                     <%--  <asp:Label id="lblninecount" runat ="server"   ></asp:Label>--%>
                             </div>
                    </a>
                     <a href="#" class="dg-services-card" runat ="server" visible ="false" id ="div10">
                        <div class="dg-service-icon mb-3">
                           <asp:Image ID="imageten" runat="server"  Width="50px"
                                        meta:resourcekey="imgPhotoResource1" />
                        </div>
                         <div class="dg-services-name weight-600 text-capitalize">
                       <asp:Label id="lblten" runat ="server"   ></asp:Label><br />
                     <%--  <asp:Label id="lbltencount" runat ="server"   ></asp:Label>--%>
                             </div>
                    </a>
                  
          </div>
            <div class="row no-gutters">
                <div class="col-12 d-flex justify-content-between pl-3 pr-3">
                    <span href="#" class="dg-serv-nav-arrows bg-delta text-center text-lg navText"></span>
                    <span href="#" class="dg-serv-nav-arrows bg-delta text-center text-lg"></span>
                </div>
            </div>

        </div>
 
</asp:Content>
