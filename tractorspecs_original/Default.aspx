<%@ Page Language="VB" AutoEventWireup="true" Inherits="TractorSpecsWebApp._Default" Codebehind="Default.aspx.vb" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register src="header.ascx" tagname="header" tagprefix="uc1" %>
<%@ Register src="footer.ascx" tagname="footer" tagprefix="uc2" %>
<%@ Register src="search.ascx" tagname="search" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<title>TractorSpecs.com | The Machinery Database Project</title>
<meta content="Specifications and information for tractors and all types of agricultural and industrial equipment." name="description" />
<meta content="tractor specs data info price used value engine trade" name="keywords" />
<script type="text/javascript">

  var _gaq = _gaq || [];
  _gaq.push(['_setAccount', 'UA-160765-6']);
  _gaq.push(['_setDomainName', 'none']);
  _gaq.push(['_setAllowLinker', true]);
  _gaq.push(['_trackPageview']);

  (function() {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
  })();

</script>
<script type="text/javascript">window.google_analytics_uacct = "UA-160765-6";</script>
</head>

<body>
    <form id="form3" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
<div class="wrap">
<!--header_begin-->
    
    <uc1:header ID="header1" runat="server" />
<!--header_end-->
<!--cotant_begin-->
<div id="content">
<uc3:search ID="server1" runat="server" />
<div class="search_bg02">Welcome to TractorSpecs.com</div> 
</div>
<div class="cont_bg01">
<div class="sec_right_bg">
<!--sec_left_begin-->
<div id="sec_left">
<div class="nav_width">
<div class="nav_t"></div>
<!--nav_begin-->
<div id="nav">
<ul>
<li class="home"><a href="http://www.tractorspecs.com">Home</a></li>
<li class="search"><a href="/search.aspx">Search</a></li>
<li class="compare"><a href="/compare.aspx">Compare</a></li>
<li class="brand"><a href="/allmakes.aspx">Brands</a></li>
<li class="type"><a href="/Categories.aspx">Equip Types</a></li>
</ul>
</div>
<!--nav_end-->
<div class="nav_b"></div>
</div>
<div class="pad01"><h2>Manufacturers</h2></div>
<div id="mfs">
<ul>
    <asp:Repeater ID="dlmakes" runat="server">
    <ItemTemplate>
    <li><a title="<%#DataBinder.Eval(Container.DataItem, "mfgName")%> tractor and equipment specs" href="mfg/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>.aspx"><%#DataBinder.Eval(Container.DataItem, "mfgName")%> 
        (<%#DataBinder.Eval(Container.DataItem, "expr1")%>)</a></li>
    </ItemTemplate>
    </asp:Repeater>

<li class="last"><a href="#">Landini (81)</a></li>
</ul>
</div>
<div class="more"><a href="#">more</a></div>
</div>
<!--sec_left_end-->
<!--sec_right_begin-->
<div id="sec_right">
<div class="sec_right_t"></div>
<div class="pad02">
<div class="wel"></div>
<p>Tractor Specs is a collection of specifications, prictures, resources and pricing 
    information on tractors and equipment. We collect data on agricultural, 
    construction, landscape machines are their implements from all brands.</p>                                            
<p>We're a community resource. The information on our pages is largly user submited. 
    You can help make the site more useful by submitting what you know about 
    specifications and pricing. Today we have <asp:Literal ID="Literal1" runat="server"></asp:Literal> 
    models and <asp:Literal ID="Literal2" runat="server"></asp:Literal> datapoints.</p><br /><br />
<div class="box01">
    
<div class="box_bdr">
<div class="box_t"><h3>Equipment Parts</h3></div>
<div class="pad03" style="height:240px; ">
  <img src="images/img_pro_43.jpg" alt="" width="126" height="92" border="0" align="left" class="bdr_img"/><span class="heading01">Equipment Parts</span>
  <p>Messicks Equipment, one of our site sponsors, has added several parts catalogs to their forward thinking website. Some of these are brand new and are availabile only at Messicks. 
 </p>

 <div style="float:left; padding-left:30px;">
<a title="LandPride Parts" href="http://www.messicks.com/LandPrideParts.aspx">Land Pride Parts</a> <br />
<a title="Befco Parts" href="http://www.messicks.com/BefcoParts.aspx">Befco Parts</a> <br />
<a title="Alamo Parts" href="http://www.messicks.com/AlamoParts.aspx">Alamo Industrial</a> <br />
<a title="Ferris Parts" href="http://www.messicks.com/FerrisParts.aspx">Ferris Parts</a> <br />
</div>
<div style="float:right; padding-right:30px;">
<a title="Simplicity Parts" href="http://www.messicks.com/SimplicityParts.aspx">Simplicity Parts</a> <br />
<a title="eXmark Parts" href="http://www.messicks.com/exmarkparts.aspx">eXmark Parts</a> <br />
<a title="Cub Cadet Parts" href="http://www.messicks.com/CubCadetParts.aspx">Cub Cadet Parts</a> <br />

</div>
</div>
<div class="box_b"></div>  
</div>
</div> 
<div class="box02">
<div class="box_bdr">
<div class="box_t"><h3>Marketplace</h3></div>

<div class="pad03" style="height:240px; padding-left:15px;">
<script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
<!-- 300x250, tractor specs -->
<ins class="adsbygoogle"
     style="display:inline-block;width:300px;height:250px"
     data-ad-client="ca-pub-5302599990463864"
     data-ad-slot="0470920905"></ins>
<script>
    (adsbygoogle = window.adsbygoogle || []).push({});
</script>

</div>
<div class="box_b"></div>  
</div>
</div>
<div class="c"></div><br /><br />
<div class="box01">
<div class="box_bdr">
<div class="box_t"><h3>Industry News</h3></div>
<div class="pad03">
 <img src="images/img_pro_43.jpg" alt="" width="126" height="92" border="0" align="left" class="bdr_img"/><span class="heading01">NH Build & Price</span>
  <p>New Holland has partnered with Iron Solutions for a new build and price tool available on NewHolland.com. Select your model and options for a quick list price or forward the quote to the dealer network for a discounted sale price.</p>
 
<a href="http://nh.ironbuilder.com/default.aspx"><img src="images/more_56.png" alt="" width="111" height="18" border="0" /></a></div>
<div class="box_b"></div>  
</div>
</div> 
<div class="box02">
<div class="box_bdr">
<div class="box_t"><h3>Just Updated</h3>
</div>
<div class="pad03" >
   
    <ul>
    <asp:Repeater ID="RepUpdated" runat="server">
    <ItemTemplate>
<li><a title="<%#DataBinder.Eval(Container.DataItem, "mfgname")%> <%#DataBinder.Eval(Container.DataItem, "modelnumber")%> Specifications" href="/specs/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>/<%#DataBinder.Eval(Container.DataItem, "modelurl")%>.aspx"><%#DataBinder.Eval(Container.DataItem, "mfgname")%> <%#DataBinder.Eval(Container.DataItem, "modelnumber")%></a></li>    
    </ItemTemplate>
    </asp:Repeater>
</ul>

</div><div class="box_b"></div>  



</div>
</div>

</div>
</div>
<!--sec_right_end-->
<div class="c"></div>
</div>
<div class="sec_right_b"></div>
</div>
<!--cotant_end-->
<!--foot_begin-->
<uc2:footer ID="footer1" runat="server" />    
<!--foot_end-->
</div> </form>
</body>
</html>
