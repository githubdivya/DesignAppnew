<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="Frmdownload.aspx.vb" Inherits="DesignApp.Frmdownload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section id="form">
        <!--Service page start-->
        <div class="container">
            <div class="row">
                <div class="col-md-12" style="text-align: center">
                    <br />
                    <h1>
                        <asp:Label runat="server" ID="download" Text="Downloads"></asp:Label>
                    </h1>
                </div>
            </div>


            <div class="panel panel-success">
                <div class="panel-heading">

                    <asp:Label runat="server" ID="Label1" Text="Downloads"></asp:Label>


                </div>
                <div class="panel-body">

                    <div class="row form-group has-error ">
                        <div class="col-xs-12">
                            <ul>
                                <li>
                                    <a class="control-label" href="../Download/GujaratiEnabledComputer.pdf" target="_blank">
                                        <h4>Make PC Guj. Enabled (Windows XP)</h4><br />
                                    </a>
                                </li>
                                <br />
                                <li>
                                    <a href="../Download/GujaratiIndicInput3_64-bit.zip" class="control-label" target="_blank">
                                        <h4>Guj. Indic Keyboard Win8-64 Bit</h4><br />
                                    </a>
                                </li>
                                <li>
                                    <a href="../Download/GujaratiIndicInput3_32-bit.zip" class="control-label" target="_blank">
                                        <h4>Guj. Indic Keyboard Win8-32 Bit</h4><br />
                                    </a>
                                </li>
                                <li>
                                    <a href="../Download/GujaratiIndicInput2_64-bit.zip" class="control-label" target="_blank">
                                        <h4>Guj. Indic Keyboard Win7-64 Bit </h4><br />
                                    </a>
                                </li>
                                <li>
                                    <a href="../Download/GujaratiIndicInput2_32-bit.zip" class="control-label" target="_blank">
                                        <h4>Guj. Indic Keyboard Win7-32 Bit</h4><br />
                                    </a>
                                </li>
                                <li>
                                    <a href="../Download/Gujarati_IME_ 5.0.1.12.zip" class="control-label" target="_blank">
                                        <h4>Guj. Indic Keyboard WinXP</h4>
                                    </a>
                                </li>

                            </ul>

                        </div>
                    </div>

                </div>
            </div>
    </section>


</asp:Content>
