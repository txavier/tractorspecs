<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="About.aspx.vb" Inherits="TractorSpecsWebApp.About" MasterPageFile="~/1Column.Master" %>



<asp:Content ID="Content1" runat="server"  contentplaceholderid="ContentPlaceHolderMain">


				<h1>About TractorSpecs.com</h1>
	
	<br /><br />					
                
              <ul>
              <li style="padding-bottom:10px"><strong>What is TractorSpecs.com?</strong><br />
              Our website is a collection of information about farm and construction equipment. Primarily tractors, but we encompass a bit of everything. Our goal is to collect specification data, pictures, prices and any documents for each machine. 
              </li>
              <li  style="padding-bottom:10px"><strong>Where does the information come from?</strong><br />
              Nothing you find on our website is unique, we're simply an agragation of owner reports, manuals, print, and product bochures. Some of what you'll find here has been collected by our staff, other data has been submited by equipment owners and enthusists. We do not promise 100% accuracy, however we do our best. 
              </li>
              <li style="padding-bottom:10px"><strong>How do you determine pricing?</strong><br />
              The pricing engine weights several factors in determining equipment values. Our starting data is based upon used listings put forth by equipment dealerships. This is run though a simple depriciation curve based on the type of equipment and its age. This is a simular method used by equipment blue books. While a mathamatical equasion can give an idea of equipment value, its only a guideline and not a substitue for an experienced appriasor. 
              </li>
              <li  style="padding-bottom:10px"><strong>Can you help me with...?</strong><br />
              No, we can't. We do not represent any of the companies who's products we have information about. Your best source of assistance will always be though our advertisers, or your local dealer network. 
              </li>
              <li  style="padding-bottom:10px"><strong>Can we advertise on this website?</strong><br />
              Yes. Please contact us and let us know what you've got in mind. We typicaly use 300x250 blocks, however we have other sites in out family that can accomidate other sizes and campains equaly well. We can structure programs around either CPM or fixed monthly pricing. 
              </li>
              <li  style="padding-bottom:10px"><strong>Can we use your data?</strong><br />
              We offer an web service for used equipment websites and dealers wishing to utilize our database to enhance their equipment listings. Contact us for details on this service.
              </li>
              </ul>                           
                              
                       
	
				
				 <div style="clear: both;"></div>    
     
  <div style="margin-left:auto; margin-right:auto; width:300px;">
    
     Email Address <asp:TextBox ID="txtEmail" runat="server" Width="185px"></asp:TextBox><br />
      <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine" Height="150px" Width="270px"></asp:TextBox><br />
      <asp:Button ID="btnEmail" runat="server" Text="Send" />
      
      
      <br />
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ControlToValidate="txtEmail" ErrorMessage="Please enter an email address"></asp:RequiredFieldValidator>
      <br />
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ControlToValidate="txtEmail" ErrorMessage="Invalid Email Address" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
      
      
   </div>
  

</asp:Content> 
<asp:Content ID="Content2" runat="server"  contentplaceholderid="ContentPlaceHolderSectionTop">
    <h1>About TractorSpecs.com</h1>
</asp:Content>
 
 
<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="head">
    <title>About TractorSpecs.com</title>
    <meta content="Tractor Specifications Website" name="description" />
    <meta content="Tractor Specifications" name="Keywords" />
</asp:Content>