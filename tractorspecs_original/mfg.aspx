<%@ Page Language="VB" AutoEventWireup="false" Inherits="TractorSpecsWebApp.mfg" MasterPageFile="~/2Columnb.Master"  Codebehind="mfg.aspx.vb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
 </asp:Content>
 
 <asp:Content ID="content2" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="server">
 
 
<img src="" runat="server" id="logoimg" alt=""  border="0" align="left" style="padding-right:15px"/>

<asp:Literal ID="litmfgdesc" runat="server"></asp:Literal>
<div style="clear:both;"></div> 
<hr />
<div style="clear:both;"></div> 
      		<span style="font-weight:bold;">
        <asp:Literal ID="mfg3" runat="server"></asp:Literal></span>			        
			<br />
				
            
			
    <asp:DataList ID="DataList1" runat="server" CellPadding="10" RepeatColumns="6" Width="480px">
            <ItemTemplate>
            <a title="<%#DataBinder.Eval(Container.DataItem, "mfgname")%> <%#DataBinder.Eval(Container.DataItem, "modelnumber")%> specifications and information" href = '/specs/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>/<%#DataBinder.Eval(Container.DataItem, "modelurl")%>.aspx'><%#DataBinder.Eval(Container.DataItem, "modelnumber")%></a>                            
            </ItemTemplate>
        </asp:DataList>
        
       
	
 
	</asp:Content>
<asp:Content ID="Content3" runat="server"  contentplaceholderid="ContentPlaceHolderRight">
<script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
<!-- 300x250, tractor specs -->
<ins class="adsbygoogle"
     style="display:inline-block;width:300px;height:250px"
     data-ad-client="ca-pub-5302599990463864"
     data-ad-slot="0470920905"></ins>
<script>
    (adsbygoogle = window.adsbygoogle || []).push({});
</script>
<ul>
    <asp:Repeater ID="ReptTypes" runat="server">
    <ItemTemplate>
     <li><a title="<%#DataBinder.Eval(Container.DataItem, "mfgname")%> <%#DataBinder.Eval(Container.DataItem, "className")%>" href='/mfg/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>/<%#DataBinder.Eval(Container.DataItem, "classurl")%>.aspx'><%#DataBinder.Eval(Container.DataItem, "className")%> </a></li>
    </ItemTemplate>
    </asp:Repeater>
 	
<li>    <a href="/Categories.aspx" style="font-weight:bold;">More...</a></li>
</ul>

<script type="text/javascript"><!--
    google_ad_client = "ca-pub-5302599990463864";
    /* Tspecs - small square */
    google_ad_slot = "8133305647";
    google_ad_width = 200;
    google_ad_height = 200;
//-->
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script>

</asp:Content>

<asp:Content ID="Content4" runat="server"    contentplaceholderid="ContentPlaceHolderSectionTop">
    <h1> <asp:Literal ID="Literal1" runat="server"></asp:Literal></h1>
</asp:Content>

