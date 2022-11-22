<%@ Page Title="" Language="vb" AutoEventWireup="false" CodeBehind="DepartmentWiseServiceCount.aspx.vb" Inherits="DesignApp.DepartmentWiseServiceCount" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <!-- Required favicon tags -->
    <link rel="apple-touch-icon" sizes="180x180" href="~/frmmain1/images/apple-touch-icon.png" />
    <link rel="icon" type="image/png" sizes="32x32" href="~/frmmain1/images/favicon-32x32.png" />
    <link rel="icon" type="image/png" sizes="16x16" href="~/frmmain1/images/favicon-16x16.png" />
    <link rel="manifest" href="~/frmmain1/images/site.webmanifest" />

    <!-- Icon Fonts -->
    <link rel="stylesheet" type="text/css" href="~/frmMain1/fonts/fontawesome-5-13-1/all.min.css" />
    <link rel="stylesheet" type="text/css" href="~/frmMain1/fonts/flaticon/flaticon.css" />

    <!-- CSS -->
    <link rel="stylesheet" type="text/css" href="~/frmMain1/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="~/frmMain1/css/owl.css" />
    <link rel="stylesheet" type="text/css" href="~/frmMain1/css/style.css" />

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Nunito:wght@300;400;600;700&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Zilla+Slab:wght@300;400;500;600;700&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Hind+Vadodara:wght@300;400;500;600;700&display=swap" rel="stylesheet" />

    <title>DigitalSevaSetu </title>

</head>
<body>
    <form runat="server">
        <section class="pb-2">
            <div class="container">
                <div id="btndiv" class="row pt-2">
                    <div class="col-6">
                        <input class="btn btn-primary" type="button" value="Print" id="print" onclick="prnt()" />
                        <input class="btn btn-white" id="back" type="button" value="Close" onclick="javascript: window.close()" />
                    </div>
                    <div class="col-6 text-right dg-top-nav">
                        <ul>
                            <li>
                                <asp:LinkButton ID="btnEnglish" runat="server" Text="English" CommandArgument="en-GB" OnClick="RequestLanguageChange_Click"></asp:LinkButton></li>
                            <li>
                                <asp:LinkButton ID="btnGujarati" runat="server" Text="Gujarati" CommandArgument="gu-IN" OnClick="RequestLanguageChange_Click"></asp:LinkButton></li>
                        </ul>
                    </div>
                </div>
                <div class="gvDepartmentWiseServiceCount">
                    <asp:GridView ID="gvDepartmentWiseServiceCount" runat="server" AutoGenerateColumns="false" CellPadding="10" CssClass="table table-striped">
                        <Columns>
                            <asp:TemplateField HeaderText="Sr No" HeaderStyle-Width="7%" HeaderStyle-HorizontalAlign="Left">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="DepartmentNameE" HeaderText="Department" />
                            <asp:BoundField DataField="ServiceNameE" HeaderText="Service" />
                        </Columns>
                    </asp:GridView>
                </div>

            </div>

        </section>
    </form>
    <script type="text/javascript">
        function prnt() {
            btndiv.style.visibility = "hidden";
            window.print();
        }
    </script>
</body>
</html>
