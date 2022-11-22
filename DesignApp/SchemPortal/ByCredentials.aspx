<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="ByCredentials.aspx.vb" Inherits="DesignApp.SearchDeaprtment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblexe" ForeColor="Red" meta:resourcekey="lblexeResource1"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>
                                <table cellpadding="2" cellspacing="2" align="center" width="100%">
                                    <asp:MultiView ID="MultiView1" runat="server">
                                        <asp:View ID="vDept" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchByDepartment.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label ID="lbldept" runat="server" Text="Select  Department" CssClass="control-label"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddldept" CssClass="form-control" Width="350px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="vSector" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchBySector.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label ID="lblSecor" Text="Select Sector" runat="server" CssClass="control-label"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlsector" CssClass="form-control" Width="250px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="vscappto" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchByAppTo.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Select  Scheme Applicable To" ID="lblscappto"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlScappto" CssClass="form-control" Width="250px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="vcaste" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchByCategory.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Select category" ID="lblcaste"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlcaste" CssClass="form-control" Width="250px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <%-- <asp:View ID="vcategory" runat ="server">
        <tr><td colspan ="3"><table cellpadding ="0" cellspacing ="0" width ="100%" align ="center" >
        <tr valign="top"><td colspan ="2">
        <tr><td colspan ="2"><div align="center"><img alt="" src="Images/searchbycategory.png"></div></td></tr>
        <tr valign="top"><td colspan ="2" background="Images/mukline.gif" ><img src="Images/mukline.gif" height ="3" width ="33" ></td></tr>
        <tr valign="top"><td colspan ="2">&nbsp;</td></tr></table></td></tr>
            <tr><td width ="30%"><asp:Label runat="server" CssClass ="labels" Text="Select category " ID="lblcategory" meta:resourcekey="lblcategoryResource1"></asp:Label></td>
            <td width ="8%"></td>
            <td><asp:DropDownList runat="server" ID="ddlcategory" CssClass ="textbox" Width="250px" AutoPostBack="true"></asp:DropDownList></td>
            </tr>
        </asp:View>--%>
                                        <asp:View ID="vScArea" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchBySerArea.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Select  Scheme Applicable Area" ID="lblScArea"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlScAppArea" CssClass="form-control" Width="250px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="VscBenefit" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchByBenefit.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Select Scheme Benefit" ID="lblscbenefit"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlScBenefit" CssClass="form-control" Width="250px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="VscTarget" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchBySerTarget.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Select Scheme Target" ID="lblsctarget"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td height="100%">
                                                    <asp:DropDownList runat="server" ID="ddlTarget" CssClass="form-control" Style="height: 120% !important">
                                                        <asp:ListItem Value="FA">Financial Help(આર્થીક સહાય)</asp:ListItem>
                                                        <asp:ListItem Value="PA">Physical Help(ભૌતીક સહાય)</asp:ListItem>
                                                        <asp:ListItem Value="SF">Services(Free)(સેવાઓ(વિનામુલ્ય))</asp:ListItem>
                                                        <asp:ListItem Value="SP">Services(Paid)(સેવાઓ(મુલ્ય))</asp:ListItem>
                                                    </asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="VscOwned" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchBySerOwned.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Select Scheme Owned By" ID="lblowned"></asp:Label></td>
                                                <td width="8%"></td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlOwned" CssClass="form-control" Width="250px"></asp:DropDownList></td>
                                            </tr>
                                        </asp:View>
                                        <asp:View ID="Vkeyword" runat="server">
                                            <tr>
                                                <td colspan="3">
                                                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                                        <tr valign="top">
                                                            <td colspan="2">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <div align="center">
                                                                            <img alt="" src="Images/SearchByKeyword.png"></div>
                                                                    </td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2" background="Images/mukline.gif">
                                                                        <img src="Images/mukline.gif" height="3" width="33"></td>
                                                                </tr>
                                                                <tr valign="top">
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="30%">
                                                    <asp:Label runat="server" CssClass="control-label" Text="Enter Keyword For Scheme" ID="lblkeyword"></asp:Label></td>

                                                <td>
                                                    <asp:TextBox runat="server" ID="txtSearchKeyword" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </asp:View>
                                    </asp:MultiView>

                                </table>
                               </td>
                        </tr>
                        <%-- <tr><td height ="20px"></td></tr>--%>
                        <tr>
                            <td colspan="3">
                                <img src="Images/spacer.gif" width="5%" align="top" /><asp:Button ID="btnSubmit" runat ="server" Text="Search" CssClass="btn btn-info"   /></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
