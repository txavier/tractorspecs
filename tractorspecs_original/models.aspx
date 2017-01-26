<%@ Page Language="VB" AutoEventWireup="true" Inherits="TractorSpecsWebApp.models" MasterPageFile="~/2Column.Master" CodeBehind="models.aspx.vb" %>

<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolderLeft">
    <input id="txtid" runat="server" type="hidden" />
    <asp:Image ID="imgMFG" runat="server" Style="margin-bottom: 10px;" />
    <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow">
        <ItemTemplate>
            <div style="background: url(/images/onearrow.png) no-repeat; color: white; padding: 1px 10px 1px 1px;">
                <img alt="<%#DataBinder.Eval(Container.DataItem, "ClassName")%>" style="margin: 0px 10px 0px 0px;" src='/images/<%#DataBinder.Eval(Container.DataItem, "Icon")%>' />
                <div style="top: -13px; position: relative; display: inline; font-size: 11pt; font-weight: bold;">
                    <asp:Literal ID="lblcat" Text='<%#DataBinder.Eval(Container.DataItem, "ClassName")%>' runat="server"></asp:Literal></div>
            </div>
            <p id="spec">
                                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div style="font-size: 11pt; padding-bottom: 4px;">
                                &#149;
                                <%#Trim(DataBinder.Eval(Container.DataItem, "DisplayName")) & ":  "%><%#(DataBinder.Eval(Container.DataItem, "SpecValue"))%>
                                <%#DataBinder.Eval(Container.DataItem, "SpecMeasure")%><br />
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>               
            </p>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </ItemTemplate>
    </asp:DataList>
    <span style="padding-left: 10px;">
        <asp:HyperLink ID="speclink" runat="server" ImageUrl="/images/btneditspecs.gif"></asp:HyperLink></span>

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
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolderRight">
    <div style="background: url(../images/bigarrowsm.png) no-repeat; height: 30px; padding-left: 10px;">
        <h3 style="top: -4px; position: relative;">
            Unit Images</h3>
    </div>
    <div style="text-align: center;">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="unitdesc" runat="server" Text="Label"></asp:Label><br />
                <asp:HyperLink ID="imglink" runat="server"></asp:HyperLink><br />
                <asp:Label ID="piccount" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:ImageButton ID="ImgbtnPrev" runat="server" ImageUrl="/images/btnPrev.gif" /><asp:ImageButton ID="ImgbtnNext" runat="server" ImageUrl="/images/btnNext.gif" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <br />
    <div style="background: url(../images/bigarrow.png) no-repeat; height: 30px; padding-left: 10px;">
        <h3 style="top: -4px; margin-top: 30px; position: relative;">
            Reviews</h3>
    </div>
    <asp:DataList ID="reviewlist" runat="server">
        <ItemTemplate>
            <div style="clear: both;">
                <%#DataBinder.Eval(Container.DataItem, "reviewname")%>
                scored a
                <%#DataBinder.Eval(Container.DataItem, "reviewscore")%>
                on
                <%#FormatDateTime(DataBinder.Eval(Container.DataItem, "reviewdate"), DateFormat.ShortDate)%></div>
            <div style="padding-left: 30px">
                <%#DataBinder.Eval(Container.DataItem, "reviewtext")%><br />
            </div>
            <hr />
        </ItemTemplate>
    </asp:DataList><br />
    <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="/images/btnReview.gif"></asp:HyperLink>
    <br />

    <br />
    <br />

</asp:Content>
<asp:Content ID="Content4" runat="server" ContentPlaceHolderID="ContentPlaceHolderSectionTop">
    <h1>
        <asp:Literal ID="litSpecHead" runat="server"></asp:Literal></h1>
</asp:Content>
