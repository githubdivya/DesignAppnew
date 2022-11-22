<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Default.Master" CodeBehind="Sitemap.aspx.vb" Inherits="DesignApp.Sitemap" meta:resourcekey="PageResource1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
    <style>
        a {color:black ;text-align :center  }
        a:hover { color :  #d35400; }
        h1 { color :#D2691E; text-align :center;font-weight :bolder; text-decoration-line :underline }
        h2{color : 	#D2691E;   }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
       <section id="formMain">
			
         
  <div class="container">
   <div class="row">
      <%--<div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">--%>
        <%--<div class="form">--%>
             <div class="form-group">
          <div class="form uploadDoc" >
        
				<h1>
                    <asp:Label  ID="lblsitemap"   runat="server"  Text="Sitemap" meta:resourcekey="lblsitemapResource1" ></asp:Label></h1>
               <h2>
                   <asp:Localize ID="Service" runat ="server" text="Service" meta:resourcekey="serviceResource1"></asp:Localize>
               </h2>
          <ul style="padding: 2px;" > 
           
             <li style="padding: 3px;">
                 <a href="Citizen/CitizenService.aspx" role="link"  >
                 <asp:Localize ID="citizenservice" runat ="server" text="Citizen Service" meta:resourcekey="citizenserviceResource1"></asp:Localize>
                 </a>
             </li>
              <li style="padding: 3px;">
                  <a href="https://digilocker.gov.in/" >
                  <asp:Localize ID="Digitallocker" runat ="server" text="Digital locker" meta:resourcekey="DigitallockerResource1"></asp:Localize> 
                  </a>
              </li>
              <li style="padding: 3px;">
                  <a href="http://www.gseb.org/" >
                  <asp:Localize ID="Localize1" runat ="server" text="Latest GSEB Exam Result" meta:resourcekey="LatestGSEBResource1"></asp:Localize> 
                  </a>
              </li>
              <li style="padding: 3px;">
                  <a href="http://garvi.gujarat.gov.in/" >
                  <asp:Localize ID="gARVIRegistered" runat ="server" text="gARVI-Registered Document&Jantri Rates" meta:resourcekey="gARVIRegisteredResource1"></asp:Localize> 
                  </a>
              </li>
             <%-- <li> <a href="http://garvi.gujarat.gov.in/" >Digital Gujarat Registration</a></li>--%>
              <li style="padding: 3px;"> 
                  <a href="https://electoralsearch.in/" >
                  <asp:Localize ID="ElectionID" runat ="server" text="Election ID" meta:resourcekey="ElectionIDResource1"></asp:Localize> 
                  </a></li>
              <li style="padding: 3px;"> 
                  <a href="https://eaadhaar.uidai.gov.in/" >
                    <asp:Localize ID="AadharCard" runat ="server" text="Aadhar Card" meta:resourcekey="AadharCardResource1"></asp:Localize> 
                  </a></li>
              <li style="padding: 3px;"> 
                  <a href="https://www.incometaxindiaefiling.gov.in/home" >
                    <asp:Localize ID="PANCard" runat ="server" text="PAN Card" meta:resourcekey="PANCardResource1"></asp:Localize> 
                  </a></li>
              <li style="padding: 3px;"> 
                  <a href="https://vahan.nic.in/nrservices/faces/user/jsp/SearchStatus.jsp" >
                     <asp:Localize ID="VehicleRegistration" runat ="server" text="Vehicle Registration Details" meta:resourcekey="VehicleRegistrationResource1"></asp:Localize> 
                  </a></li>
              <li style="padding: 3px;"> 
                  <a href="https://anyror.gujarat.gov.in/" >
                    <asp:Localize ID="AnyRoR" runat ="server" text="AnyRoR" meta:resourcekey="AnyRoRResource1"></asp:Localize> 
                  </a></li>
              
          </ul><br />
              <ul style="padding: 2px;">
                  <h2>
                       <asp:Localize ID="Employm" runat ="server" text="Employment" meta:resourcekey="EmploymentResource1"></asp:Localize> 
                  </h2>
                   <li style="padding: 3px;">
                        <a href="https://ojas.gujarat.gov.in/">
<asp:Localize ID="GovernmentJobs" runat ="server" text="Government Jobs" meta:resourcekey="GovernmentJobsResource1"></asp:Localize> 
                        </a>
                   </li>
                   <li style="padding: 3px;">
                        <a href="https://ojas.gujarat.gov.in/">
                       <asp:Localize ID="Industry" runat ="server" text="Industry Interface Cell" meta:resourcekey="IndustryResource1"></asp:Localize> 
                       </a>
                   </li>
                  </ul>
               <br />
              <ul style="padding: 2px;">
                  <h2>
                      <asp:Localize ID="Revenue" runat ="server" text="Revenue" meta:resourcekey="RevenueResource1"></asp:Localize> 
                  </h2>
                  <li style="padding: 3px;">
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=63">
                      <asp:Localize ID="Incomecertificate" runat ="server" text="Income certificate" meta:resourcekey="IncomecertificateResource1"></asp:Localize> 
                      </a>
                  </li>
                   <li style="padding: 3px;"> 
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=82">
                       <asp:Localize ID="CreamylayerCertificate" runat ="server" text="Non-Creamylayer Certificate" meta:resourcekey="CertificateResource2"></asp:Localize> 
                       </a>
                   </li>
                   <li style="padding: 3px;"> <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=71">
                       <asp:Localize ID="MinorityCertificate" runat ="server" text="Religious Minority Certificate" meta:resourcekey="ReligiousMinorityResource1"></asp:Localize> 
                       </a>
                   </li>
                   <li style="padding: 3px;">
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=64">
                       <asp:Localize ID="EducationallyBackward" runat ="server" text="Socially & Educationally Backward Class Certificate" meta:resourcekey="EducationallyBackwardResource1"></asp:Localize> 
                      </a>
                   </li>
                   <li  style="padding: 3px;"> 
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=362">
        <asp:Localize ID="CentralGoverment" runat ="server" text="Non-Creamylayer Certificate For Central Goverment" meta:resourcekey="CentralGovermentResource1"></asp:Localize> 
                        </a>
                   </li>
                   <li style="padding: 3px;">
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=77">
                       <asp:Localize ID="SeniorCitizen" runat ="server" text="Senior Citizen Certificate" meta:resourcekey="SeniorCitizenResource1"></asp:Localize> 
                       </a>
                   </li>
                   <li style="padding: 3px;"> 
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=79">
                       <asp:Localize ID="ReligiousMinority" runat ="server" text="Religious Minority Certificate" meta:resourcekey="ReligiousMinorityResource2"></asp:Localize> 
                       </a>
                   </li>
                  <li style="padding: 3px;"> 
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=65">
                      <asp:Localize ID="STCaste" runat ="server" text="SC/ST Caste Certificate" meta:resourcekey="STCasteResource1"></asp:Localize> 
                        </a>
                  </li>
                  <li style="padding: 3px;"> 
                     <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=66">
                    <asp:Localize ID="TemporaryResidence" runat ="server" text="Temporary Residence Certificate " meta:resourcekey="TemporaryResource1"></asp:Localize> 
                    </a>
                  </li>
                  <li style="padding: 3px;"> <a href="Citizen/CitizenService.aspx">
                      <asp:Localize ID="Moreid" runat ="server" text="More" meta:resourcekey="MoreResource2"></asp:Localize> 
                                             </a></li>
                 
              </ul>
              <br />
              <ul style="padding: 2px;">
                   <h2>
                       <asp:Localize ID="Panchayatid" runat ="server" text="Panchayat" meta:resourcekey="PanchayatResource1"></asp:Localize> 
                   </h2>
                  <li style="padding: 3px;"> 
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=309">
                      <asp:Localize ID="EconomicallyBackward" runat ="server" text="Economically Backward Certificate" meta:resourcekey="EconomicallyBackwardResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;"> 
                       <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=310">
                      <asp:Localize ID="Widow" runat ="server" text="Widow Certificate" meta:resourcekey="WidowResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;">  
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=307">
                      <asp:Localize ID="Income" runat ="server" text="Income certificate" meta:resourcekey="IncomeResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;">  
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=311">
                      <asp:Localize ID="Nonid" runat ="server" text="Non-Creamylayer Certificate" meta:resourcekey="CreamylayerResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;">  
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=308">
                       <asp:Localize ID="CentralGovermentid" runat ="server" text="Non-Creamylayer Certificate For Central Goverment" meta:resourcekey="NonResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;">  
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=366">
                      <asp:Localize ID="TempResidence" runat ="server" text="Temporary Residence Certificate" meta:resourcekey="TempResidenceResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;">
                      <a href="Citizen/CitizenService.aspx">
                      <asp:Localize ID="More" runat ="server" text="More" meta:resourcekey="MoreResource3"></asp:Localize> 
                      </a>
                  </li>
              </ul>
               <br />
                <ul style="padding: 2px;">
                   <h2>
                    <asp:Localize ID="StudentCorner" runat ="server" text="Student Corner" meta:resourcekey="StudentCornerResource3"></asp:Localize>
                   </h2>
                  <li style="padding: 3px;">  
                      <a href="https://www.digitalgujarat.gov.in/Citizen/ServiceDescription.aspx?ServiceID=605">
                      <asp:Localize ID="Hostel" runat ="server" text="Hostel" meta:resourcekey="HostelResource1"></asp:Localize> 
                      </a>
                  </li>
                  <li style="padding: 3px;">  
                      <a href="https://www.digitalgujarat.gov.in/Citizen/CitizenService.aspx?id=0">
<asp:Localize ID="Scholarship" runat ="server" text="Scholarship" meta:resourcekey="ScholarshipResource1"></asp:Localize> 
                         </a>
                  </li>
                  <li style="padding: 3px;">  
                      <a href="Tablet.aspx">
                      <asp:Localize ID="StudentTablet" runat ="server" text="Student Tablet" meta:resourcekey="StudentTabletResource1"></asp:Localize> 
                      </a>
                  </li>
                  </ul>
               <br />
              <ul style="padding: 2px;">
                  <h2>
                       <asp:Localize ID="Tourism" runat ="server" text="Tourism" meta:resourcekey="TourismResource1"></asp:Localize> 
                  </h2>
                    <li style="padding: 3px;"><a href="https://www.gujarattourism.com/">
                        <asp:Localize ID="GujaratTourism" runat ="server" text="Gujarat Tourism " meta:resourcekey="GujratTourismResource1"></asp:Localize> 
                        </a>
                    </li>
                    <li style="padding: 3px;">
                        <a href="https://www.gujarattourism.com/hubs/">
                        <asp:Localize ID="Placestovisit" runat ="server" text="Places to visit" meta:resourcekey="PlacestovisitResource1"></asp:Localize> 
                        </a>
                    </li>
                    <li style="padding: 3px;">
                        <a href="http://www.cottage.gujarat.gov.in/eng/?page_id=487">
                        <asp:Localize ID="KeyAttractions" runat ="server" text="Key Attractions" meta:resourcekey="AttractionsResource1"></asp:Localize> 
                        </a>
                    </li>
                    <li style="padding: 3px;">
                        <a href="https://girlion.gujarat.gov.in/">
                        <asp:Localize ID="GIR" runat ="server" text="GIR - Online Permit Booking " meta:resourcekey="GIRResource1"></asp:Localize> 
                        </a>
                    </li>
                    <li style="padding: 3px;">
                        <a href="http://www.somnath.org/">
                        <asp:Localize ID="Somnath" runat ="server" text="Somnath" meta:resourcekey="SomnathResource1"></asp:Localize> 
                        </a>
                    </li>
                    <li style="padding: 3px;">
                        <a href="http://booking.gujarattourism.com/">
                        <asp:Localize ID="Booking" runat ="server" text="State Tourism Online Booking" meta:resourcekey="BookingResource1"></asp:Localize> 
                        </a>
                    </li>

                  </ul>
          
                </div>
               </div>
       <%--</div>--%>
    </div>
          </div>
           </section> 
</asp:Content>
