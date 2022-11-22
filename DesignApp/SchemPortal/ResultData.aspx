<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Schem.Master" CodeBehind="ResultData.aspx.vb" Inherits="DesignApp.ResultData" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="result-data-section">
        <div class="container">

            <table class="select-department">
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblDept1" Text="Department" meta:resourcekey="lblDept1Resource1" CssClass="control-label weight-700"></asp:Label></td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddldept" CssClass="form-control" meta:resourcekey="ddldeptResource1"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblSec" Text="Sector" meta:resourcekey="lblSecResource1" CssClass="control-label weight-700"></asp:Label></td>

                    <td>
                        <asp:DropDownList runat="server" ID="ddlSector" CssClass="form-control" meta:resourcekey="ddlSectorResource1"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblGender" Text="Gender" meta:resourcekey="lblGenderResource1" CssClass="control-label weight-700"></asp:Label></td>

                    <td>
                        <asp:DropDownList runat="server" ID="ddlGender" CssClass="form-control"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblCaste" Text="Category" meta:resourcekey="lblCasteResource1" CssClass="control-label weight-700"></asp:Label></td>

                    <td>
                        <asp:DropDownList runat="server" ID="ddlCaste" CssClass="form-control" meta:resourcekey="ddlCasteResource1"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblScAppTo" Text="Scheme Applicable In Areas" meta:resourcekey="lblScAppToResource1" CssClass="control-label weight-700"></asp:Label></td>

                    <td>
                        <asp:DropDownList runat="server" ID="ddlScApp" CssClass="form-control" meta:resourcekey="ddlScAppResource1"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
                <tr runat="server" id="LifeEvent">
                    <td>
                        <asp:Label runat="server" ID="lblEvent" Text="Event" CssClass="control-label weight-700"></asp:Label></td>

                    <td>
                        <asp:DropDownList runat="server" ID="ddlEvent" CssClass="form-control"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>

                <tr>
                    <td></td>

                    <td>
                        <asp:Button runat="server" ID="btnreset" Text="Reset" CssClass="btn btn-secondary" />
                        <asp:Button runat="server" ID="btnBack" Text="Back" CssClass="btn btn-secondary" meta:resourcekey="Button2Resource1" />
                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" CssClass="btn btn-primary float-right" meta:resourcekey="btnSubmitResource1" />
                    </td>


                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
                <tr>
                    <td colspan="2" class="height-10"></td>
                </tr>
            </table>

            <!---- Message Lable ---->
            <div>
                <asp:Label ID="Label1" runat="server" CssClass="lblRed" ForeColor="DarkRed" Font-Bold="true" meta:resourcekey="Label1Resource1"></asp:Label>
            </div>

            <table class="scheme-details">
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="SchemeCode" GridLines="Horizontal" ShowFooter="True" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" OnRowCommand="GridView2_RowCommand" PageSize="25" meta:resourcekey="GridView2Resource1" class="table table-bordered">
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSchemeCode" runat="server" Text='<%# Eval("SchemeCode") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="SchemeName" HeaderText="SchemeName" meta:resourcekey="BoundFieldResource2" />
                                <asp:BoundField DataField="GistOfScheme" HeaderText="Gist Of Scheme" meta:resourcekey="BoundFieldResource3" />
                                <asp:BoundField DataField="AreaName" HeaderText="Applicable In Areas" meta:resourcekey="BoundFieldResource4" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkmore" runat="server" CommandName="View" CommandArgument="<%# Container.DataItemIndex %>" meta:resourcekey="lnkmoreResource1">More Details <i class="fas fa-arrow-right"></i></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle CssClass="headerStyle2" />
                            <RowStyle CssClass="itemStyle1" />
                            <HeaderStyle CssClass="headerStyle2" />
                            <AlternatingRowStyle CssClass="alternatingItemStyle1" />
                            <PagerStyle CssClass="pagination-ys"></PagerStyle>
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </section>


</asp:Content>
