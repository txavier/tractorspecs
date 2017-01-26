<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="search.aspx.vb" Inherits="TractorSpecsWebApp.serach" MasterPageFile="~/1Column.Master" %>


<asp:Content ID="Content1" runat="server"  contentplaceholderid="ContentPlaceHolderMain">
                        
                        <span style="font-size:16px">
                                         
                        Search : </span><asp:TextBox ID="txtSearch"  Font-Size="16px" runat="server"></asp:TextBox>   <asp:Button ID="btnSearch" runat="server" Text="Search" />
						<asp:UpdatePanel ID="UpdatePanel1" runat="server">
						
						<ContentTemplate>
                        
                            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="650px">
                <ItemTemplate>
              <%#DataBinder.Eval(Container.DataItem, "modelurl")%>
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
                	</ContentTemplate>				                            
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                            </Triggers>
                </asp:UpdatePanel>
                
       </asp:Content>
