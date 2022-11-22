<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="frmMain.aspx.vb" Inherits="DesignApp.frmMain" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #map {
            margin-top: 10px;
            height: 480px;
        }
    </style>
    <!--[if lte IE 8]>
    <script>
        alert("This site can be best viewed in Firefox 3.5 and above ,IE 9 and above,chrome 18 and above. To check your browser version ");
        var url = "http://google.com";
        window.open(url, '_self');
    </script>
   <![endif]-->
    <script type="text/javascript">
        // debugger;

        var nVer = navigator.appVersion;
        var nAgt = navigator.userAgent;
        var browserName = navigator.appName;
        var fullVersion = '' + parseFloat(navigator.appVersion);
        var majorVersion = parseInt(navigator.appVersion, 10);
        var nameOffset, verOffset, ix;


        // In Opera 15+, the true version is after "OPR/" 
        if ((verOffset = nAgt.indexOf("OPR/")) != -1) {
            browserName = "Opera";
            fullVersion = nAgt.substring(verOffset + 4);
        }
            // In older Opera, the true version is after "Opera" or after "Version"
        else if ((verOffset = nAgt.indexOf("Opera")) != -1) {
            browserName = "Opera";
            fullVersion = nAgt.substring(verOffset + 6);
            if ((verOffset = nAgt.indexOf("Version")) != -1)
                fullVersion = nAgt.substring(verOffset + 8);
        }
            //In MSIE, the true version is after "MSIE" in userAgent
        else if ((verOffset = nAgt.indexOf("IE")) != -1) {

            browserName = "Microsoft Internet Explorer";
            fullVersion = nAgt.substring(verOffset + 5);
            var a = navigator.userAgent;
            var b = a.split('rv:')[1];
            var c = b.split('.')[0]
            if (c < 8) {
                alert("This site can be best viewed in Firefox 3.5 and above ,IE 9 and above,chrome 18 and above. To check your browser version ");
                //var url = "http://google.com";
                window.open(url, '_self');
            }
        }
            // In Chrome, the true version is after "Chrome" 
        else if ((verOffset = nAgt.indexOf("Chrome")) != -1) {
            browserName = "Chrome";
            fullVersion = nAgt.substring(verOffset + 7);
        }
            // In Safari, the true version is after "Safari" or after "Version" 
        else if ((verOffset = nAgt.indexOf("Safari")) != -1) {
            browserName = "Safari";
            fullVersion = nAgt.substring(verOffset + 7);
            if ((verOffset = nAgt.indexOf("Version")) != -1)
                fullVersion = nAgt.substring(verOffset + 8);
        }
            // In Firefox, the true version is after "Firefox" 
        else if ((verOffset = nAgt.indexOf("Firefox")) != -1) {
            browserName = "Firefox";
            fullVersion = nAgt.substring(verOffset + 8);
        }
            // In most other browsers, "name/version" is at the end of userAgent 
        else if ((nameOffset = nAgt.lastIndexOf(' ') + 1) <
                  (verOffset = nAgt.lastIndexOf('/'))) {
            browserName = nAgt.substring(nameOffset, verOffset);
            fullVersion = nAgt.substring(verOffset + 1);
            if (browserName.toLowerCase() == browserName.toUpperCase()) {
                browserName = navigator.appName;
            }
        }
        // trim the fullVersion string at semicolon/space if present
        if ((ix = fullVersion.indexOf(";")) != -1)
            fullVersion = fullVersion.substring(0, ix);
        if ((ix = fullVersion.indexOf(" ")) != -1)
            fullVersion = fullVersion.substring(0, ix);

        majorVersion = parseInt('' + fullVersion, 10);
        if (isNaN(majorVersion)) {
            fullVersion = '' + parseFloat(navigator.appVersion);
            majorVersion = parseInt(navigator.appVersion, 10);
        }

        //var a = navigator.userAgent;
        //var b = a.split('rv:')[1];
        //var c = b.split('.')[0]
        //alert(''
        // + 'Browser name  = ' + browserName + '<br>'
        // + 'Full version  = ' + fullVersion + '<br>'
        // + 'Major version = ' + majorVersion + '<br>'
        // + 'navigator.appName = ' + navigator.appName + '<br>'
        // + 'navigator.userAgent = ' + navigator.userAgent + '<br>'
        // +'IE '+c

        //)
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
    <main id="main" class="main-home">

		<!-- Search Section
		//////////////////////////// -->
		<!-- Search Section
		//////////////////////////// -->
		<div id="search-banner" class="fade">

			<div class="formScript form1">
				<p>
					
					<input type="text" value="" name="q" id="txtsearch"  runat="server"
                        autocomplete="off" class="typer" data-keywords='["Mahatma Mandir","Attend Rann Utsav","Kankariya Carnival","Adalaj","Kankariya"]'/>
					<button type="submit" id="btnSearchmain" runat="server" >
						<svg version="1.1" x="0px" y="0px" viewBox="0 0 24 24" width="24px" height="24px" enable-background="new 0 0 200 200" preserveAspectRatio="none">
					<path d="M23.5,21.3l-7-7c2.5-3.5,2.2-8.5-1-11.7C12-0.9,6.1-0.9,2.6,2.7c-3.5,3.5-3.5,9.3,0,12.8c3.2,3.2,8.1,3.5,11.7,1l7,7
						c0.6,0.6,1.6,0.6,2.2,0l0,0C24.2,22.9,24.2,22,23.5,21.3z M4.7,13.4c-2.4-2.4-2.4-6.2,0-8.5c2.4-2.4,6.2-2.4,8.5,0
						c2.4,2.4,2.4,6.2,0,8.5C11,15.7,7.1,15.7,4.7,13.4z"/>
					</svg>
					</button>
					<!-- <button type="button" class="clear-search">Clear Search</button> -->
				</p>
			</div>
			
		</div><!-- /#search-banner -->

		<!-- Locals Section
				//////////////////////////// -->
		<section id="locals">
			
			<header>

			    
				<div class="container">
					<h2><asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="Government Headlines"></asp:Localize></h2>
					<ul class="social">
						<%--<li><a href="city/index.html#citySocial" class="g-plus">Google Plus</a></li>--%>
						<li><a href="https://www.facebook.com/gujaratinformation.official" target="_blank" class="facebook"><asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="FaceBook"></asp:Localize></a></li>
						<li><a href="https://twitter.com/InfoGujarat" class="twitter" target="_blank" ><asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize4Resource1" Text="Twitter"></asp:Localize></a></li>
					</ul>
				</div>
			</header>

			<div class="feature mIndex" data-format="background" data-locate="device" data-type="99" data-limit="1">
							
				<div class="feature-content">
					<%--<a href="#" class="call-to-action">
						<p class="call-out">Access  Gujarat public data as well as Services and other records</span></p>
					</a>--%>
				</div>
			</div><!-- /.feature -->
			
			<div class="content-container">

				<article class="content-item news representatives" id="reps">
					<%--<h3><a class="public" href="#" class="pull-left">Public Comments</a></h3>--%>
                    <h3><a class="government" href="#" class="pull-left"><asp:Localize ID="localize1" runat="server" Text="My Government" meta:resourcekey="localize1Resource1"  ></asp:Localize></a></h3>
					<div class="aggregator" data-type="legislator" data-address="auto">
						<div class="mobile_apps">
                            <div class="officemt1">
                            <div class="office mt">
								<img class="pull-left" src="images/14gov5.jpg" />
								<div class="nam"><h5><strong><asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize5Resource1" Text="Shree Acharya Dev Vrat"></asp:Localize> <br/><small><asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize6Resource1" Text="Hon. Governor, Gujarat"></asp:Localize></small></strong></h5></div>
							</div>
							<div class="clearfix"></div>
                            </div>
                            <%--<div class="officemt2">
							<div class="office">
								<img class="pull-left" src="images/fai.jpg" />
								<div class="nam"><h5><strong><asp:Localize ID="localize7"   runat="server" meta:resourcekey="localize7Resource1" Text="Shri Vijaybhai R. Rupani"></asp:Localize> <br/><small><asp:Localize ID="localize8"   runat="server" meta:resourcekey="localize8Resource1" Text="Hon. Chief Minister, Gujarat"></asp:Localize></small></strong></h5></div>
							</div>
                                <br />
                                <br />
							<div class="clearfix"></div>
							</div>--%>
						</div>
                        <%--<div class="news-item">
						<a href="#" id="AMD" runat ="server">
							<h5>Department</h5>
						</a>
					</div>	--%>
                        <div class="news-item">
