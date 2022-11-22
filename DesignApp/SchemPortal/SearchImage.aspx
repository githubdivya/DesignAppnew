<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="SearchImage.aspx.vb" Inherits="DesignApp.SearchImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">
        .numeric_button {
            background-color: #fff;
            border: 1px solid #ddd;
            float: left;
            line-height: 1.42857;
            margin-left: -1px;
            padding: 6px 12px;
            position: relative;
            text-decoration: none;
        }

        .current_page {
            background-color: #750b0b;
            color: white;
            border: 1px solid #ddd;
            float: left;
            line-height: 1.42857;
            margin-left: -1px;
            padding: 6px 12px;
            position: relative;
            text-decoration: none;
        }

        .next_button {
            background-color: #fff;
            border: 1px solid #ddd;
            float: left;
            line-height: 1.42857;
            margin-left: -1px;
            padding: 6px 12px;
            position: relative;
            text-decoration: none;
        }

        .last_button {
            background-color: #fff;
            border: 1px solid #ddd;
            float: left;
            line-height: 1.42857;
            margin-left: -1px;
            padding: 6px 12px;
            position: relative;
            text-decoration: none;
        }
    </style>
    <div class="mainPart">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h1 align="center">Sector</h1>
                    <table cellpadding="0" cellspacing="0" width="100%" align="center">
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblexe" ForeColor="Red" meta:resourcekey="lblexeResource1"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr><td></td></tr>

                        <tr>
                            <td align="right">&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="myTextBox" Width="200px" autocomplete="off" />
                               

                                <%--  <script type="text/javascript">
                // Work around browser behavior of "auto-submitting" simple forms
                var frm = document.getElementById("aspnetForm");
                if (frm) {
                    frm.onsubmit = function() { return false; };
                }
            </script>
            Prevent enter in textbox from causing the collapsible panel from operating --%>
                                <input type="submit" style="display: none;" /><asp:Button ID="btnSubmit"
                                    runat="server" Text="Search" CssClass="ButtonClass"
                                    meta:resourcekey="btnSubmitResource1" />&nbsp;&nbsp;&nbsp;&nbsp;
                                <%--<asp:LinkButton ID="lnkbtn" runat="server" OnClick="lnkbtn_Click" ></asp:LinkButton>--%>
                            </td>

                        </tr>
                        <tr>
                            <td width="100%" align="center">
                                <%--  <asp:ScriptManager ID="ScriptManager3" runat="server"></asp:ScriptManager>--%>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" class="images_search">
                                    <ContentTemplate>
                                        <asp:ListView ID="lvSchemeBySector" runat="server"
                                            GroupItemCount="5" DataKeyNames="SectorId"
                                            Style="margin-top: 95px">
                                            <EmptyItemTemplate>
                                                <%-- <td id="Td1" runat="server" />--%>
                                            </EmptyItemTemplate>
                                            <ItemTemplate>
                                                <%--<td id="Td2" runat="server" >--%>
                                                <%If intui = 1 Then%>


                                                <div class="col-md-6">

                                                    <%-- <a href='<%#"ResultData.aspx" %>'>--%>

                                                    <asp:LinkButton ID="lnkbtn" runat="server" OnClick="lnkbtn_Click">
                                                        <div class="newBox">
                                                            <span class="newIcon ">
                                                                <asp:ImageButton ID="ImageButton1"
                                                                    ToolTip='<%#"Click Here For The " & Eval("SectorE") & " Scheme Information." %>'
                                                                    runat="server" ImageUrl='<%#"~/images/Sector/" &  IIf((IsDBNull(Eval("SectorImageName"))), "no-image.png", Eval("SectorImageName"))%>'
                                                                    Width="70px" Height="70px" Style="margin-top: 10px" />
                                                            </span>
                                                            <span class="name">
                                                                <asp:Label ID="NameLabel" runat="server" Text='<%#Eval("Sector") %>' />
                                                                <asp:Label ID="lblid1" runat="server" Visible="false" Text='<%#Eval("SectorId") %>' />
                                                            </span>
                                                        </div>
                                                    </asp:LinkButton><%--</a>--%>
                                                </div>
                                                <%Else%><div class="col-md-6">

                                                    <%--<a href='<%#"ResultData.aspx" %>'>--%>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_click">
                                                        <div class="newBox">
                                                            <span class="newIcon">
                                                                <asp:ImageButton ID="ImageButton2"
                                                                    ToolTip='<%#"Click Here For The " & Eval("SectorE") & " Scheme Information." %>'
                                                                    runat="server" ImageUrl='<%#"~/images/Sector/" &  IIf((IsDBNull(Eval("SectorImageName"))), "no-image.png", Eval("SectorImageName"))%>'
                                                                    Width="70px" Height="70px" Style="margin-top: 10px" />
                                                            </span>
                                                            <span class="name">
                                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("SectorE") %>' />
                                                                <asp:Label ID="lblid2" runat="server" Visible="false" Text='<%#Eval("SectorId") %>' />
                                                            </span>
                                                        </div>
                                                    </asp:LinkButton><%--</a>--%>
                                                </div>
                                                <%End If%><%-- </td>--%>
                                            </ItemTemplate>
                                            <AlternatingItemTemplate>
                                                <%--<td id="Td3" runat="server" >--%>
                                                <%If intui = 1 Then%>
                                                <div class="col-md-6">
                                                    <%--<a href="<%#"ResultData.aspx?mode=sector&Id1="  & Eval("SectorId") %>">--%>
                                                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">
                                                        <div class="newBox">
                                                            <span class="newIcon">
                                                                <asp:ImageButton ID="ImageButton1"
                                                                    ToolTip='<%#"Click Here For The " & Eval("SectorE") & " Scheme Information." %>'
                                                                    runat="server" ImageUrl='<%#"~/images/Sector/" &  IIf((IsDBNull(Eval("SectorImageName"))), "no-image.png", Eval("SectorImageName"))%>'
                                                                    Width="70px" Height="70px" Style="margin-top: 10px" />
                                                            </span>
                                                            <span class="name">
                                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("Sector") %>' />
                                                                <asp:Label ID="lblid3" runat="server" Visible="false" Text='<%#Eval("SectorId") %>' />
                                                            </span>
                                                        </div>
                                                    </asp:LinkButton><%--</a>--%>
                                                </div>
                                                <%Else%><div class="col-md-6">
                                                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">
                                                        <%--<a href="<%#"ResultData.aspx?mode=sector&Id1="  & Eval("SectorId") %>">--%>
                                                        <div class="newBox">
                                                            <span class="newIcon">
                                                                <asp:ImageButton ID="ImageButton3"
                                                                    ToolTip='<%#"Click Here For The " & Eval("SectorE") & " Scheme Information." %>'
                                                                    runat="server" ImageUrl='<%#"~/images/Sector/" &  IIf((IsDBNull(Eval("SectorImageName"))), "no-image.png", Eval("SectorImageName"))%>'
                                                                    Width="70px" Height="70px" Style="margin-top: 10px" />
                                                            </span>
                                                            <span class="name">
                                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("SectorE") %>' />
                                                                <asp:Label ID="lblid4" runat="server" Visible="false" Text='<%#Eval("SectorId") %>' />
                                                            </span>
                                                        </div>
                                                    </asp:LinkButton><%--</a>--%>
                                                </div>
                                                <%End If%><%--</td>--%>
                                            </AlternatingItemTemplate>
                                            <EditItemTemplate>
                                                <%--<td id="Td3" runat="server" >--%>
                                                <%If intui = 1 Then%>
                                                <div class="col-md-6">
                                                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">
                                                        <%--<a href="<%#"ResultData.aspx?mode=sector&Id1="  & Eval("SectorId") %>">--%>
                                                        <div class="newBox">
                                                            <span class="newIcon icon1"></span>
                                                            <span class="name">
                                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("Sector") %>' />
                                                                <asp:Label ID="lblid5" runat="server" Visible="false" Text='<%#Eval("SectorId") %>' />
                                                            </span>
                                                        </div>
                                                    </asp:LinkButton><%--</a>--%>
                                                </div>
                                                <%Else%><div class="col-md-6">
                                                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">
                                                        <%--<a href="<%#"ResultData.aspx?mode=sector&Id1="  & Eval("SectorId") %>">--%>
                                                        <div class="newBox">
                                                            <span class="newIcon icon1"></span>
                                                            <span class="name">
                                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("SectorE") %>' />
                                                                <asp:Label ID="lblid6" runat="server" Visible="false" Text='<%#Eval("SectorId") %>' />
                                                            </span>
                                                        </div>
                                                    </asp:LinkButton><%-- </a>--%>
                                                </div>
                                                <%End If%><%--</td>--%>
                                            </EditItemTemplate>
                                            <LayoutTemplate>


                                                <table id="groupPlaceholderContainer" runat="server" border="1" cellpadding="20">
                                                    <tr id="groupPlaceholder" runat="server">
                                                    </tr>
                                                </table>

                                                <div class="col-md-12 text-center" style="margin-left: 37%;">
                                                    <asp:DataPager ID="DataPager1" runat="server" PageSize="8" class="pagination-ys">
                                                        <Fields>
                                                            <asp:NumericPagerField ButtonType="Link"
                                                                ButtonCount="5" NumericButtonCssClass="numeric_button" CurrentPageLabelCssClass="current_page" NextPreviousButtonCssClass="next_button" />
                                                            <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="false"
                                                                ShowNextPageButton="false" ShowPreviousPageButton="false" ButtonCssClass="last_button" />
                                                        </Fields>
                                                    </asp:DataPager>
                                                </div>


                                            </LayoutTemplate>
                                            <GroupTemplate>
                                                <tr id="itemPlaceholderContainer" runat="server">
                                                    <td id="itemPlaceholder" runat="server"></td>
                                                </tr>
                                            </GroupTemplate>
                                        </asp:ListView>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="lvSchemeBySector"
                                            EventName="PagePropertiesChanged" />
                                        <asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                            <td width="100%" align="center">&nbsp;</td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
