<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="SearchAll.aspx.vb" Inherits="DesignApp.SearchAll" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h3 class="text-center">Service List</h3>


    <div>
        <asp:GridView CssClass="table table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="SchemeCode" Width="100%" GridLines="Horizontal" ShowFooter="True" meta:resourcekey="GridView2Resource1">
            <%-- AllowPaging ="True"  OnPageIndexChanging="GridView2_PageIndexChanging" PageSize ="25" --%>
            <Columns>

                <asp:TemplateField HeaderText="Sr.No">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblSchemeCode" runat="server" Text='<%# Eval("SchemeCode")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%-- <asp:BoundField DataField="SchemeCode" HeaderText="SchemeCode"   meta:resourcekey="BoundFieldResource1" />--%>
                <%--<asp:BoundField DataField="SchemeName" HeaderText="SchemeName" meta:resourcekey="BoundFieldResource4" />--%>
                <asp:TemplateField meta:resourcekey="TemplateFieldResource2" HeaderText="Scheme Name">
                    <ItemTemplate>
                        <asp:Label ID="lblscheme" runat="server" Text='<%# Eval("SchemeName")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="GistOfScheme" HeaderText="List Of Scheme" meta:resourcekey="BoundFieldResource3" />
                <asp:TemplateField meta:resourcekey="TemplateFieldResource3" HeaderText="Department">
                    <ItemTemplate>
                        <a href="#" onclick='window.open(&#039;<%# Eval("Url") %>&#039;);return false;' target="_blank"><%# Eval("DeptE")%></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ControlStyle-Width="60px">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnscheme" Text='<%# Eval("serviceurlname")%>' runat="server" OnClick="lnkbtn_Click"></asp:LinkButton>
                        <asp:Label ID="lblserviceurl" runat="server" Text='<%# Eval("ServiceDetailsUrl")%>' Visible="false"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField meta:resourcekey="TemplateFieldResource1">
                    <ItemTemplate>
                        <p>
                            <asp:LinkButton ID="lnkmore" runat="server" Text="More Details" CommandName="View" CommandArgument="<%# Container.DataItemIndex %>" meta:resourcekey="lnkmoreResource1"></asp:LinkButton>
                        </p>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle CssClass="headerStyle2" />
            <RowStyle CssClass="itemStyle1" />
            <HeaderStyle CssClass="headerStyle2" />
            <AlternatingRowStyle CssClass="alternatingItemStyle1" />
        </asp:GridView>
    </div>



</asp:Content>