<a href="~/Citizen/MoreDepartment.aspx" id="AMD" runat ="server" target="_blank">
	<h5><asp:Localize ID="localize9"   runat="server" meta:resourcekey="localize9Resource1" Text="Departments of the Government"></asp:Localize></h5>
</a>
</div>
                        <%--<asp:Button ID="btnDisplayModelpopup" runat="server" Style="display: none;" />--%>
                       
		

					</div>
					
				</article>

				<article class="jobs content-item representatives" id="reps">
					<%--<h3><a class="bus" href="#">Business</a></h3>--%>
                    <h3><a class="explore_gujarat" href="#"><asp:Localize ID="localize10"   runat="server" meta:resourcekey="localize10Resource1" Text="Explore Gujarat"></asp:Localize></a></h3>
					<div class="aggregator databox" data-type="legislator" data-address="auto">
						<div class="Beaches">
							<div class="num">
								<a href="http://www.gujarattourism.com/destination/category/3" target="_blank"><asp:Localize ID="localize11"   runat="server" meta:resourcekey="localize11Resource1" Text="Beaches"></asp:Localize></a> 
							</div>
							
						</div>

						<div class="Ecotourism">
							<div class="num">
                                <a href="http://www.gujarattourism.com/destination/category/5" target="_blank"><asp:Localize ID="localize12"   runat="server" meta:resourcekey="localize12Resource1" Text="Ecotourism"></asp:Localize></a> 
								
							</div>
							
						</div>
						<div class="Heritage">
							<div class="num">
								 <a href="http://www.gujarattourism.com/destination/category/6" target="_blank"><asp:Localize ID="localize13"   runat="server" meta:resourcekey="localize13Resource1" Text="Heritage"></asp:Localize></a> 
							</div>
						<%--area--%>
						</div>
						<%--<div class="population">
							<div class="num">
								<a href="http://www.gujarattourism.com/destination/category/7" target="_blank">Gandhi Circuit</a> 
							</div>
							
						</div>--%>
						<div class="Fairs">
							<div class="num">
								<a href="http://www.gujarattourism.com/fairs-festivals" target="_blank"><asp:Localize ID="localize14"   runat="server" meta:resourcekey="localize14Resource1" Text="Fairs"></asp:Localize></a> 
							</div>
							
						</div>
						<div class="Museums">
							<div class="num">
								<a href="http://www.gujarattourism.com/destination/category/9" target="_blank"><asp:Localize ID="localize15"   runat="server" meta:resourcekey="localize15Resource1" Text="Museums"></asp:Localize></a> 
							</div>
						
						</div>
                        <%--<div class="taluka">
							<div class="num">
								<a href="http://www.gujarattourism.com/destination/category/10" target="_blank">Religious Sites</a> 
							</div>
						
						</div>--%>
                          <div class="Handicrafts">
							<div class="num">
								<a href="http://www.gujarattourism.com/attraction/handicrafts" target="_blank"><asp:Localize ID="localize16"   runat="server" meta:resourcekey="localize16Resource1" Text="Handicrafts"></asp:Localize></a> 
							</div>
						
						</div>
					</div>				
				</article>

				<article class="content-item news representatives" id="reps">
					<%--<h3><a class="edu" href="#">Education</a></h3>--%>
                    <h3><a class="whats_new" href="#"><asp:Localize ID="localize17"   runat="server" meta:resourcekey="localize17Resource1" Text="What's New"></asp:Localize></a></h3>
					<div class="aggregator" data-type="legislator" data-address="auto">
							<%--<a class="twitter-timeline" href="https://twitter.com/InfoGujarat" data-widget-id="636532948460638208">Tweets by @InfoGujarat</a>
