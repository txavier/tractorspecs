<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Categories.aspx.vb" Inherits="TractorSpecsWebApp.Categories" MasterPageFile="~/2Column.Master" %>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="head">
    <title>TractorSpecs Equipment Categories</title>
    <meta content="Equipment Categories to find specification for different models of equipment" name="description" />
    <meta content="tractor equipment mower specification categories find models search" name="Keywords" />
</asp:Content>



<asp:Content ID="Content1" runat="server"  contentplaceholderid="ContentPlaceHolderLeft">
        
				<p style="font: font-family: Verdana; font-size: large; font-weight: bold;">Equipment Categories</p>
				
				<ul>
                    <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                     <li><a title='specs and data for <%#DataBinder.Eval(Container.DataItem, "classname")%>' href= '/class/<%#DataBinder.Eval(Container.DataItem, "classurl")%>.aspx'><%#DataBinder.Eval(Container.DataItem, "classname")%>(<%#DataBinder.Eval(Container.DataItem, "expr1")%>)</a></li>                                                            
                            </ItemTemplate>
                    </asp:Repeater>
                </ul>
		<br /><br />	
		                     
        
</asp:Content>


<asp:Content ID="Content2" runat="server"   contentplaceholderid="ContentPlaceHolderSectionTop">
   <h1>TractorSpecs.com Equipment Categories</h1>
</asp:Content>



<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolderRight">
 <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
<!-- 300x250, tractor specs -->
<ins class="adsbygoogle"
     style="display:inline-block;width:300px;height:250px"
     data-ad-client="ca-pub-5302599990463864"
     data-ad-slot="0470920905"></ins>
<script>
    (adsbygoogle = window.adsbygoogle || []).push({});
</script>				
   
</asp:Content>




