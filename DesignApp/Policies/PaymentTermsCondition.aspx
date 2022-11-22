<%@ Page Title="" Language="vb" AutoEventWireup="false" CodeBehind="PaymentTermsCondition.aspx.vb" Inherits="DesignApp.PaymentTermsCondition" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">

    <section id="service-page">

        <div class="onlineService">
            <div class="container">
                <div class="row">

                    <div class="serviceList">
                        <div class="serviceName" align="center">
                            <h1 >
                <asp:Label runat="server" ID="lbltermsof" Text="Common Services Portal: Online Transactions" meta:resourcekey="lblTermsResource1"></asp:Label></h1>
           
           </div>
                         <div class="serviceName">
                            <h4>
                <b><asp:Label runat="server" ID="Label1" Text="Payment Options:" meta:resourcekey="lblPaymntResource1"></asp:Label></h4></b>
           
           </div>
                        <div class="serviceDetail">
                            <p><b><asp:Localize ID="localize1"   runat="server" meta:resourcekey="localize1Resource1" Text="Online Card Payments:"></asp:Localize></b> <asp:Localize ID="localize3"   runat="server" meta:resourcekey="localize3Resource1" Text="Visa and MasterCard payments are processed through a secure online payment gateway system. You need not worry about your card information falling into the wrong hands because your 
                                bank will authorize the card transaction directly without any information passing through us. In approximately 25-30 seconds (depending on your internet connection) your bank will issue, 
                                using the online payment gateway, an authorization code and confirmation of completion of transaction."></asp:Localize>  </p>
                            <br /><asp:Localize ID="localize2"   runat="server" meta:resourcekey="localize2Resource1" Text="Department of Science & Technology’s domain 'www.digitalgujarat.gov.in’ uses the latest technology and other sophisticated methods to protect your credit card information. You can pay your Application fees using SSL encryption (the internet standard for secure transactions). In fact, transacting online with a credit card at the Portal is even safer than using a credit card elsewhere because we do not retain your credit card information. You can be assured that Department of Science & Technology, Government of Gujarat offers you the highest standards of security currently available on the internet so as to ensure that your payment is private, safe and secure.
                                "></asp:Localize>

                            <p></p>
                             <br /><b><asp:Localize ID="localize7"   runat="server" meta:resourcekey="localize1Resource1" Text="Internet Banking:"></asp:Localize></b><asp:Localize ID="localize6"   runat="server" meta:resourcekey="localize2Resource1" Text="If you have an account in any bank within India, you can pay your Application Fees through your bank's net banking options and the amount will be automatically debited from your account. Digital Gujarat Portal processes the payments through an online gateway system which enables safe and secure transactions.
                                "></asp:Localize>

                            
                       </div>
                    </div>
                     <div class="serviceList">
                        <div class="serviceName"  align="center">
                            <h1>
                <asp:Label runat="server" ID="Label2" Text="Terms & Conditions" meta:resourcekey="lblTermsResource1"></asp:Label></h1>
           
           </div>
                         <div class="serviceName">
                            <h4>
                <b><asp:Label runat="server" ID="Label3" Text="Transaction Confirmation:" meta:resourcekey="lblPaymntResource1"></asp:Label></h4></b>
           
           </div>
                        <div class="serviceDetail">
                            <p> <asp:Localize ID="localize5"   runat="server" meta:resourcekey="localize3Resource1" Text="The Payment gateway will generate a unique Transaction ID against each transaction which will be displayed to the Citizen. This Transaction ID can be used for any queries related to the transaction. All transactions where Payment Gateway does not receive a response from bank during the transaction session will be auto refunded within 7 working days."></asp:Localize>  </p>
                            <p> The payments for which responce is not received from bank, will be automatically updated in next 10 minutes. After making any payment kindly wait for 10 minutes for another transaction.</p>
                            
                       </div>

                         <div class="serviceName">
                            <h4>
                <b><asp:Label runat="server" ID="Label4" Text="Refund and Cancellation:" meta:resourcekey="lblPaymntResource1"></asp:Label></h4></b>
           
           </div>

                         <div class="serviceDetail">
                            <p> <ul>
                                <li><asp:Localize ID="localize4"   runat="server" meta:resourcekey="localize3Resource1" Text="The application fee is non-refundable.The fees once paid will not be refunded for applications which are successfully submitted. Cancellation of applications shall not be entertained."></asp:Localize></li>
                                <li><asp:Localize ID="localize41"   runat="server" meta:resourcekey="localize3Resource1" Text="Any excess payment received due to technical or other reasons will be refunded back with-in 7working days."></asp:Localize></li>
                                <li><asp:Localize ID="localize42"   runat="server" meta:resourcekey="localize3Resource1" Text="The mode of refund will be electronic and the amount (excluding the processing fees) will be duly returned after reconciliation of accounts to the same Card or Bank Account through which the transaction was done."></asp:Localize></li>

                                </ul>  </p>
                            
                       </div>
                    </div>
                </div>
            </div>
            <div class="page text-center">
              
            </div>
        </div>

    </section>

    
        <script src="../../js/jquery.min.js"></script>
        <script src="../js/bootstrap.min.js"></script>
        <script src="../js/general.js"></script>
        <script src="../js/function.js"></script>

         <link href="../../css/datepicker_ByDesigner.css" rel="stylesheet" />
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Css/style_ByDesigner.css" rel="stylesheet" />
    <link rel="stylesheet" href="../../Css/font-awesome.min.css" />
    </form>
</body>
</html>