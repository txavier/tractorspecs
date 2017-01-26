<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AllMakes.aspx.vb" Inherits="TractorSpecsWebApp.AllMakes" MasterPageFile="~/1Column.Master" %>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="head">
    <title>TractorSpecs Manufacturer Listing</title>
    <meta content="Listing of manufacturers represented on tractorspecs.com" name="description" />
    <meta content="Tractor Companies" name="Keywords" />
</asp:Content>



<asp:Content ID="Content1" runat="server"  contentplaceholderid="ContentPlaceHolderMain">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="650px">
                <ItemTemplate>
                <a href = '/mfg/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>.aspx' title='<%#DataBinder.Eval(Container.DataItem, "mfgname")%> Equipment'><%#DataBinder.Eval(Container.DataItem, "mfgname")%> (<%#DataBinder.Eval(Container.DataItem, "expr1")%>)</a>             
                </ItemTemplate>
                </asp:DataList>		
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

<asp:Content ID="Content2" runat="server"  contentplaceholderid="ContentPlaceHolderSectionTop">
<h1>All Companies Represented On TractorSpecs</h1>

</asp:Content>