<script>!function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + "://platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } }(document, "script", "twitter-wjs");</script>
						</div>--%>
                       <ul  runat="server" id="PressGroup"></ul>
				</article>

				<article class="content-item representatives" id="reps">
					<h3><a class="supply" href="#"><asp:Localize ID="localize18"   runat="server" meta:resourcekey="localize18Resource1" Text="Focus Area:- Digital Gujarat"></asp:Localize></a></h3>
					<div class="aggregator" data-type="legislator" data-address="auto">

						<div id="focus" class="carousel slide" data-ride="carousel">
					  

					  <!-- Wrapper for slides -->
					  <div class="carousel-inner" role="listbox">
					    <div class="item active">
					      <img src="Images/FocusArea/Focus1.jpg" />
					    </div>

					    <div class="item">
					      <img src="images/FocusArea/Focus2.jpg" />
					    </div>

					    <div class="item">
					      <img src="images/FocusArea/Focus3.jpg" />
					    </div>

					    <div class="item">
					      <img src="images/FocusArea/Focus4.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/FocusArea/Focus5.jpg" />
					    </div>
                         <%-- <div class="item">
					      <img src="images/Focus6.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus7.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus8.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus9.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus10.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus11.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus12.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus13.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus14.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus15.jpg" />
					    </div>
                          <div class="item">
					      <img src="images/Focus16.jpg" />
					    </div>--%>
					  </div>

					  <!-- Left and right controls -->
					 <a class="left carousel-control" href="#focus" role="button" data-slide="prev">
					    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
					    <span class="sr-only"><asp:Localize ID="localize19"   runat="server" meta:resourcekey="localize19Resource1" Text="Previous"></asp:Localize></span>
					  </a>
					  <a class="right carousel-control" href="#focus" role="button" data-slide="next">
					    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
					    <span class="sr-only"><asp:Localize ID="localize20"   runat="server" meta:resourcekey="localize20Resource1" Text="Next"></asp:Localize></span>
					  </a>
					</div>
					

					</div>
					<%--<div class="news-item">
						<a href="#">
							<h5>Know More</h5>
						</a>
					</div>	--%>
				</article>

			</div><!-- /.content-container -->

		</section>
		<!-- Locals Section end
				//////////////////////////// -->

		<!-- open Section start
				//////////////////////////// -->
		<section id="open">
			<%--<header>
				<div class="container">
					<h2><asp:Localize ID="localize21"   runat="server" meta:resourcekey="localize21Resource1" Text="Initiatives &amp; Achievements"></asp:Localize></h2>
					<ul class="social">
						<%--<li><a href="city/index.html#citySocial" class="g-plus">Google Plus</a></li>--%>
						<%--<li><a href="https://www.facebook.com/gujaratinformation.official" target="_blank" class="facebook"><asp:Localize ID="localize22"   runat="server" meta:resourcekey="localize22Resource1" Text="FaceBook"></asp:Localize></a></li>
						<li><a href="https://twitter.com/InfoGujarat" class="twitter" target="_blank" ><asp:Localize ID="localize23"   runat="server" meta:resourcekey="localize23Resource1" Text="Twitter"></asp:Localize></a></li>
					</ul>
				</div>
			</header>--%>

			<%--<div class="feature mIndex" data-format="background" data-locate="device" data-type="99" data-limit="1">
							
				<div class="feature-content">
					<%--<a href="#" class="call-to-action">
						<p class="call-out">Access  Gujarat public data as well as Services and other records</p>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
					</a>--%>
				<%--</div>
			</div>--%><!-- /.feature -->

             <div id="search-banner1" class="fade" style="height:400px; background-size:1350px 360px !important; background-repeat: no-repeat;">
                           <div class="formScript form1" style="height:400px; background-size:1350px 360px !important">
				            <p>
					
					            <input type="text" value="" name="q" id="txtsearchIIM"  runat="server" style="display:none" 
                                    autocomplete="off" class="typer" data-keywords='["Online Service Delivery Steps","Online Service Delivery Steps1"]'/>
					            <button type="submit" id="btnSearchmainIIM" runat="server" visible="false" >
						            <svg version="1.1" x="0px" y="0px" viewBox="0 0 24 24" width="24px" height="24px" enable-background="new 0 0 200 200" preserveAspectRatio="none">
					            <path d="M23.5,21.3l-7-7c2.5-3.5,2.2-8.5-1-11.7C12-0.9,6.1-0.9,2.6,2.7c-3.5,3.5-3.5,9.3,0,12.8c3.2,3.2,8.1,3.5,11.7,1l7,7
						            c0.6,0.6,1.6,0.6,2.2,0l0,0C24.2,22.9,24.2,22,23.5,21.3z M4.7,13.4c-2.4-2.4-2.4-6.2,0-8.5c2.4-2.4,6.2-2.4,8.5,0
						            c2.4,2.4,2.4,6.2,0,8.5C11,15.7,7.1,15.7,4.7,13.4z"/>
					            </svg>
					            </button>
					            <!-- <button type="button" class="clear-search">Clear Search</button> -->
				            </p>
			            </div>
                    </div>
			
			<div class="content-container">

				<article class="content-item representatives" id="reps">
					<%--<h3><a class="public" href="#" class="pull-left">Public Data</a></h3>--%>
                    <h3><a class="marching_ahead" href="#" class="pull-left"><asp:Localize ID="localize24"   runat="server" meta:resourcekey="localize24Resource1" Text="Gujarat- Leading the Way"></asp:Localize></a></h3>
					<div class="aggregator" data-type="legislator" data-address="auto">

					<div id="myCarousel" class="carousel slide" data-ride="carousel">
					  

					  <!-- Wrapper for slides -->
					  <div class="carousel-inner" role="listbox">
                          <%-- <div class="item active">
                            <img src="images/GujaratLeadingWay/slide1.jpg" />
					     
					    </div>--%>

					    <%--<div class="item">
					      <img src="images/GujaratLeadingWay/slide 3.jpg" />
					    </div>--%>

					   <%-- <div class="item">
					      <img src="images/GujaratLeadingWay/slide6.jpg" />
					    </div>--%>

					    <div class="item active">
					       <img src="images/GujaratLeadingWay/slide7.jpg" />                         
					    </div>
                          <div class="item">
					       <img src="images/GujaratLeadingWay/Slide 6.jpg" />
                              </div>
                            <div class="item">
					       <img src="images/GujaratLeadingWay/slide 7.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/GujaratLeadingWay/slide 8.jpg" />                        
					    </div>
                           <%-- <div class="item">
					       <img src="images/GujaratLeadingWay/slide 9.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/GujaratLeadingWay/slide 10.jpg" />                         
					    </div>--%>
					     <%--<div class="item active">
                            <img src="images/slide1.jpg" />
					     
					    </div>

					    <div class="item">
					      <img src="images/slide 3.jpg" />
					    </div>

					    <div class="item">
					      <img src="images/slide6.jpg" />
					    </div>

					    <div class="item">
					       <img src="images/slide7.jpg" />                         
					    </div>
                          <div class="item">
					       <img src="images/Slide 6.jpg" />
                              </div>
                            <div class="item">
					       <img src="images/slide 7.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/slide 8.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/slide 9.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/slide 10.jpg" />                         
					    </div>
                            <div class="item">
					       <img src="images/slide 11.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/slide 12.jpg" />                        
					    </div>
                            <div class="item">
					       <img src="images/slide 13.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 13.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 14.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 15.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 16.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 17.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 18.jpg" />                        
					    </div>
                          <div class="item">
					       <img src="images/slide 19.jpg" />                        
					    </div>--%>
                          <%-- <div class="item">
					      <img src="images/edu_img.jpg">
					    </div>--%>
					  </div>

					  <!-- Left and right controls -->
					  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
					    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
					    <span class="sr-only"><asp:Localize ID="localize25"   runat="server" meta:resourcekey="localize25Resource1" Text="Previous"></asp:Localize></span>
					  </a>
					  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
					    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
					    <span class="sr-only"><asp:Localize ID="localize26"   runat="server" meta:resourcekey="localize26Resource1" Text="Next"></asp:Localize></span>
					  </a>
					</div>

					</div>
				<%--	<div class="news-item">
						<a href="#">
							<h5>New Local Insights on Uintah Basin economy</h5>
						</a>
					</div>--%>
				</article>

				<article class="jobs content-item representatives" id="reps">
					<h3><a class="inportant_policies" href="#"><asp:Localize ID="localize27"   runat="server" meta:resourcekey="localize27Resource1" Text="Important Policies"></asp:Localize></a></h3>
					<div class="aggregator " data-type="legislator" data-address="auto">
						<ul>
							<li>
								<a href="http://ic.gujarat.gov.in/?page_id=3639" target="_blank"><h4><asp:Localize ID="localize28"   runat="server" meta:resourcekey="localize28Resource1" Text="The New Industrial Policy 2015"></asp:Localize></h4></a>
							</li>
							<li>
								<%--<a href="http://dst.gujarat.gov.in/images/pdf/electronics_policy_12nov2014.pdf" target="_blank"><h4><asp:Localize ID="localize29"   runat="server" meta:resourcekey="localize29Resource1" Text="Electronic Policy 2014"></asp:Localize> </h4></a>--%>
                                <a href="https://dst.gujarat.gov.in/Portal/Document/1_115_Electronics%20Policy%202016-21.pdf" target="_blank"><h4><asp:Localize ID="localize29"   runat="server" meta:resourcekey="localize29Resource1" Text="Electronic Policy (2016 -21)"></asp:Localize> </h4></a>
							</li>
							<li>
								<%--<a href="http://dst.gujarat.gov.in/Images/final-it-policy-document.pdf" target="_blank"><h4><asp:Localize ID="localize30"   runat="server" meta:resourcekey="localize30Resource1" Text="IT Policy 2014"></asp:Localize></h4></a>--%>
                                <a href="http://dst.gujarat.gov.in/state-of-gujarat-policies.htm" target="_blank"><h4><asp:Localize ID="localize30"   runat="server" meta:resourcekey="localize30Resource1" Text="IT/ITeS Policy (2016-2021)"></asp:Localize></h4></a>
							</li>
							<li>
								<a href="http://ic.gujarat.gov.in/?page_id=2295" target="_blank"><h4><asp:Localize ID="localize31"   runat="server" meta:resourcekey="localize31Resource1" Text="Textile Policy"></asp:Localize> </h4></a>
							</li>
                            <li>
								<a href="http://dst.gujarat.gov.in/Images/final-gujarat-egovernance-policy.pdf" target="_blank"><h4><asp:Localize ID="localize32"   runat="server" meta:resourcekey="localize32Resource1" Text="eGovernance Policy 2014"></asp:Localize></h4></a>
							</li>
                            <li>								
                                <a href="https://dst.gujarat.gov.in/images/pdf/Startup-Policy-2016-21.pdf" target="_blank"><h4><asp:Localize ID="localize21"   runat="server" meta:resourcekey="localizeStartupResource1" Text="Startup-Policy (2016-21)"></asp:Localize></h4></a>
							</li>
					</ul>

					</div>									
				</article>

				<article class="content-item representatives" id="reps">
					<%--<h3><a class="adata" href="#">Ahmedabad Data</a></h3>--%>
                    <h3><a class="awards" href="#"><asp:Localize ID="localize33"   runat="server" meta:resourcekey="localize33Resource1" Text="Awards &amp; Recognition"></asp:Localize></a></h3>
					<div class="aggregator mob" data-type="legislator" data-address="auto">

						<div class="mobile_apps">
							<a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award1.JPG"></a>
							<a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award2.JPG"></a>
							<a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award3.JPG"></a>
							<a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award4.JPG"></a>
                            <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award5.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award6.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award7.JPG"></a>
                            <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award8.JPG"></a>
                            <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award9.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award10.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award11.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award12.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award13.JPG"></a>
                             <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award14.JPG"></a>
                            <a class="fifty" href="http://www.gujaratindia.com/state-profile/awards.htm" target="_blank"><img src="Images/award15.JPG"></a>
						</div>
						<%--<ul>
							<li>
								<a href="#"><h4>Affidavit</h4></a>
							</li>
							<li>
								<a href="#"><h4>Senior Citizen about being</h4></a>
							</li>
						
							<li>
								<a href="#"><h4>Academic Nationality</h4></a>
							</li>
					</ul>--%>

					</div>
				</article>

				<article class="content-item representatives" id="reps">
					<h3><a class="mobilea" href="#"><asp:Localize ID="localize34"   runat="server" meta:resourcekey="localize34Resource1" Text="Mobile Apps"></asp:Localize></a></h3>
					<div class="aggregator mob" data-type="legislator" data-address="auto">

						<div class="mobile_apps">
							<a class="fifty" href="https://play.google.com/store/apps/details?id=com.tcgl.gujarattourismnative&hl=en" target="_blank"><img  src="Images/MobilappGT.png"></a>
							<a class="fifty" href="https://play.google.com/store/apps/details?id=com.app.rmcgov" target="_blank"><img  src="Images/MobilappRMC.png"></a>
							<a class="fifty" href="https://play.google.com/store/apps/details?id=in.smc" target="_blank"><img src="Images/MobilappSMC.png"></a>
							<a class="fifty" href="https://play.google.com/store/apps/details?id=com.taim.ss" target="_blank"><img src="Images/MobilappSS.png"></a>
							<a class="fifty" href="https://play.google.com/store/apps/details?id=com.JunaghadhApp&hl=en" target="_blank"><img src="Images/MobilappSJ.png"></a>
							<a class="fifty" href="https://play.google.com/store/apps/details?id=com.shuchitajnd.shuchitajunagadh" target="_blank"><img src="Images/MobilappSSJ.png"></a>
                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.jobs.gog" target="_blank"><img src="Images/MobilappGOG.png"></a>
                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.wBMCMobileApp" target="_blank"><img src="Images/MobilappBMC.png"></a>

                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.shreepaddy" target="_blank"><img src="Images/1399042442_paddy.jpg" /></a>
                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.wheatcrop" target="_blank"><img src="Images/1399037654_wheat-seeds.jpg" /></a>
                             <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.hybridcorn" target="_blank"><img src="Images/1399037454_ab_food_06.jpg" /></a>
                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.kharifa" target="_blank"><img src="Images/1399037180_LittleMillet_Saamai_01a.jpg" /></a>


                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.use_biofertilizer" target="_blank"><img src="Images/1401253767_Jaivikkhatar.jpg" /></a>
                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.desi_cotton" target="_blank"><img src="Images/1400478109_kapas.jpg" /></a>
                            <a class="fifty" href="https://play.google.com/store/apps/details?id=com.aau.in.drywheatkey" target="_blank"><img src="Images/1400614707_GW 366SP.jpg" /></a>
						</div>

					</div>
                   <%-- <div class="news-item">
						<a href="#" id="a2" runat ="server">
							<h5>Apps</h5>
						</a>
					</div>--%>
                     <a href="abc" id="a2" runat ="server"></a>
                    <div class="news-item">
                     <a href="~/Citizen/MoreApps.aspx" id="a21" runat ="server" target="_blank">
                     <h5><asp:Localize ID="localize35"   runat="server" meta:resourcekey="localize35Resource1" Text="All Mobile Apps"></asp:Localize></h5>
                     </a>
                     </div>
					<%--<a href="#" id="change-rep">New Local insights</a>	--%>
				</article>

			</div><!-- /.content-container -->

		</section>  
		<!-- open Section end
				//////////////////////////// -->

	</main>

    <%--<div id="secondPart">
        <!-- Second part start -->
        <div class="container">
            <div class="row">
                <div class="col-md-7">
                    <div id="map">
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="info">
                        <h1>
                            <asp:Label ID="lblOfficeName" runat="server"></asp:Label></h1>

                        <div class="address">
                            <asp:Label ID="lblofficeAddress" runat="server"></asp:Label>
                        </div>
                        <div class="phone">
                            <asp:Label ID="lblOfficecontactno" runat="server"></asp:Label>
                        </div>
                        <div class="fax">
                            <asp:Label ID="lblofficeFaxno" runat="server"></asp:Label>
                        </div>
                        <div class="mail">
                            <asp:Label ID="lblofficeEmail" runat="server"></asp:Label>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>--%>
    <ul class="section-nav">
        <li><a href="#search-banner" class="search" title="Search">
            <asp:Localize ID="localize39" runat="server" meta:resourcekey="localize39Resource1" Text="Search"></asp:Localize></a></li>
        <li><a href="#locals" class="locals" title="My City">
            <asp:Localize ID="localize40" runat="server" meta:resourcekey="localize40Resource1" Text="My City"></asp:Localize></a></li>
        <li><a href="#open" class="open" title="Open Data">
            <asp:Localize ID="localize41" runat="server" meta:resourcekey="localize41Resource1" Text="Open Data"></asp:Localize></a></li>
        <li><a href="#secondPart" title="Government Headlines">
            <asp:Localize ID="localize42" runat="server" meta:resourcekey="localize42Resource1" Text="Headlines"></asp:Localize></a></li>
    </ul>
    <%--<script src="js/jquery.min.js"></script>--%>
     <%--  <script src="js/jquery.min.js"></script>
    <script>
        jQuery.noConflict();
        // Code that uses other library's $ can follow here.
