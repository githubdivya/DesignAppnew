<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="DepartmentSite.aspx.vb" Inherits="DesignApp.DepartmentSite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <table cellpadding ="2" cellspacing ="2" align="center" width ="100%" >
            <tr><td>
                <table cellpadding="0" cellspacing ="0" border ="0" width ="100%" align ="center" >
                <tr valign ="top"><td class="leftpanellnk" colspan="2" style="width: 712px"></td></tr>
                <tr valign="top"><td colspan="2" style="width: 712px">
                <tr><td  colspan="2" style="width: 712px"><div align="center"><img alt="" src="Images/DeptSite.png" id="IMG1" runat ="server" ></div></td></tr>
                <tr valign="top"><td colspan="2" background="Images/mukline.gif" style="width: 712px" ><img src="Images/mukline.gif" height ="3" width ="33" ></td></tr>
                <tr><td height="10"></table></td></tr>
        
            <tr>
                <td  valign="top"  >
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  Width ="100%" GridLines="Horizontal" ShowFooter="True" AllowPaging ="True" OnPageIndexChanging="GridView2_PageIndexChanging" PageSize ="25" meta:resourcekey="GridView2Resource1" class="table table-bordered"  >
                        <Columns>
                            <asp:BoundField DataField="DeptE" HeaderText="Department" meta:resourcekey="BoundFieldResource1" />
                            <%--<asp:BoundField DataField="Url" HeaderText="Site" meta:resourcekey="BoundFieldResource2" />--%>
                            <asp:TemplateField meta:resourcekey="TemplateFieldResource1">
                            <ItemTemplate> 
                                <a href="#" onclick='window.open(&#039;<%# Eval("Url") %>&#039;);return false;' target="_blank"><%# Eval("Url")%></a>
                            </ItemTemplate> 
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle CssClass="headerStyle2"/>
                        <RowStyle CssClass="itemStyle1" />
                        <HeaderStyle CssClass="headerStyle2"/>
                        <AlternatingRowStyle CssClass="alternatingItemStyle1" />
                        <pagerstyle cssClass="pagination-ys"></pagerstyle>
                    </asp:GridView>
                </td>
            </tr>
            
        </table> 
                 </div>  
            </div>
        </div>
    </div>


</asp:Content>
