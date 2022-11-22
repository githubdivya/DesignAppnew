<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="ContactUs.aspx.vb" Inherits="DesignApp.ContactUs" meta:resourcekey="PageResource1" %>
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
                            <h1><asp:Localize ID="localize7"  Visible="false" runat="server" meta:resourcekey="localize7Resource1" Text="Key State Officials"></asp:Localize></h1>
                </div>
            </div>
            <div class="row">
                <div class ="col-md-6 col-sm-3" id="contactDiv" runat="server" visible="false">
                <ul class="list-group">
                    <li class="list-group-item list-group-item-success"><a href="http://gujaratindia.com/whos-who/chief-secretaries.htm" target="_blank">
                   <asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="Chief Secretary"></asp:Localize>
                    </a></li>
                    <%--<li class="list-group-item list-group-item-info"><a href="http://gujaratindia.com/whos-who/chief-justice.htm" target="_blank">
                        <h4>Chief Justice</h4>
                    </a></li>--%>
                    <li class="list-group-item list-group-item-info"><a href="http://gujaratindia.com/whos-who/secretaries.htm" target="_blank">
                    <asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="Secretaries"></asp:Localize> 
                    </a></li>
                    <li class="list-group-item list-group-item-danger"><a href="http://gujaratindia.com/whos-who/collectors.htm" target="_blank">
                     <asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="Collectors"></asp:Localize>
                    </a></li>
                    <li class="list-group-item list-group-item-warning"><a href="http://gujaratindia.com/whos-who/ddo.htm" target="_blank">
                     <asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize4Resource1" Text="  District Development Officer"></asp:Localize>
                    </a></li>
                    <li class="list-group-item list-group-item-success"><a href="http://gujaratindia.com/whos-who/board-corp.htm" target="_blank">
                      <asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize5Resource1" Text="  Boards and Corporations"></asp:Localize>
                    </a></li>
                    <li class="list-group-item list-group-item-info"><a href="http://gujaratindia.com/whos-who/cmo-net.htm" target="_blank">
                     <asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize6Resource1" Text=" CMO Net"></asp:Localize>
                    </a></li>


                </ul>

            </div>
                  <div class ="col-md-6 col-sm-3">
                      <div class="serviceName"> 

                          <h1><asp:Label ID="Contact" runat="server" Text="Digital Gujarat (Help Desk )"></asp:Label></h1>
                      </div>
                     <h2> <a class="contact " href ="#"></a><asp:Label ID="helpdesk" runat="server" Text="Contact No :"> </asp:Label>
                       <asp:Label ID="HelpNumber" runat="server" Text="18002335500"></asp:Label></h2>
                 </div>
                

            </div>
        </div>


    </section>
</asp:Content>
