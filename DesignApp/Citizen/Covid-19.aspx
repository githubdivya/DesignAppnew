<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="Covid-19.aspx.vb" Inherits="DesignApp.Covid_19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />
    	<div class="formScript form1">
    <div class="row">
        <div class="col-lg-2"></div>
        <div class="col-lg-4">
            <asp:Label ID="lblService" runat="server" Text="COVID-19 Lockdown Exemption Pass for Movement within Gujarat" Visible="false"></asp:Label>
        </div>
        <div class="col-lg-2">
           <a href="https://www.digitalgujarat.gov.in/loginapp/Download/CovidGuidlines.pdf" class="control-label" style="color:blue" target="_blank">User Manual
                                          <%--<asp:Localize runat="server" Text ="User Manual" ></asp:Localize>--%>    </a>                            
        </div>
        <div class="col-lg-2">
            <a class="registration " href="https://www.digitalgujarat.gov.in/loginapp/CitizenLogin.aspx" style="color:blue">Apply Now
                                            <%--<asp:Localize ID="localize21" runat="server" meta:resourcekey="localize16Registration" Text="Apply Now"></asp:Localize>--%></a>
        </div>
    </div>
              <br />
   
     <div class="row">
         <div class="col-lg-2"></div>
        <div class="col-lg-4">
            <asp:Label ID="Label1" runat="server" Text="COVID-19 Lockdown Exemption Pass for Movement out of Gujarat"></asp:Label>
        </div>
        <div class="col-lg-2">
          <a href="https://www.digitalgujarat.gov.in/loginapp/Download/CovidGuidlinesoutofState.pdf" class="control-label" style="color:blue" target="_blank" >User Manual
                                         <%-- <asp:Localize runat="server" Text ="User Manual" ></asp:Localize>--%>     </a>                           
        </div>
        <div class="col-lg-2">
            <a class="registration " href="https://www.digitalgujarat.gov.in/loginapp/CitizenLogin.aspx" style="color:blue">Apply Now
                                            <%--<asp:Localize ID="localize1" runat="server" meta:resourcekey="localize16Registration" Text="Apply Now">--%><%--</asp:Localize>--%></a>
        </div>
    </div>
              <br />
    
     <div class="row">
         <div class="col-lg-2"></div>
        <div class="col-lg-4">
            <asp:Label ID="Label2" runat="server" Text="Pass for coming to Gujarat from other state"></asp:Label>
        </div>
        <div class="col-lg-2">
          <a href="https://www.digitalgujarat.gov.in/loginapp/Download/comingtogujarat.pdf" class="control-label" style="color:blue" target="_blank">User Manual
                                         <%-- <asp:Localize runat="server" Text ="User Manual" ></asp:Localize> --%>   </a>                        
        </div>
        <div class="col-lg-2">
            <a class="registration " href="https://www.digitalgujarat.gov.in/loginapp/CitizenLogin.aspx" style="color:blue" >Apply Now
                                           <%-- <asp:Localize ID="localize2" runat="server" meta:resourcekey="localize16Registration" Text="Apply Now"></asp:Localize>--%></a>
        </div>
    </div>
            </div>
     <br />
    <br />
    <br />
</asp:Content>
