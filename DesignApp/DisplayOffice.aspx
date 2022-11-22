<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="DisplayOffice.aspx.vb" Inherits="DesignApp.DisplayOffice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="margin-top: 62px;"">
       <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
      
        
          <div class="panel panel-default"  runat="server">
            <div class="panel-heading" >
               
                <h3 class="panel-title">
                    <asp:Label ID="Label3" runat="server" meta:resourcekey="lblPageHeader0Resource1" class="control-label">Office List</asp:Label>
                </h3>
            </div>


            <div class="panel-body">
                
                <div class="row" runat="server" style="margin-top: 30px;">
                    <div class="col-md-2 " >
                        <asp:Label ID="lblDistrict" CssClass="label" runat="server" Text="District Name" Font-Bold ="true" ForeColor="Black" ></asp:Label>
                    </div>
                    <div class="col-md-2 ">

                        <asp:DropDownList ID="ddlDistrict"  runat="server" CssClass="form-control" Width="242px" AutoPostBack="true" Font-Names="Shruti"  >

                        </asp:DropDownList>

                       


                    </div>
                </div>

                  <div class="row" runat="server" style="margin-top: 18px;">
                    <div class="col-md-2 ">
                        <asp:Label ID="lblCity" CssClass="label" runat="server" Text="City Name" Font-Bold ="true" ForeColor="Black" ></asp:Label>
                    </div>
                    <div class="col-md-2">

                        <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control" Width="242px" AutoPostBack="true" Font-Names="Shruti"></asp:DropDownList>


                    </div>
                </div>

                 <div class="row" runat="server" style="margin-top: 18px;">
                      <div class="col-md-2  ">
                          </div>
                 <div class="col-md-2  ">
                     <asp:Button ID="btnShowReport" runat="server" CssClass="btn btn-default reg" Text="Show" Visible="true" />
                  
                </div>
                </div>
                 <div class="row row_td " style="margin-top: 18px;">
                <div class="col-md-12">
                     <div class="table-responsive myAcctab">
                    <asp:GridView ID="gv_Office" CssClass="table table-striped" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Sr. No">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              <asp:BoundField DataField="DistrictName" HeaderText="District Name" />
                            <asp:BoundField DataField="CityName" HeaderText="City Name" />
                            <asp:BoundField DataField="CityNameG" HeaderText="CityName (Guj) " />

                            <asp:BoundField DataField="Office_Address" HeaderText="Office Address" />
                            <asp:BoundField DataField="Office_ContactNo" HeaderText="Office Contact No" />
                          


                        </Columns>
                    </asp:GridView>
                         </div>
                </div>
                      </div>

             

            </div>

        </div>

        </div>




</asp:Content>