</script>--%>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/general.js"></script>
    <script src="js/function.js"></script>
     <%--<script src="js/searchIIM.min.js"></script>--%>
      <script src="js/search.min.js"></script>
    <%--  <script src="js/search.min.js"></script>
    <%-- <script src="js/MapsOnline.js"></script>--%>
   <%-- <script src="js/searchIIM.min.js"></script>--%>


    <%--   <cc1:ModalPopupExtender ID="ModalPopupExtMoreDept" runat="server" TargetControlID="AMD"
        PopupControlID="PNL" BackgroundCssClass="modalBackground" CancelControlID="btncloseMoreDept" BehaviorID="ModalPopupExtMoreDept" DynamicServicePath="" />
    <asp:Panel ID="PNL" runat="server" Style="display: none; background-color: White; border-width: 2px; border-color: Black; width: 50%; border-style: solid; top: 10px !important;" meta:resourcekey="PNLResource1">
        <div class="panel panel-default" style="top: 10px !important;">
            <div class="panel-heading clearfix">
                <h3 class="panel-title">
                    <asp:Label ID="lblAppliInfo" CssClass="control-label col-sm-11 " runat="server"
                        Text="GoG Department Websites" meta:resourcekey="lblAppliInfoResource1"></asp:Label></h3>
                <asp:ImageButton ID="btncloseMoreDept" ImageUrl="~/Images/CloseButton.png" Width="20px" runat="server" meta:resourcekey="btncloseMoreDeptResource1" />
            </div>
            <div class="panel-body">
                <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" meta:resourcekey="Panel1Resource1">
                    <div class="panel-body" style="height: 350px;">

                        <ul class="list-group">
                            <li class="list-group-item list-group-item-success"><a href="http://www.agri.gujarat.gov.in/" target="_blank">
                                <h4>Agriculture</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://geda.gujarat.gov.in/" target="_blank">
                                <h4>Climate Change</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://gujarat-education.gov.in" target="_blank">
                                <h4>Education</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://guj-epd.gov.in/" target="_blank">
                                <h4>Energy & Petrochemicals</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://financedepartment.gujarat.gov.in/" target="_blank">
                                <h4>Finance</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://www.fcsca.gujarat.gov.in/" target="_blank">
                                <h4>Food & Civil Supplies Department</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://www.envforguj.in/" target="_blank">
                                <h4>Forest & Environment</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://gad.gujarat.gov.in/" target="_blank">
                                <h4>General Administration Department</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://gujhealth.gov.in/" target="_blank">
                                <h4>Health & Family Welfare</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://home.gujarat.gov.in/homedepartment/frmMain.aspx" target="_blank">
                                <h4>Home</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://imd-gujarat.gov.in/" target="_blank">
                                <h4>Industries & Mines</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://www.gujaratinformation.net/" target="_blank">
                                <h4>Information</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://www.labour.gujarat.gov.in/" target="_blank">
                                <h4>Labour & Employment</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://lpd.gujarat.gov.in/" target="_blank">
                                <h4>Legeslative & Parliamentary</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://panchayat.gujarat.gov.in/panchayatvibhag/" target="_blank">
                                <h4>Panchayat</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://pnt.gujarat.gov.in/pnt/" target="_blank">
                                <h4>Ports & Transport</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://revenuedepartment.gujarat.gov.in" target="_blank">
                                <h4>Revenue</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://rnbgujarat.org/" target="_blank">
                                <h4>Road & Building</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://dst.gujarat.gov.in/" target="_blank">
                                <h4>Science & Technology</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://sje.gujarat.gov.in/" target="_blank">
                                <h4>Social Justice & Empowerment</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://www.sycd.gujarat.gov.in/" target="_blank">
                                <h4>Sports</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://tribal.gujarat.gov.in/" target="_blank">
                                <h4>Tribal</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://udd.gujarat.gov.in/" target="_blank">
                                <h4>Urban</h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://wcd.gujarat.gov.in/" target="_blank">
                                <h4>Women & Child</h4>
                            </a></li>
                        </ul>

                    </div>
                </asp:Panel>
            </div>

        </div>


    </asp:Panel>--%>
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
                        <asp:TextBox ID="txtSearchCity" placeholder="Search City like Gandhinagar" Width="215px" runat="server" CssClass="form-control "></asp:TextBox>
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
                    </div>
                    <div class="col-xs-1">
                        <asp:Button ID="btnSearchGo" CssClass="btn btn-default reg" runat="server" Text="Go" />
                    </div>
                </div>


            </div>
            <div class="panel-body">
                <asp:Panel ID="Panel3" runat="server" ScrollBars="Auto" meta:resourcekey="Panel3Resource1">
                    <div class="panel-body table-responsive myAcctab" style="height: 60px;" id="divids" runat="server">
                        <asp:DataList ID="dlCity" runat="server" CssClass="table table-striped" RepeatColumns="6" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnk" runat="server" ForeColor="Black" OnClick="lnk_Click" Text='<%# Eval(IIf(Session("MyCulture") = "en-GB", "CityName", "CityNameG"))%>'></asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle CssClass="MapItem" />
                        </asp:DataList>

                    </div>
                </asp:Panel>
            </div>

        </div>


    </asp:Panel>
</asp:Content>
