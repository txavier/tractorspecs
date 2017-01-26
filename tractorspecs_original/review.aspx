<%@ Page Language="VB" AutoEventWireup="false" Inherits="TractorSpecsWebApp.review" Codebehind="review.aspx.vb" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Add content to listing</title>
<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
	
	
	<div id="body">
	<br class="spacer" />

<div id="aboutMain">
	<div id="about">
	<img src="images/logo_kubota.jpg" style="float:left;" />
	<p style="text-align:right; border-bottom:solid 4px #f4f4f4; font-size:large;">Kubota Tractor Corp.</p> 
	Established in 1890, the Kubota Corporation has a long history of manufacturing agricultural machinery in Japan. With an excellent line of compact tractors, necessary on smaller Japanese farms, Kubota entered the North American market in 1969. In 1974, Kubota introduced a 12 HP four-wheel drive tractor in the US. Prior to that point, US manufacturers did not use four-wheel drive except in the largest models.
	</div></div>
	
<div id="models">


<div style=" background-color:#696662;font:bold 12px/20px Arial, Helvetica, sans-serif;  color:White; text-align:center; margin-bottom:20px;">
    <asp:Literal ID="Literal4" runat="server"></asp:Literal>
</div>


<div style="border: solid 2px #dcdcdc; padding:0px 10px 10px 10px; height:270px; width:320px; float:left; margin-left:50px;">
<p style="width:269px; border-bottom:solid 6px #ff6600; text-align:center; font-weight:bold; width:320px;"><asp:Literal ID="litmakemod" runat="server"></asp:Literal></p>
    <br />
    Your Name  <asp:TextBox ID="txtname" runat="server">Anonymous</asp:TextBox><br />
    Review Text<br /><asp:TextBox ID="txtreview" MaxLength ="4000" TextMode="MultiLine" runat="server" Height="103px" Width="250px"></asp:TextBox><br />
    Score <asp:RadioButtonList ID="RadioButtonList1"  runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    <asp:ListItem>4</asp:ListItem>
    <asp:ListItem Selected="true">5</asp:ListItem>
</asp:RadioButtonList>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
    <asp:Literal ID="Literal3" runat="server"></asp:Literal><br />
</div>	
<div style="float:right; padding-right:100px;">
 <script type="text/javascript"><!--
google_ad_client = "pub-5302599990463864";
/* 300x250, tractor specs */
google_ad_slot = "0470920905";
google_ad_width = 300;
google_ad_height = 250;
//-->
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script>
</div>
           
            
        <br />
  <div style=" background-color:#696662;font:bold 12px/20px Arial, Helvetica, sans-serif;  color:White; text-align:center;">
Links & Files
</div>

<table><tr><td>
<div style="width:270px; height:200px; border: solid 1px #dcdcdc; font-size:13px; padding:3px; margin-left: 30px;">
<p style="width:269px; border-bottom:solid 6px #ff6600; text-align:center; font-weight:bold; margin-right:20px">Add a link</p>
<br />Step 1: Enture the URL (http://)<br /><asp:TextBox ID="url" runat="server" MaxLength="50" Width="200px"></asp:TextBox>
    <br />
    <br />
    Step 2: Enter a description<br /><asp:TextBox ID="urldesc" runat="server" MaxLength="50" Width="200px"></asp:TextBox>
    <br />
    Step 3:  Submit for Approval<br /> <asp:Button ID="Addurl" runat="server" Text="Submit" />
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label></div></td><td>
<div style="width:270px;  height:200px; border: solid 1px #dcdcdc; font-size:13px; padding:3px; margin-right:20px;">
<p style="width:269px; border-bottom:solid 6px #ff6600; text-align:center; font-weight:bold;">Upload a file</p>
<br />Step 1: Select the file<br /><asp:FileUpload ID="attach" runat="server" />
    <br />
  
    <br />
        Step 2: Enter a description<br /><asp:TextBox ID="TextBox3" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
    <br />
    Step 3:  Upload to the site<br /> <asp:Button ID="Button1" runat="server" Text="Upload" />
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label></div></td><td><div style="width:270px;  height:200px; border: solid 1px #dcdcdc; font-size:13px; padding:3px;">
<p style="width:269px; border-bottom:solid 6px #ff6600; text-align:center; font-weight:bold; border-right-width: 10px; border-bottom-width: 6px;">Upload your Pictures</p>
<br />Step 1: Type a short description<br /><asp:TextBox ID="TextBox1" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
    <br />
  
        <br />
        Step 2: Find the Photo on your PC<br /><asp:FileUpload ID="Ulbox" runat="server" />
    <br />
  <br />
        Step 3:  Upload your photo to our database<br /> <asp:Button ID="btnUpload" runat="server" Text="Upload" />
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label></div></td></tr></table>


</div>
	


      </div>     </div> 
	<br class="spacer" />
	
	<!--body end --><!--footer start --><div id="footerMain">
	<div id="footer">
	<ul>
	<li><a href="#">Home</a>|</li>
	<li><a href="#">Services</a>|</li>
	<li><a href="#">Testimonials</a>|</li>
	<li><a href="#">Projects</a>|</li>
	<li><a href="#">Privacy</a>|</li>
	<li><a href="#">Latest Ideas</a></li>
	</ul>
	<p class="ern">Part of the Equipment Review Network family of sites.</p>
		</div>
	</div>
	<!--footer end --></form> <script type="text/javascript">
var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
</script>
<script type="text/javascript">
var pageTracker = _gat._getTracker("UA-160765-6");
pageTracker._trackPageview();
</script>
</body>
</html>

