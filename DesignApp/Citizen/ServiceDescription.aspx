<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="ServiceDescription.aspx.vb" Inherits="DesignApp.ServiceDescription" meta:resourcekey="PageResource1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Script/jquery-1.10.2.min.js"></script>
    <script>
        $(document).ready(function () {


            //$(document).on("click", "#Overview", function (event) {
            //    event.preventDefault();
            //    $("#certificate_Instruction").hide();
            //    $("#discription").show();
            //});
            $(document).on("click", "#Instruction", function (event) {
                event.preventDefault();
                $("#discription").hide();
                $("#certificate_Instruction").show();
            });
        });




    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section id="form">
        <!--Service page start-->
        <div class="container">
            <div class="row">
                <div class="col-md-12" style="text-align: center">
                    <br />
                    <h1>
                        <%--    <asp:Label runat="server" ID="servicename" ></asp:Label>--%>
                    </h1>
                </div>
            </div>
            <div class="certiInfo" style="padding: 5px">

                <div class="panel panel-default">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-2">
                                <a id="Instruction" class="control-label btn btn-default reg" href="#">
                                    <asp:Localize runat="server" meta:resourcekey="LocalizeResource2"></asp:Localize></a>
                            </div>
                            <div class="col-xs-2">

                                <%--<a id="Overview" class="control-label btn btn-default reg" href="#" >
                                    <asp:Localize runat="server" meta:resourcekey="LocalizeResource1"></asp:Localize></a>--%>
                            </div>
                            <div class="col-xs-8">
                            </div>


                        </div>





                    </div>
                    <div class="panel-body">

                        <div id="discription" style="display: none;">

                            <div class="row form-group ">
                                <div class="col-xs-3   has-warning">

                                    <asp:Label runat="server" CssClass="control-label " meta:resourcekey="LocalizeResource3" Text="૧ જોગવાઈ"> </asp:Label>


                                </div>
                                <div class="col-xs-1 ">:          </div>
                                <div class="col-xs-8 has-success">
                                    <label runat="server" class="control-label" id="d1"></label>
                                </div>

                            </div>
                            <div class="row form-group">
                                <div class="col-xs-3  has-warning">

                                    <h6 class="control-label">
                                        <asp:Localize runat="server" meta:resourcekey="LocalizeResource4" Text="ર અરજી કોને કરવી"></asp:Localize></h6>
                                </div>
                                <div class="col-xs-1 ">:          </div>
                                <div class="col-xs-8 has-success">
                                    <label runat="server" class="control-label" id="d2"></label>
                                </div>

                            </div>
                            <div class="row form-group ">
                                <div class="col-xs-3 has-warning">

                                    <h6 class="control-label">
                                        <asp:Localize runat="server" meta:resourcekey="LocalizeResource5" Text="૩ નિકાલ માટેના સત્તાધિકારી "></asp:Localize></h6>
                                </div>
                                <div class="col-xs-1 ">:          </div>
                                <div class="col-xs-8 has-success">
                                    <label runat="server" id="d3" class="control-label"></label>
                                </div>

                            </div>
                            <div class="row form-group ">
                                <div class="col-xs-3 has-warning ">

                                    <h6 class="control-label">
                                        <asp:Localize runat="server" meta:resourcekey="LocalizeResource6" Text="૪ નિકાલની સમય મર્યાદા "></asp:Localize></h6>
                                </div>
                                <div class="col-xs-1 ">:          </div>
                                <div class="col-xs-8 has-success">
                                    <label runat="server" id="d4" class="control-label"></label>
                                </div>

                            </div>


                        </div>


                        <div id="certificate_Instruction">

                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h3 class="panel-title">
                                        <asp:Label ID="Label1" runat="server" CssClass="control-label"
                                            Text="Service Name "></asp:Label>
                                    </h3>
                                </div>

                                <div class="panel-body">
                                    <div class="row form-group has-error ">
                                        <div class="col-xs-12 ">
                                            <h4><b>
                                                <asp:Label runat="server" ID="servicename"></asp:Label>
                                            </b></h4>
                                        </div>
                                    </div>


                                </div>
                            </div>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h3 class="panel-title">
                                        <asp:Label ID="Label7" runat="server" CssClass="control-label"
                                            Text="Instructions " meta:resourcekey="lblProofResource1"></asp:Label>
                                    </h3>
                                </div>

                                <div class="panel-body">
                                    <div class="row form-group has-error ">
                                        <div class="col-xs-12 ">

                                            <ul runat="server" id="ServiceGroup"></ul>

                                        </div>
                                    </div>


                                </div>
                            </div>




                            <div class="row form-group has-error ">
                                <div class="col-xs-12">
                                    <asp:Label ID="Label8" runat="server" CssClass="control-label"
                                        Text="Note: You Need to Attach The Following Documents While Applying for a service and Passport size photo." meta:resourcekey="Label8Resource1"></asp:Label>

                                </div>
                            </div>



                            <%--  <div class="proof" style="overflow:hidden;">--%>
                            <div class="row row_td ">
                                <div class="col-xs-12 ">
                                    <asp:GridView ID="Grv_Proof_Group" CssClass="col-sm-12" runat="server" AutoGenerateColumns="false" ShowHeader="false"
                                        DataKeyNames="AttachmentGroupID">
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <div class="panel panel-default ">
                                                        <div class="panel-heading clearfix ">
                                                            <h3 class="panel-title">
                                                                <asp:Label ID="lbl123" CssClass="control-label" runat="server" Text='<%# Eval("AttachmentGroupName_E")%>'></asp:Label></h3>
                                                        </div>
                                                        <div class="panel-body">
                                                            <div class="row row_td ">
                                                                <div class="col-xs-12 ServiceDocumentAttach ">
                                                                    <asp:BulletedList ID="lstAttachmentGroup" runat="server"></asp:BulletedList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>

                            <div class="panel panel-default" id="divattachment" runat="server" visible="false">
                                <div class="panel-heading">
                                    <h3 class="panel-title">
                                        <asp:Label ID="lblProof" runat="server" CssClass="control-label"
                                            Text="Proof Needed In Service Attachment" meta:resourcekey="lblProofResource4"></asp:Label>
                                    </h3>
                                </div>
                                <div class="panel-body  ">
                                    <div class="row  form-group has-success">
                                        <div class="col-xs-12 ServiceDocumentAttach">
                                            <asp:BulletedList CssClass="control-label" ID="lstAttachmentService" runat="server" meta:resourcekey="lstAttachmentServiceResource1"></asp:BulletedList>
                                        </div>
                                    </div>

                                </div>
                            </div>


                            <%-- </div>--%>
                        </div>
                        <div class="row  ">
                            <div class="col-xs-2">
                                <asp:LinkButton CssClass="btn btn-default reg" runat="server" ID="download" meta:resourcekey="downloadResource1" Text="ડાઉનલોડ ફોર્મ"></asp:LinkButton>
                            </div>
                            <div class="col-xs-3">

                                <a class="btn btn-default reg" onclick="window.open('<%=Convert.ToString("../Policies/PaymentTermsCondition.aspx")%>','Payment','width=1550,height=650')">
                                    <asp:Localize ID="localize2" runat="server" meta:resourcekey="btnPayemnttermsResource1" Text="Login ">Payment Terms & Condition</asp:Localize></a>
                            </div>
                            
                            <div class="col-xs-2">
                                <asp:LinkButton CssClass="btn btn-default reg" runat="server" ID="apply" meta:resourcekey="applyResource1" Text="ઓનલાઇન અરજી"></asp:LinkButton>
                            </div>
                            <div class="col-xs-5">
                            </div>
                        </div>
                    </div>

                </div>



            </div>
        </div>
    </section>
    <%--   <div class="content-container">
                            <article class="jobs content-item representatives" id="reps">
					<h3><a class="mis" href="#">Important Policies</a></h3>
					<div class="aggregator" data-type="legislator" data-address="auto">
						<ul>
							<li>
								<a href="http://ic.gujarat.gov.in/?page_id=3639" target="_blank"><h4>The New Industrial Policy 2015</h4></a>
							</li>
							<li>
								<a href="http://dst.gujarat.gov.in/images/pdf/electronics_policy_12nov2014.pdf" target="_blank"><h4>Electronic Policy 2014 </h4></a>
							</li>
							<li>
								<a href="http://dst.gujarat.gov.in/Images/final-it-policy-document.pdf" target="_blank"><h4>IT Policy 2014</h4></a>
							</li>
							<li>
								<a href="http://ic.gujarat.gov.in/?page_id=2295" target="_blank"><h4>Textile Policy </h4></a>
							</li>
                            <li>
								<a href="http://dst.gujarat.gov.in/Images/final-gujarat-egovernance-policy.pdf" target="_blank"><h4>eGovernance Policy 2014</h4></a>
							</li>
					</ul>

					</div>									
				</article>
                            </div> --%>
   <%-- <script src="../js/jquery.min.js"></script>--%>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/general.js"></script>
    <script src="../js/function.js"></script>
</asp:Content>
