<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MoreDetails.aspx.vb" Inherits="DesignApp.MoreDetails" %>

<!doctype html>
<html lang="en">
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="apple-touch-icon" sizes="180x180" href='<%=ResolveUrl("~/frmMain1/images/apple-touch-icon.png")%>' />
    <link rel="icon" type="image/png" sizes="32x32" href='<%=ResolveUrl("~/frmmain1/images/favicon-32x32.png")%>' />
    <link rel="icon" type="image/png" sizes="16x16" href='<%=ResolveUrl("~/frmmain1/images/favicon-16x16.png")%>' />
    <link rel="stylesheet" type="text/css" href='<%=ResolveUrl("~/frmMain1/css/print.css")%>'>
    <link href="https://fonts.googleapis.com/css2?family=Nunito:wght@300;400;600;700&display=swap" rel="stylesheet">

    <title>More Details</title>
</head>

<body>

    <form id="form1" runat="server">
        <div>
            <script type="text/javascript">
                function prnt() {
                    printdiv.style.visibility = "hidden";
                    window.print();
                }
            </script>

            <!-- Page Header -->
            <table class="page-header">
                <tr>
                    <td id="printdiv">
                        <input class="btn-style blue-btn" type="button" value="Print" id="print" onclick="prnt()" />
                        <input class="btn-style" id="back" type="button" value="Close" onclick="javascript: window.close()" />
                    </td>
                    <td>
                        <div class="right-col">
                            <div class="language-area">
                                <asp:LinkButton ID="LinkButton4" runat="server" Text="English" CommandArgument="en" OnClick="RequestLanguageChange_Click" CssClass="btn-style"></asp:LinkButton>
                                <asp:LinkButton ID="btnGujarati" runat="server" Text="Gujarati" CommandArgument="gu" OnClick="RequestLanguageChange_Click" CssClass="btn-style"></asp:LinkButton>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>

            <!-- Page Body --->
            <table class="page-body">

                <tr>
                    <td colspan="2">
                        <h2 class="page-title">Service Details</h2>
                    </td>
                </tr>

                <tr class="page-content">
                    <td>
                        <% If Not dt Is Nothing Then%>
                        <%If dt.Rows.Count > 0 Then%>
                        <table>
                            <tr>
                                <td colspan="2" class="table-title">
                                    <asp:Label runat="server" ID="lblAbtSc" meta:resourcekey="lblAbtScResource1" Text="About Scheme"></asp:Label></td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label runat="server" Text="SchemeName" ID="lblScName" meta:resourcekey="lblScNameResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("SchemeName").ToString() %></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblgistofscheme" Text="Gist Of Scheme" meta:resourcekey="lblgistofschemeResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("GistOfScheme").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblbenifits" Text="Benefits" meta:resourcekey="lblbenifitsResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("Benifits").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblbenefittype" Text="Benefit Type" meta:resourcekey="lblbenefittypeResource1"></asp:Label></td>

                                <td>
                                    <% If Not dt5 Is Nothing Then%>
                                    <%For l As Integer = 0 To dt5.Rows.Count - 1%>
                                    <%If dt5.Rows(l).Item("BenefitType").ToString <> "" Then%>
                                    <table>
                                        <tr>
                                            <td><%=dt5.Rows(l).Item("BenefitType").ToString()%></td>
                                        </tr>
                                    </table>
                                    <%End If%>
                                    <%Next l%>
                                    <%End If%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblsctargetarea" Text="Scheme Target" meta:resourcekey="lblsctargetareaResource1"></asp:Label></td>

                                <%If dt.Rows(0).Item("SchemeTargetArea").ToString = "FA" Then%>
                                <td>Financial Help(આર્થીક સહાય)</td>
                                <%ElseIf dt.Rows(0).Item("SchemeTargetArea").ToString = "PA" Then%>
                                <td>Physical Help(ભૌતીક સહાય)</td>
                                <%ElseIf dt.Rows(0).Item("SchemeTargetArea").ToString = "SF" Then%>
                                <td>Services(Free)(સેવાઓ(વિનામુલ્ય))</td>
                                <%ElseIf dt.Rows(0).Item("SchemeTargetArea").ToString = "SP" Then%>
                                <td>Services(Paid)(સેવાઓ(મુલ્ય))</td>
                                <%End If%>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" Text="Department" ID="lbldept" meta:resourcekey="lbldeptResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("DeptName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" Text="Sector" ID="lblSector" meta:resourcekey="lblSectorResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("SectorName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" Text="Sub Sector" ID="lblsubsect" meta:resourcekey="lblsubsectResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("SubSector").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" Text="Scheme Owned By" ID="lblcat" meta:resourcekey="lblcatResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("CatName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" Text="Scheme Type" ID="Label1" meta:resourcekey="Label1Resource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("SchemeType").ToString()%></td>
                            </tr>
                            <tr>
                                <td colspan="2" class="table-space"></td>
                            </tr>
                            <tr>
                                <td colspan="2" class="table-title">
                                    <asp:Label runat="server" ID="lblscappcri" meta:resourcekey="lblscappcriResource1" Text="Scheme Applicable Criteria"></asp:Label></td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblCaste" Text="Category" meta:resourcekey="lblCasteResource1"></asp:Label></td>

                                <td><%=dt.Rows(0).Item("CasteName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblgender" Text="Gender Related Eligibility" meta:resourcekey="lblgenderResource1"></asp:Label></td>

                                <%If dt.Rows(0).Item("Gender").ToString = "M0" Then%>
                                <td>પુરુષો</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "F0" Then%>
                                <td>સ્ત્રીઓ</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "CM" Then%>
                                <td>છોકરાઓ</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "CF" Then%>
                                <td>છોકરીઓ</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "00" Then%>
                                <td>કોઈપણ</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "MW" Then%>
                                <td>વિધૂર</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "FW" Then%>
                                <td>વિધવાઓ</td>
                                <%ElseIf dt.Rows(0).Item("Gender").ToString = "FO" Then%>
                                <td>ત્યકતાઓ</td>
                                <%End If%>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblprofession" Text="Profession" meta:resourcekey="lblprofessionResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("OccName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lbleducation" Text="Education" meta:resourcekey="lbleducationResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("EduName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblsocecopara" Text="Social and Economic Standard" meta:resourcekey="lblsocecoparaResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("SocioEcoName").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblIndinclimit" Text="Individual Income Limit" meta:resourcekey="lblIndinclimitResource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("IndIncLimit").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label3" Text="Family Income Limit" meta:resourcekey="Label3Resource1"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("FamIncLimit").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblscappto" Text="Scheme Applicable To" meta:resourcekey="lblscapptoResource1"></asp:Label></td>
                                <td>
                                    <% If Not dt4 Is Nothing Then%>
                                    <%For t As Integer = 0 To dt4.Rows.Count - 1%>
                                    <%If dt4.Rows(t).Item("SchemeAppTo").ToString <> "" Then%>
                                    <table>
                                        <tr>
                                            <td><%=dt4.Rows(t).Item("SchemeAppTo").ToString()%></td>
                                        </tr>
                                    </table>
                                    <%End If%>
                                    <%Next t%>
                                    <%End If%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblscapparea" Text="Scheme Applicable Area" meta:resourcekey="lblscappareaResource1"></asp:Label></td>

                                <td>
                                    <% If Not dt1 Is Nothing Then%>
                                    <%Dim i As Integer%>
                                    <%For i = 0 To dt1.Rows.Count - 1%>
                                    <%If dt1.Rows(i).Item("Area").ToString() <> "" Then%>
                                    <table>
                                        <tr>
                                            <td><%=dt1.Rows(i).Item("Area").ToString()%></td>
                                        </tr>
                                    </table>
                                    <%End If%>
                                    <%Next i%>
                                    <%End If%>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblAttachment" Text="Required Attachments" meta:resourcekey="lblAttachmentResource1"></asp:Label></td>

                                <td>
                                    <% If Not dt2 Is Nothing Then%>
                                    <%Dim p As Integer%>
                                    <%For p = 0 To dt2.Rows.Count - 1%>
                                    <%If dt2.Rows(p).Item("AttachDetail").ToString() <> "" Then%>
                                    <table>
                                        <tr>
                                            <td><%=dt2.Rows(p).Item("AttachDetail").ToString()%></td>
                                        </tr>
                                    </table>
                                    <%End If%>
                                    <%Next p%>
                                    <%End If%>
                                </td>
                            </tr>
                            <tr>
                                <td class="table-space"></td>
                            </tr>
                            <tr>
                                <td colspan="3" class="table-title">
                                    <asp:Label runat="server" ID="lblAppFormDetail" meta:resourcekey="lblAppFormDetailResource1" Text="Application Form Details"></asp:Label></td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblAppFormtype" Text="Application Form Type" meta:resourcekey="lblAppFormtypeResource1"></asp:Label></td>

                                <% If dt.Rows(0).Item("AppFormType").ToString() = "PP" Then%>
                                <td>પ્લેન પેપર</td>
                                <%ElseIf dt.Rows(0).Item("AppFormType").ToString = "FF" Then%>
                                <td>નમુના પ્રમાણેનુ-વિના મુલ્ય</td>
                                <%ElseIf dt.Rows(0).Item("AppFormType").ToString = "FFP" Then%>
                                <td>નમુના પ્રમાણેનુ-મુલ્ય વાળુ</td>
                                <%End If%>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblAppFormcost" Text="Application Form Cost" meta:resourcekey="lblAppFormcostResource1"></asp:Label></td>

                                <td><%=dt.Rows(0).Item("AppFormCost").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblScAppFormSubTo" Text="Application Form Submitted To" meta:resourcekey="lblScAppFormSubToResource1"></asp:Label></td>

                                <td><%=dt.Rows(0).Item("AppFormSubTo").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label4" Text="Application Form Available From" meta:resourcekey="Label4Resource1"></asp:Label></td>

                                <td><%=dt.Rows(0).Item("AppFormAvaiFrom").ToString()%></td>
                            </tr>

                            <%If dt.Rows(0).Item("Form1").ToString() <> "" Then%>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label5" Text="Download (Gujarati)" meta:resourcekey="Label5Resource1"></asp:Label></td>

                                <td>
                                    <asp:LinkButton ID="downloadformguj" runat="server">Download Form (Gujarati) </asp:LinkButton></td>
                            </tr>
                            <%End If%>
                            <%If dt.Rows(0).Item("Form_eng").ToString() <> "" Then%>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label6" Text="Download (English)" meta:resourcekey="Label6Resource1"></asp:Label></td>

                                <td>
                                    <asp:LinkButton ID="downloadformeng" runat="server">Download Form (English)</asp:LinkButton></td>
                            </tr>
                            <%End If%>
                            <%If dt.Rows(0).Item("Service_Details").ToString() <> "" Then%>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label9" Text="Instruction" meta:resourcekey="Label9Resource1"></asp:Label></td>

                                <td>
                                    <asp:LinkButton ID="downloadforminst" runat="server">Download</asp:LinkButton></td>
                            </tr>
                            <%End If%>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label10" Text="Service Details Site"></asp:Label></td>

                                <td><a href='<%=dt.Rows(0).Item("ServiceDetailsUrl").ToString()%>' target="_blank"><%=dt.Rows(0).Item("ServiceDetailsUrl").ToString()%></a></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label8" Text="Department Link" meta:resourcekey="Label8Resource1"></asp:Label></td>

                                <td><a href='<%=dt.Rows(0).Item("DeptUrl").ToString()%>' target="_blank"><%=dt.Rows(0).Item("DeptUrl").ToString()%></a></td>
                            </tr>
                            <tr>
                                <td colspan="2" class="table-space"></td>
                            </tr>
                            <tr id="GRdetails" runat="server">
                                <td colspan="2" class="table-title">
                                    <asp:Label runat="server" ID="Label11" Text="Reference Documents"></asp:Label></td>
                            </tr>


                            <asp:Label ID="lblexe" runat="server" ForeColor="Red" CssClass="lblRed"></asp:Label>

                            <tr>
                                <td colspan="2">
                                    <asp:GridView ID="Gv_Docs" runat="server" AllowPaging="false" AutoGenerateColumns="False">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Select Item" Visible="false">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblid" runat="server" Text='<%# Eval("GROrderId")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="LookDescEn" HeaderText=""></asp:BoundField>
                                            <asp:BoundField DataField="GROrderName" HeaderText="GROrder Name"></asp:BoundField>
                                            <asp:BoundField DataField="GROrderNumber" HeaderText="GROrder Number"></asp:BoundField>
                                            <asp:TemplateField HeaderText="Gujarati">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="DownloadGuj"><%# Eval("gujtext")%></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="English">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="DownloadEng"><%# Eval("engtext")%></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <%--<asp:ButtonField ButtonType="Link" Text='<%# Eval("gujtext")%>' CommandName="DownloadGuj" HeaderText="Gujarati"></asp:ButtonField>
                                            <asp:ButtonField ButtonType="Link" Text='<%# Eval("engtext")%>' CommandName="DownloadEng" HeaderText="English"></asp:ButtonField>--%>
                                        </Columns>
                                        <EmptyDataTemplate>
                                            ::No Documents::
                                        </EmptyDataTemplate>
                                    </asp:GridView>
                                </td>
                            </tr>

                        </table>


                        <%-----------------------------------Start RCPS ACT -----------------------------------------%>



                       <%-- <table id="RCPS" runat="server">
                            <tr>
                                <td colspan="5" class="table-space"></td>
                            </tr>
                            <tr id="RCPSHead" runat="server">
                                <td colspan="5" class="table-title">
                                    <asp:Label runat="server" ID="lblRCPSACT" Text="RCPS ACT Details"></asp:Label></td>
                            </tr>


                            <tr>
                                <td colspan="1"></td>
                                <td>
                                    <asp:Label runat="server" ID="Label92" CssClass="labels" Text="Days"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="Label93" CssClass="labels" Text="In Gujarati"></asp:Label></td>
                                <td>
                                    <asp:Label runat="server" ID="Label94" CssClass="labels" Text="In English"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label95" CssClass="labels" Text="Service Delivery days"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("Sddays").ToString()%> Days</td>
                                <td><%=dt.Rows(0).Item("Sdguj").ToString()%></td>
                                <td><%=dt.Rows(0).Item("Sdeng").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label96" CssClass="labels" Text="GRA(Grievance Redressal Authority)"></asp:Label></td>

                                <td><%=dt.Rows(0).Item("GRAdays").ToString()%> Days</td>
                                <td><%=dt.Rows(0).Item("GRAguj").ToString()%></td>
                                <td><%=dt.Rows(0).Item("GRAeng").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label101" CssClass="labels" Text="1st Appellate Authority"></asp:Label></td>

                                <td><%=dt.Rows(0).Item("App1days").ToString()%> Days</td>
                                <td><%=dt.Rows(0).Item("App1guj").ToString()%></td>
                                <td><%=dt.Rows(0).Item("App1eng").ToString()%></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label105" CssClass="labels" Text="2st Appellate Authority"></asp:Label></td>
                                <td><%=dt.Rows(0).Item("App2days").ToString()%> Days</td>
                                <td><%=dt.Rows(0).Item("App2guj").ToString()%></td>
                                <td><%=dt.Rows(0).Item("App2eng").ToString()%></td>
                            </tr>
                            <tr>
                                <td></td>

                                <td></td>
                                <td>
                                    <asp:LinkButton ID="RCPSguj" runat="server"><%=dt.Rows(0).Item("rcpsactgujtext").ToString()%></asp:LinkButton></td>
                                <td>
                                    <asp:LinkButton ID="RCPSeng" runat="server"><%=dt.Rows(0).Item("rcpsactengtext").ToString()%></asp:LinkButton></td>
                            </tr>
                            <tr>
                                <td colspan="4" class="table-space"></td>
                            </tr>
                        </table>--%>

                        <%-----------------------------------End RCPS ACT -----------------------------------------%>

                        <table>
                            <%--<a href="#" onclick="window.open('ViewForm.aspx?FormId1=<%=dt.Rows(0).Item("FormId").ToString()%>&Type=3','','menubar=no,scrollbar=yes');return false;" class ="ButtonLink" style="text-decoration: none; ">Service Details</a>--%>
                            <%If Not dt3 Is Nothing Then%>

                            <tr>
                                <td colspan="2" class="table-title">
                                    <asp:Label runat="server" ID="Label2" meta:resourcekey="Label2Resource1">Scheme Contact Details</asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblDist" runat="server" Text="District" meta:resourcekey="lblDistResource1"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="ddlDistrict" runat="server" AutoPostBack="True" CssClass="textbox" meta:resourcekey="ddlDistrictResource1"></asp:DropDownList></td>
                            </tr>
                            <%If Not temp Is Nothing Then%>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Label7" Text="Scheme Contact Details" meta:resourcekey="Label7Resource1"></asp:Label></td>
                                <td></td>
                                <%End If%>
                            </tr>
                            <%End If%>
                            <tr>
                                <td colspan="2" class="table-space"></td>
                            </tr>
                        </table>
                        <%End If%>
                        <%End If%>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" meta:resourcekey="GridView1Resource1">
                        </asp:GridView>
                    </td>
                </tr>
            </table>

            <!--- Page Footer --->
            <table class="page-footer">
                <tr>
                    <td>
                        <div id="Div1">
                            <% If Not dt Is Nothing Then%>
                            <%If dt.Rows.Count > 0 Then%>
                            <%If dt.Rows(0).Item("FormId").ToString() <> "" Then%>
                            <%If dt.Rows(0).Item("AppUrl").ToString() <> "" Then%>
                            <a href='<%dt.Rows(0).Item("AppUrl").ToString()%>' target="_blank" class="btn-style float-right">Apply Online</a>
                            <%End If%>
                            <%End If%>
                            <%End If%>
                            <%End If%>
                            <input class="btn-style blue-btn" type="button" value="Print" id="Button1" onclick="prnt()" />
                            <input class="btn-style" id="Button2" type="button" value="Close" onclick="javascript: window.close()" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
