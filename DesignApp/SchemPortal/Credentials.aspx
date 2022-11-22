<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="Credentials.aspx.vb" Inherits="DesignApp.Credentials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script language="javascript" type="text/javascript">
         function OpenWindow() {
             window.open("FilterPara.aspx", "mywindow", "menubar=0,resizable=0," + "width=600,height=500,toolbars=0");

         }
    </script>
    <div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%">
                        <tr valign="top">
                            <td class="leftpanellnk" colspan="2"></td>
                        </tr>
                        <tr valign="top">
                            <td colspan="2" height="10px">
                                <tr>
                                    <td colspan="2">
                                        <div align="center">
                                            <img alt="" src="Images/PersonalisedSearch.png">
                                        </div>
                                    </td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2" background="Images/mukline.gif">
                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                </tr>
                                <tr valign="top">
                                    <td colspan="2">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 731px">
                                        <table cellpadding="2" cellspacing="2" border="0" width="100%" align="center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblsec" runat="server" Text="Select the Sector of your Interest " CssClass="control-label" meta:resourcekey="lblsecResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList ID="ddlSector" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddlSectorResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblCat" runat="server" Text="Select the category of scheme facilitated   by " CssClass="control-label" meta:resourcekey="lblCatResource1"></asp:Label>
                                                    <br />
                                                    <asp:Label ID="lblcattext" runat="server" CssClass="labels" Text="(State Gov./Central Gov./NGO/Lokfalo etc..)" meta:resourcekey="lblcattextResource1"></asp:Label></td>
                                                <td valign="top" style="height: 45px;">
                                                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddlCategoryResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblReligion" runat="server" Text="Your Religion" CssClass="control-label" meta:resourcekey="lblReligionResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList ID="ddlReligion" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddlReligionResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblCaste" runat="server" Text="Your Caste" CssClass="control-label" meta:resourcekey="lblCasteResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList ID="ddlCaste" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddlCasteResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblSociostd" runat="server" Text="Your Socio Economic Standard" CssClass="control-label" meta:resourcekey="lblSociostdResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList runat="server" ID="ddlSocioStd" CssClass="form-control" Width="250px" meta:resourcekey="ddlSocioStdResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td style="height: 20px">
                                                    <asp:Label runat="server" ID="lblGender" Text="Select Gender Related Status" CssClass="control-label" meta:resourcekey="lblGenderResource1"></asp:Label></td>
                                                <td style="height: 45px">
                                                    <asp:DropDownList runat="server" ID="ddlGender" CssClass="form-control" Width="250px">
                                                        <asp:ListItem Value="00" Text="Any(કોઈપણ)"></asp:ListItem>
                                                        <asp:ListItem Value="M0" Text="Male(પુરુષો)"></asp:ListItem>
                                                        <asp:ListItem Value="F0" Text="Female(સ્ત્રીઓ)"></asp:ListItem>
                                                        <asp:ListItem Value="C0" Text="Children(બાળકો)"></asp:ListItem>
                                                        <asp:ListItem Value="CM" Text="Boys(છોકરાઓ)"></asp:ListItem>
                                                        <asp:ListItem Value="CF" Text="Girls(છોકરીઓ)"></asp:ListItem>
                                                        <asp:ListItem Value="FW" Text="Widow(વિધવાઓ)"></asp:ListItem>
                                                        <asp:ListItem Value="MW" Text="Windower(વિધૂર)"></asp:ListItem>
                                                        <asp:ListItem Value="FO" Text="Infidelity(ત્યકતાઓ)"></asp:ListItem>


                                                    </asp:DropDownList>
                                                    <%--<asp:DropDownList runat="server" ID="ddlGender" CssClass="form-control" Width="250px" meta:resourcekey="ddlGenderResource1">
                                                        <asp:ListItem Value="M0F0CMCFMWFWF0FO00" meta:resourcekey="ListItemResource1" Text=" Any(કોઈપણ)"></asp:ListItem>
                                                        <asp:ListItem Value="M0CMC000MW" meta:resourcekey="ListItemResource2" Text="Male(પુરુષો)"></asp:ListItem>
                                                        <asp:ListItem Value="F0CFC0FW00FO" meta:resourcekey="ListItemResource3" Text="Female(સ્ત્રીઓ)"></asp:ListItem>
                                                        <asp:ListItem Value="M0MW00" meta:resourcekey="ListItemResource4" Text="Windower(વિધૂર)"></asp:ListItem>
                                                        <asp:ListItem Value="F0Fw00FO" meta:resourcekey="ListItemResource5" Text="Widow(વિધવાઓ)"></asp:ListItem>
                                                        <asp:ListItem Value="F0FO00" meta:resourcekey="ListItemResource6" Text="Orphan(અનાથ)"></asp:ListItem>
                                                    </asp:DropDownList>--%></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="lblAge" Text="Your Age " CssClass="control-label" meta:resourcekey="lblAgeResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:TextBox runat="server" ID="txtAge" CssClass="form-control" MaxLength="2" Width="69px" meta:resourcekey="txtAgeResource1"></asp:TextBox>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 26px">
                                                    <asp:Label runat="server" ID="lblIncome" Text="Your Income " CssClass="control-label" meta:resourcekey="lblIncomeResource1"></asp:Label></td>
                                                <td style="height: 45px">
                                                    <asp:TextBox ID="txtIncome" runat="server" CssClass="form-control" MaxLength="12"
                                                        Width="69px" meta:resourcekey="txtIncomeResource1"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label2" runat="server" CssClass="control-label" Text="Your Family Income" meta:resourcekey="Label2Resource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:TextBox ID="txtFamIncome" runat="server" CssClass="form-control"
                                                        MaxLength="2" Width="69px" meta:resourcekey="txtFamIncomeResource1"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="lblProfession" Text="Your Profession" CssClass="control-label" meta:resourcekey="lblProfessionResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList runat="server" ID="ddlProfession" CssClass="form-control" Width="250px" meta:resourcekey="ddlProfessionResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="lblEducation" Text="Your Education" CssClass="control-label" meta:resourcekey="lblEducationResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList runat="server" ID="ddlEducation" CssClass="form-control" Width="350px" meta:resourcekey="ddlEducationResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="lblScAppTo" Text="For Whom You are Searching Scheme" CssClass="control-label" meta:resourcekey="lblScAppToResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList runat="server" ID="ddlScAppTo" CssClass="form-control" Width="350px" meta:resourcekey="ddlScAppToResource1">
                                                    </asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblScAppArea" runat="server" Text="Select Your Area" CssClass="control-label" meta:resourcekey="lblScAppAreaResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList runat="server" ID="ddlScAppArea" CssClass="form-control" Width="350px" meta:resourcekey="ddlScAppAreaResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblBFType" runat="server" Text="Select Benefits Type" CssClass="control-label" meta:resourcekey="lblBFTypeResource1"></asp:Label></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList runat="server" ID="ddlBFType" CssClass="form-control" Width="350px" meta:resourcekey="ddlBFTypeResource1"></asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="height: 24px">
                                                    <asp:Button ID="btnSubmit" Text="Wide Search" runat="server" CssClass="btn btn-info" meta:resourcekey="btnSubmitResource1" Visible="false" />
                                                    <asp:Button ID="btnExact" Text="Search" runat="server" CssClass="btn btn-info" meta:resourcekey="btnExactResource1" />
                                                    <asp:Button ID="btnnormal" Text="Normal Search" runat="server" CssClass="btn btn-info" meta:resourcekey="btnnormalResource1" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2"></td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="height: 13px">
                                                    <asp:Label ID="Label1" runat="server" CssClass="lblRed" meta:resourcekey="Label1Resource1"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" DataKeyNames="SchemeCode" CssClass="datagrid" GridLines="Horizontal" ShowFooter="True" meta:resourcekey="GridView1Resource1">
                                                        <Columns>
                                                            <asp:BoundField DataField="SchemeCode" HeaderText="SchemeCode" Visible="False" meta:resourcekey="BoundFieldResource1" />
                                                            <asp:BoundField DataField="SchemeName" HeaderText="SchemeName" meta:resourcekey="BoundFieldResource2" />
                                                            <asp:BoundField DataField="GistOfScheme" HeaderText="Gist Of Scheme" meta:resourcekey="BoundFieldResource3" />
                                                            <asp:HyperLinkField DataNavigateUrlFields="SchemeCode" Text="More Details" DataNavigateUrlFormatString="MoreDetails.aspx?Scode={0}" meta:resourcekey="HyperLinkFieldResource1" />
                                                        </Columns>
                                                        <RowStyle CssClass="itemStyle" BackColor="White" />
                                                        <HeaderStyle CssClass="headerStyle2" />
                                                        <AlternatingRowStyle CssClass="itemStyle" BackColor="#E3F1F2" />
                                                        <FooterStyle CssClass="headerStyle2" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="height: 17px"></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
