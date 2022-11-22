<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Schem.Master" CodeBehind="ServiceGroup.aspx.vb" Inherits="DesignApp.ServiceGroup" 
    MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="services-page-section">
        <div class="container">

            <div class="services-tabs">
                <asp:DataList ID="dltabs" runat="server" RepeatDirection="Horizontal" RepeatColumns="3" OnItemCommand="dltabs_ItemCommand">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"Id")%>'>
                                <%#Eval("TabsName")%> 
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:DataList>
            </div>

            <div class="services-tabs-content">
                <div class="row">
                    <asp:MultiView runat="server" ID="multiview">

                        <asp:View runat="server" ID="applicant"></asp:View>

                        <asp:View runat="server" ID="lifeevent">
                            <div class="lifeevent-content">
                                <asp:DataList ID="dlLifeEvents" runat="server" RepeatDirection="Horizontal" OnItemCommand="dlLifeEvents_ItemCommand">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"EventId")%>'>
                                              <h4><%#Eval("EventNameE")%></h4> <img alt="img" src="../SchemPortal/Image/<%#Eval("EventImage")%>" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:DataList>
                            </div>
                        </asp:View>

                        <asp:View runat="server" ID="department">
                            <div class="department-content">
                                <asp:DataList ID="dldepartment" runat="server" RepeatDirection="Horizontal" OnItemCommand="dldepartment_ItemCommand">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"DeptId")%>'>
                                         <i class="fas fa-angle-double-right"></i><%#Eval("deptE")%>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:DataList>
                            </div>
                        </asp:View>

                        <asp:View runat="server" ID="sector">
                            <div class="sector-content">
                                <asp:DataList ID="dlsector" runat="server" RepeatDirection="Horizontal" OnItemCommand="dlsector_ItemCommand">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"SectorId")%>'>
                                         <h4><%#Eval("SectorE")%></h4> <img alt="img" src="../SchemPortal/Image/<%#Eval("SectorImageName")%>" /></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:DataList>
                            </div>
                        </asp:View>
                            <%-- <asp:View runat="server" ID="sector">
                            <div class="sector-content">
                                <asp:DataList ID="dlsector" runat="server" RepeatDirection="Horizontal" OnItemCommand="dlsector_ItemCommand">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hfDeptID" runat="server" Value='<%# Eval("DeptID")%>' />
                         
                                        <asp:LinkButton ID="LinkButton2" runat="server"
                                             CommandName="redirect" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Schemecode")%>'>
                                         <h4><%#Eval("ServiceNameE")%></h4> <img alt="img" src="../frmMain1/images/flaticons/<%#Eval("ServiceImage")%>" />                                              
                                            </asp:LinkButton>
                                
                                    </ItemTemplate>
                                </asp:DataList>
                            </div>
                        </asp:View>--%>


                    </asp:MultiView>
                    <asp:HiddenField ID="hfDepartmentId" runat="server" />
                    <asp:HiddenField ID="hfSectorId" runat="server" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>
