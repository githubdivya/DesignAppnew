<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/frmEGram.Master" CodeBehind="frmEGram.aspx.vb" Inherits="DesignApp.frmEGram1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<section class="photo-section">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-12 col-lg-3">
                    <div class="dg-cm-msg-box">
                        <div class="dg-cm-box position-relative mb-2">
                            <div class="dg-cm-photo position-relative">
                                <img src="frmMain1/images/cm-photo.jpg" alt="digital gujarat" />
                            </div>
                            <!-- dg-cm-photo ends -->
                            <div class="dg-box-design-top position-absolute bg-delta"></div>
                            <div class="dg-box-design-bottom position-absolute bg-delta"></div>
                        </div>
                        <!-- dg-cm-box ends -->
                        <div class="clear"></div>
                        <h3 class="dg-cm-name text-md weight-600 text-center text-alpha"> <asp:Localize ID="localize1Resource1"   runat="server" meta:resourcekey="localize1Resource1" Text="Shri Vijaybhai Rupani"></asp:Localize>
                            </h3>
                        <h4 class="dg-cm-salutation weight-600 text-center text-sm text-alpha"><asp:Localize ID="localizeResource2"   runat="server" meta:resourcekey="localize1Resource2" Text="Hon'ble Chief Minister of Gujarat"></asp:Localize></h4>
                    </div>
                    <!-- dg-cm-msg-box ends -->
                </div>
              <div class="col-12 offset-lg-2 col-lg-3">
                    <div class="home-ser-count">
                        <h3 class="text-md weight-700 text-alpha">Services</h3>
                        <div class="roundone">
                            <div class="innerNum">
                                <asp:Label ID="lbltotalservices" runat="server" Text="Label"></asp:Label>
                              
                            </div>
                        </div>                        
                    </div>
                </div>
                <div class="col-12 col-lg-3">
                    <div class="home-ser-count">
                        <h3 class="text-md weight-700 text-alpha">Grampanchayat</h3>
                        <div class="roundtwo">
                            <div class="innerNum">
                                
                                <asp:Label ID="lbltotalgram" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>                        
                    </div>
                </div>
            </div>
        </div>
    </section>--%>

    <section class="photo-section">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-12 col-lg-3">
                    <div class="dg-cm-msg-box">
                        <div class="dg-cm-box position-relative mb-2">
                            <div class="dg-cm-photo position-relative">
                                <img src="frmMain1/images/cm-photo.jpg" alt="digital gujarat" />
                            </div>
                            <!-- dg-cm-photo ends -->
                            <div class="dg-box-design-top position-absolute bg-delta"></div>
                            <div class="dg-box-design-bottom position-absolute bg-delta"></div>
                        </div>
                        <!-- dg-cm-box ends -->
                        <div class="clear"></div>
                        <h3 class="dg-cm-name text-md weight-600 text-center text-alpha">
                            <asp:Localize ID="localize1Resource1" runat="server" meta:resourcekey="localize1Resource1" Text="Shri Vijaybhai Rupani"></asp:Localize>
                        </h3>
                        <h4 class="dg-cm-salutation weight-600 text-center text-sm text-alpha m-0">
                            <asp:Localize ID="localizeResource2" runat="server" meta:resourcekey="localize1Resource2" Text="Hon'ble Chief Minister of Gujarat"></asp:Localize></h4>
                    </div>
                    <!-- dg-cm-msg-box ends -->
                </div>
                <div class="col-12 col-lg-3">
                    <div class="home-ser-count">
                        <asp:LinkButton runat="server" ID="lnkService" OnClick="lnkService_Click" class="tservices">
                             <h3 class="text-md weight-600 mb-3">Services</h3>
                            <i class="fas fa-cogs mb-3"></i>
                            <p class="text-md weight-700 m-0">
                                <asp:Label ID="lbltotalservices" runat="server" Text="Label"></asp:Label>
                            </p>

                        </asp:LinkButton>
                        <%--<a href="DepartmentWiseServiceCount.aspx" class="tservices">--%>
                           
                        <%--</a>--%>
                    </div>
                </div>
                <div class="col-12 col-lg-3">
                    <div class="home-ser-count">
                        <asp:LinkButton runat="server" ID="lnkgram" OnClick="lnkgram_Click" class="tgrampanchayat">
                            <h3 class="text-md weight-600 mb-3">Grampanchayat</h3>
                            <i class="fas fa-users mb-3"></i>
                            <p class="text-md weight-700 m-0">
                                <asp:Label ID="lbltotalgram" runat="server" Text="Label"></asp:Label>
                            </p>
                        </asp:LinkButton>
                    </div>
                </div>

                <div class="col-12 col-lg-3">
                    <div class="home-ser-count">
                        <a href="#" class="tapplications">
                            <h3 class="text-md weight-600 mb-3">Applications</h3>
                            <i class="fas fa-file-alt mb-3"></i>
                            <p id="lblapplication" class="text-md weight-700 m-0">
                                <asp:Label ID="lblTotalCount" runat="server" Text="Label"></asp:Label>
                            </p>
                        </a>
                    </div>
                </div>
            </div>

        </div>
    </section>

    <section class="egram-services-section pt-5">
        <div class="container">
            <h1 class="section-heading">
                <asp:Localize ID="localize1Resource3" runat="server" meta:resourcekey="localize1Resource3" Text="Top 10 Services"></asp:Localize></h1>
            <%--            <div class="row">
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/senior-ccertificate.png" alt="senior-ccertificate" />
                            <h4><asp:Localize ID="localize1Resource8"   runat="server" meta:resourcekey="localize1Resource8" Text="Senior Citizen Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/remove-name-ration-card.png" alt="" />
                            <h4><asp:Localize ID="localize1Resource5"   runat="server" meta:resourcekey="localize1Resource5" Text="Removal of Name from Ration Card"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/change-name-ration-card.png" alt="" />
                            <h4><asp:Localize ID="localize1Resource6"   runat="server" meta:resourcekey="localize1Resource6" Text="Change in Ration Card"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/income-certificate.png" alt="" />
                            <h4><asp:Localize ID="localize1Resource7"   runat="server" meta:resourcekey="localize1Resource7" Text="Income certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>


                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">
                            <img src="frmMain1/images/flaticons/appl-new-rationcard.png" alt="" />
                            <h4><asp:Localize ID="localize1Resource4"   runat="server" meta:resourcekey="localize1Resource4" Text="Application for New Ration Card"></asp:Localize></h4>                            
                        </a>
                    </div>
                </div>



                   <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">
                            <img src="frmMain1/images/flaticons/appl-new-rationcard.png" alt="" />
                            <h4><asp:Localize ID="localize14"   runat="server" meta:resourcekey="localize1Resource24" Text="Application for Duplicate Ration Card"></asp:Localize></h4>                            
                        </a>
                    </div>
                </div>

                  <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">
                            <img src="frmMain1/images/flaticons/app-rationcard-member-guardian.png" alt="Separate" />
                            <h4><asp:Localize ID="localize15"   runat="server" meta:resourcekey="localize1Resource25" Text="Application for Separate Ration Card"></asp:Localize></h4>                            
                        </a>
                    </div>
                </div>

                
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/temporary-residence.png" alt="temporary-residence" />
                            <h4><asp:Localize ID="localize1Resource9"   runat="server" meta:resourcekey="localize1Resource9" Text="Temporary Residence Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/widow-certificate.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize1Resource10"   runat="server" meta:resourcekey="localize1Resource10" Text="Widow Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/app-rationcard-member-guardian.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource11" Text="Application for Ration Card Member guardian"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/add-name-ration-card.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize1Resource12" Text="Addition of Name in Ration Card"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/unreserved-caste-certificate.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize1Resource13" Text="Unreserved Caste Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                 <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/religious-minority-certificate.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize1Resource14" Text="Religious Minority Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                 <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/nomad-denotifiedcaste-certificate.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize1Resource15" Text="Nomad-Denotified Caste Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                 <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/agriculture.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize1Resource16" Text="Krushi Sahay Package Yojna"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
             
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/income-certificate.png" alt="Income-certificate" />
                            <h4><asp:Localize ID="localize7"   runat="server" meta:resourcekey="localize1Resource17" Text="Affidavit for Income Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>

                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/widow-certificate.png" alt="widow-certificate" />
                            <h4><asp:Localize ID="localize8"   runat="server" meta:resourcekey="localize1Resource18" Text="Affidavit for Widow Assistance related"></asp:Localize></h4>
                        </a>
                    </div>
                </div>


                 <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/appl-new-rationcard.png" alt="RationCard" />
                            <h4><asp:Localize ID="localize9"   runat="server" meta:resourcekey="localize1Resource19" Text="Affidavit for Ration Card service"></asp:Localize></h4>
                        </a>
                    </div>
                </div>

                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/unreserved-caste-certificate.png" alt="CasteCertificate" />
                            <h4><asp:Localize ID="localize10"   runat="server" meta:resourcekey="localize1Resource20" Text="Affidavit for Caste Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>

                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/change-name-ration-card.png" alt="ChangeInName" />
                            <h4><asp:Localize ID="localize11"   runat="server" meta:resourcekey="localize1Resource21" Text="Affidavit for change in Name"></asp:Localize></h4>
                        </a>
                    </div>
                </div>


                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/other-readyaffidavit.png" alt="Other" />
                            <h4><asp:Localize ID="localize12"   runat="server" meta:resourcekey="localize1Resource22" Text="Other Ready Affidavit"></asp:Localize></h4>
                        </a>
                    </div>
                </div>

                 <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/language-cir1.png" alt="Linguistic" />
                            <h4><asp:Localize ID="localize13"   runat="server" meta:resourcekey="localize1Resource23" Text="Linguistic Minority Certificate"></asp:Localize></h4>
                        </a>
                    </div>
                </div>


                  <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/srhmsy.png" alt="Linguistic" />
                            <h4><asp:Localize ID="localize16"   runat="server" meta:resourcekey="localize1Resource28" Text="Satyvadi Raja Harishchandra Marnotar Sahay Yojana"></asp:Localize></h4>
                        </a>
                    </div>
                </div>

                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/PHID-travel-pass.png" alt="Linguistic" />
                            <h4><asp:Localize ID="localize17"   runat="server" meta:resourcekey="localize1Resource29" Text="PHID and Travel Pass"></asp:Localize></h4>
                        </a>
                    </div>
                </div>

                 <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/sant-surdas-yojana.png" alt="Linguistic" />
                            <h4><asp:Localize ID="localize18"   runat="server" meta:resourcekey="localize1Resource30" Text="Sant Surdas Yojana"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
                <div class="col-12 col-lg-3 col-md-4 col-sm-6">
                    <div class="egarm-services">
                        <a href="#">                            
                            <img src="frmMain1/images/flaticons/samras-hostel-admission.png" alt="Linguistic" />
                            <h4><asp:Localize ID="localize19"   runat="server" meta:resourcekey="localize1Resource31" Text="Samras Hostel Admission"></asp:Localize></h4>
                        </a>
                    </div>
                </div>
            </div>--%>

            <div class="egarm-services">
                <asp:DataList ID="dlServiceList" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"ServiceId")%>'>
                     <img alt="img" src="frmMain1/images/flaticons/<%#Eval("ServiceImage")%>">
                            <h4><%#Eval("ServiceNameE")%></h4> <h5>(<%#Eval("ApplicationCount")%>)</h5>
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:DataList>
            </div>

            <div class="pt-5">
                <h1 class="section-heading">
                    <asp:Localize ID="localize1Resource30" runat="server" meta:resourcekey="localize1Resource32" Text="Top 10 GramPanchayat"></asp:Localize></h1>
                <div class="egarm-services">
                    <asp:DataList ID="dlTopGramPanchayat" runat="server" RepeatDirection="Horizontal">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"OfficeId")%>'>
                        <%-- <img alt="img" src="frmMain1/images/flaticons/birth.png">--%>
                                <h4><%#Eval("OfficeNameE")%></h4>  <h5>(<%#Eval("ApplicationCount")%>)</h5>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
