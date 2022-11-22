<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="SearchLicencePermit.aspx.vb" Inherits="DesignApp.SearchLicencePermit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td>
                <table border="0" cellpadding="1" cellspacing="1" width="100%">
                    <tr>
                        <td class="formtitle" style="height: 50px">Licence/Permit Data Management</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="lblRed" EnableViewState="False" meta:resourcekey="ValidationSummary1Resource1" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblexe" runat="server" CssClass="lblRed" meta:resourcekey="lblexeResource1"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                            <table border="0" cellpadding="1" cellspacing="1" style="width: 100%">

                                <tr>
                                    <td align="right" class="font3" valign="top">
                                        <asp:Label ID="Label2" runat="server" CssClass="control-label" Text="Department" meta:resourcekey="Label2Resource1"></asp:Label></td>
                                    <td style="width: 2%"></td>
                                    <td valign="top" style="height: 45px;">
                                        <asp:DropDownList ID="ddlDept" runat="server" CssClass="form-control" Width="250px" meta:resourcekey="ddlDeptResource1">
                                        </asp:DropDownList></td>
                                </tr>
                                 <tr>
                                    <td align="right" class="font3"></td>
                                    <td style="width: 2%"></td>
                                    <td>
                                        <asp:Button ID="btnShow" runat="server" CssClass="btn btn-info" Text="Show" meta:resourcekey="btnSaveResource1" />
                                         
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan ="3">
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  
                                            GridLines="Horizontal"   
                                            Width="100%" class="table table-bordered" style="margin-top: 10px;">
                                            <Columns>
                                                <asp:BoundField DataField="DepartmentID" HeaderText="DepartmentID"  
                                                    Visible="False" />
                                                <asp:BoundField DataField="LicenceDetail" HeaderText="Name & Detail Of Licence" ItemStyle-HorizontalAlign ="Center"   />
                                                <asp:BoundField DataField="DeptE" HeaderText="Department Name"   ItemStyle-HorizontalAlign ="Center"  />
                                                
                                                <asp:BoundField DataField="IssuingAuthoDesig" HeaderText="Issuing Authority Designation"   ItemStyle-HorizontalAlign ="Center" />
                                                <asp:BoundField DataField="RenewalAuthoDesig" HeaderText="Renewal Authority Designation"   ItemStyle-HorizontalAlign ="Center" />
                                                <asp:BoundField DataField="licenceTimelimit" HeaderText="Scheme Valid Effective Year"  ItemStyle-HorizontalAlign ="Center"  />
                                                  <asp:BoundField DataField="RenewallicenceTimeLimit" HeaderText="Scheme Valid Renewal Effective Year" ItemStyle-HorizontalAlign ="Center"   />
                                                <asp:BoundField DataField="DepartmentLicenceID" HeaderText="DepartmentID"  
                                                     >
                                                    <HeaderStyle CssClass="GridHideColumn" />
                                    <ItemStyle CssClass="GridHideColumn" />
                                    <FooterStyle CssClass="GridHideColumn" />
                                                    </asp:BoundField>
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
            </td>
        </tr>
    </table>
                </div>  
            </div>
        </div>
    </div>



</asp:Content>
