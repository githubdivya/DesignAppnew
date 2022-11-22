<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="MoreApps.aspx.vb" Inherits="DesignApp.MoreApps" meta:resourcekey="PageResource1" %>
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
                            <h1> <asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="Mobile Apps"></asp:Localize></h1>
                </div>
            </div>
            <div class="row">
                <ul class="list-group">
                            <li class="list-group-item list-group-item-success"><a href="http://ikhedut.aau.in/1" target="_blank">
                                <h4> <asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="ધાન્ય પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://ikhedut.aau.in/4" target="_blank">
                                <h4><asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="તેલીબિયાં પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://ikhedut.aau.in/5" target="_blank">
                                <h4><asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize4Resource1" Text="કઠોળ પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://ikhedut.aau.in/9" target="_blank">
                                <h4><asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize5Resource1" Text="ફળ પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://ikhedut.aau.in/11" target="_blank">
                                <h4><asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize6Resource1" Text="ખેતીમાં ગુણવત્તા"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://ikhedut.aau.in/14" target="_blank">
                                <h4><asp:Localize ID="localize7"   runat="server" meta:resourcekey="localize7Resource1" Text="પશુ પાલન"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://ikhedut.aau.in/6" target="_blank">
                                <h4><asp:Localize ID="localize8"   runat="server" meta:resourcekey="localize8Resource1" Text="રોકડિયા પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://ikhedut.aau.in/7" target="_blank">
                                <h4><asp:Localize ID="localize9"   runat="server" meta:resourcekey="localize9Resource1" Text="શાકભાજી પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://ikhedut.aau.in/2" target="_blank">
                                <h4><asp:Localize ID="localize10"   runat="server" meta:resourcekey="localize10Resource1" Text="ઔષધિય પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://ikhedut.aau.in/8" target="_blank">
                                <h4><asp:Localize ID="localize11"   runat="server" meta:resourcekey="localize11Resource1" Text="મરીમસાલાં પાકો"></asp:Localize></h4>
                            </a></li>
                           
                            <li class="list-group-item list-group-item-danger"><a href="http://ikhedut.aau.in/3" target="_blank">
                                <h4><asp:Localize ID="localize12"   runat="server" meta:resourcekey="localize12Resource1" Text="ઘાસચારાના પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-warning"><a href="http://ikhedut.aau.in/10" target="_blank">
                                <h4><asp:Localize ID="localize13"   runat="server" meta:resourcekey="localize13Resource1" Text="ફુલછોડ પાકો"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-success"><a href="http://ikhedut.aau.in/16" target="_blank">
                                <h4><asp:Localize ID="localize14"   runat="server" meta:resourcekey="localize14Resource1" Text="ક્રૃષિ ક્ષેત્રમાં શિક્ષણ"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-info"><a href="http://ikhedut.aau.in/17" target="_blank">
                                <h4><asp:Localize ID="localize15"   runat="server" meta:resourcekey="localize15Resource1" Text="વૈજ્ઞાનિક ખેતી પધ્ધતિ"></asp:Localize></h4>
                            </a></li>
                            <li class="list-group-item list-group-item-danger"><a href="http://ikhedut.aau.in/18" target="_blank">
                                <h4><asp:Localize ID="localize16"   runat="server" meta:resourcekey="localize16Resource1" Text="અનુભવ સીડ્સ સંપર્ક માટેની માહિતી"></asp:Localize></h4>
                            </a></li>
                </ul>

            </div>
        </div>


    </section>
</asp:Content>
