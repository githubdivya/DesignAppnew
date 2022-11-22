<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="SearchGROrders.aspx.vb" Inherits="DesignApp.SearchGROrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <table cellpadding="1" cellspacing="1" width="100%" align="center">
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" width="100%" align="center">
                                    <tr valign="top">
                                        <td colspan="2" height="10px">
                                            <tr>
                                                <td colspan="2">
                                                    <div align="center">
                                                        <img alt="" src="Images/SearchGrOrder.png"></div>
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
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="lblRed" EnableViewState="False" meta:resourcekey="ValidationSummary1Resource1" />
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <table cellpadding="2" cellspacing="2" width="100%" align="center">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblDept" runat="server" Text="Department" CssClass="control-label" meta:resourcekey="lblDeptResource1"></asp:Label></td>
                                        <td width="10"></td>
                                        <td style="height: 45px;">
                                            <asp:DropDownList runat="server" ID="ddldept" CssClass="form-control" Width="250px" meta:resourcekey="ddldeptResource1"></asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblGrno" runat="server" Text="GR No." CssClass="control-label" meta:resourcekey="lblGrnoResource1"></asp:Label></td>
                                        <td width="10"></td>
                                        <td style="height: 45px;">
                                            <asp:TextBox ID="txtGR" runat="server" CssClass="form-control" meta:resourcekey="txtGRResource1" Style="width: 250px;"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblDesc" runat="server" Text="GR Description" CssClass="control-label" meta:resourcekey="lblDescResource1"></asp:Label></td>
                                        <td width="10"></td>
                                        <td style="height: 45px;">
                                            <asp:TextBox runat="server" ID="txtdesc" CssClass="form-control" meta:resourcekey="txtdescResource1" Style="width: 250px;"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text="GR Issued Date" CssClass="control-label" meta:resourcekey="Label1Resource1"></asp:Label></td>
                                        <td width="10"></td>
                                        <td style="height: 45px;">
                                            <asp:TextBox runat="server" ID="txtFromDate" CssClass="textbox"></asp:TextBox>
                                            <a href="javascript:calendar_window=window.open('./Cal.aspx?formname=aspnetForm.ctl00_ContentPlaceHolder1_txtFromDate','calendar_window','width=174,height=180,left=750,top=350');calendar_window.focus()">
                                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/calender.bmp" meta:resourcekey="Image1Resource1" /></a>
                                            <asp:Label runat="server" ID="lblTo" Text="To" CssClass="labels" meta:resourcekey="lblToResource1"></asp:Label><img src="Images/spacer.gif" alt="" width="10px" />
                                            <asp:TextBox runat="server" ID="txtToDate" CssClass="textbox"></asp:TextBox>&nbsp;
                                        <a href="javascript:calendar_window=window.open('./Cal.aspx?formname=aspnetForm.ctl00_ContentPlaceHolder1_txtToDate','calendar_window','width=174,height=180,left=750,top=350');calendar_window.focus()">
                                            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/calender.bmp" meta:resourcekey="Image2Resource1" /></a></td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:Button runat="server" ID="btnsearch" Text="Search" CssClass="btn btn-info" meta:resourcekey="btnsearchResource1" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="lblmsg" runat="server" ForeColor="Red" meta:resourcekey="lblmsgResource1"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:GridView ID="GridView1" runat="server" Width="100%" ShowFooter="True" meta:resourcekey="GridView1Resource1" GridLines="Horizontal" DataKeyNames="GROrderId" AutoGenerateColumns="False" class="table table-bordered" Style="margin-top: 10px;">
                                                <Columns>
                                                    <asp:TemplateField meta:resourcekey="TemplateFieldResource1">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblGROrderId" runat="server" Text='<%# Eval("GROrderId")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <%--<asp:BoundField DataField="GROrderId" HeaderText="GROrderId" Visible="False" meta:resourcekey="BoundFieldResource1" ></asp:BoundField>--%>
                                                    <asp:BoundField DataField="Department" HeaderText="Department" meta:resourcekey="BoundFieldResource2"></asp:BoundField>
                                                    <%--<asp:BoundField DataField="BranchName" HeaderText="BranchName" meta:resourcekey="BoundFieldResource3"></asp:BoundField>--%>
                                                    <asp:BoundField DataField="GROrderName" HeaderText="GROrder Name" meta:resourcekey="BoundFieldResource4" HeaderStyle-Width="25%"/>
                                                    <asp:BoundField DataField="GROrderNumber" HeaderText="GROrder Number" meta:resourcekey="BoundFieldResource5" HeaderStyle-Width="20%" />
                                                    <asp:BoundField DataField="GRDesc" HeaderText="GR Description" meta:resourcekey="BoundFieldResource6" HeaderStyle-Width="25%"/>
                                                    <%--<asp:BoundField DataField="GrRemarks" HeaderText="Remarks" meta:resourcekey="BoundFieldResource7" />--%>
                                                    <asp:TemplateField HeaderText="Gujarati">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="downloadgrguj" Text='<%# Eval("downloadtextguj")%>' runat="server" OnClick="downloadgrguj_Click"   ></asp:LinkButton>

                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="English">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="downloadgreng" Text='<%# Eval("downloadtexteng")%>' runat="server" OnClick="downloadgreng_Click" ></asp:LinkButton>

                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <%--<asp:ButtonField ButtonType="Link" Text='<% Eval("downloadtextguj") %>' CommandName="DownloadGuj" HeaderText="Gujarati"></asp:ButtonField>
                                                    <asp:ButtonField ButtonType="Link" Text='<% Eval("downloadtexteng") %>' CommandName="DownloadEng" HeaderText="English"></asp:ButtonField>--%>
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
