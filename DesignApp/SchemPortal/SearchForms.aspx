<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="SearchForms.aspx.vb" Inherits="DesignApp.SearchForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <table align="center" cellpadding="0" cellspacing="0" width="100%">
                        <tr valign="top">
                            <td colspan="2" height="10px">
                                <tr>
                                    <td colspan="2">
                                        <div align="center">
                                            <img alt="" src="Images/SearchForm.png"></div>
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
                                    <td>
                                        <table cellpadding="2" cellspacing="2" width="95%">
                                            <tr>
                                                <td style="height: 26px">
                                                    <asp:Label ID="lblDept" runat="server" CssClass="control-label" Text="Department" meta:resourcekey="lblDeptResource1"></asp:Label></td>
                                                <td width="10" style="height: 26px"></td>
                                                <td style="height: 45px;">
                                                    <asp:DropDownList ID="ddldept" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddldeptResource1">
                                                    </asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td style="height: 26px">
                                                    <asp:Label ID="lblfrmno" runat="server" CssClass="control-label" Text="Form No." meta:resourcekey="lblfrmnoResource1"></asp:Label></td>
                                                <td width="10" style="height: 26px"></td>
                                                <td style="height: 45px">
                                                    <asp:TextBox ID="txtFrmNo" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="txtFrmNoResource1"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td style="height: 26px">
                                                    <asp:Label ID="lblfrmDesc" runat="server" CssClass="control-label" Text="Form Description" meta:resourcekey="lblfrmDescResource1"></asp:Label></td>
                                                <td style="height: 26px" width="10"></td>
                                                <td style="height: 45px">
                                                    <asp:TextBox ID="txtdesc" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="txtdescResource1"></asp:TextBox></td>
                                            </tr>
                                            <tr runat="server" visible="false">
                                                <td style="height: 26px">
                                                    <asp:Label ID="Label1" runat="server" CssClass="control-label" Text="Form Available From" meta:resourcekey="Label1Resource1"></asp:Label></td>
                                                <td style="height: 26px" width="10"></td>
                                                <td style="height: 45px">
                                                    <asp:DropDownList ID="ddlFrmAvai" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddlFrmAvaiResource1">
                                                    </asp:DropDownList></td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <asp:Button ID="btnsearch" runat="server" CssClass="btn btn-info" Text="Search" meta:resourcekey="btnsearchResource1" /></td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <asp:Label ID="lblmsg" runat="server" ForeColor="Red" meta:resourcekey="lblmsgResource1"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td colspan="3">
                                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="FormId"
                                                        GridLines="Horizontal" meta:resourcekey="GridView1Resource1" ShowFooter="True"
                                                        Width="100%" class="table table-bordered" Style="margin-top: 10px;">
                                                        <Columns>
                                                            <asp:TemplateField meta:resourcekey="TemplateFieldResource1" Visible="false">
                                                                <ItemTemplate>
                                                                    <asp:Label ID="lblFormId" runat="server" Text='<%# Eval("FormId")%>'></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <%--<asp:BoundField DataField="FormId" HeaderText="FormId" meta:resourcekey="BoundFieldResource1"
                                        Visible="False" />--%>
                                                            <asp:BoundField DataField="SchemeName" HeaderText="Scheme Name" meta:resourcekey="BoundFieldResource2" />
                                                            <asp:BoundField DataField="FormName" HeaderText="Form Name" meta:resourcekey="BoundFieldResource3" />
                                                            <asp:BoundField DataField="FrmDesc" HeaderText="Form Description" meta:resourcekey="BoundFieldResource4" />
                                                            <%--<asp:BoundField DataField="Available" HeaderText="Available From" meta:resourcekey="BoundFieldResource5" />--%>
                                                            <asp:TemplateField HeaderText="Gujarati">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="downloadformguj" Text='<%# Eval("downloadtextguj")%>' runat="server" OnClick="downloadformguj_Click"></asp:LinkButton>

                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="English">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="downloadformeng" Text='<%# Eval("downloadtexteng")%>' runat="server" OnClick="downloadformEng_Click"></asp:LinkButton>

                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <%--<asp:ButtonField ButtonType="Link" Text="Download" CommandName="DownloadGuj" HeaderText="Gujarati"></asp:ButtonField>--%>
                                                        </Columns>
                                                        <FooterStyle CssClass="headerStyle2" />
                                                        <RowStyle CssClass="itemStyle1" />
                                                        <HeaderStyle CssClass="headerStyle2" />
                                                        <AlternatingRowStyle CssClass="alternatingItemStyle1" />
                                                    </asp:GridView>
                                                </td>
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
