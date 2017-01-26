<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="classes.aspx.vb" Inherits="TractorSpecsWebApp.classes" MasterPageFile="~/2Columnb.Master" %>



<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolderLeft">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <div>
                <asp:Label ID="lblmake" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "mfgName")%>'></asp:Label>
                (<%#DataBinder.Eval(Container.DataItem, "expr1")%>)
                <%#DataBinder.Eval(Container.DataItem, "classname")%>
            </div>
            <div>
                <asp:DataList ID="dlmodels" runat="server" RepeatColumns="4" Width="450px">
                    <ItemTemplate>
                        <a href="/specs/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>/<%#DataBinder.Eval(Container.DataItem, "modelurl")%>.aspx"
                            title="<%#DataBinder.Eval(Container.DataItem, "mfgname")%> <%#DataBinder.Eval(Container.DataItem, "modelnumber")%> <%#DataBinder.Eval(Container.DataItem, "classname")%>">
                            <%#DataBinder.Eval(Container.DataItem, "modelnumber")%></a>
                    </ItemTemplate>
                </asp:DataList>
                <p style="width: 370px; text-align: right; font-size: 14px; font-weight: bold;">
                    <asp:HyperLink ID="lnkmake" runat="server"></asp:HyperLink></p>
            </div>
            <div style="margin: 0px auto 0px auto; width: 250px;">
                <asp:Literal ID="gAd" runat="server"></asp:Literal></div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolderRight">
    <span style="font-size: 11pt; font-weight: normal;">
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </span>
    <br />
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a title="<%#DataBinder.Eval(Container.DataItem, "mfgName")%> <%#DataBinder.Eval(Container.DataItem, "classname")%>"
                href="/mfg/<%#DataBinder.Eval(Container.DataItem, "mfgurl")%>/<%#DataBinder.Eval(Container.DataItem, "classurl")%>.aspx">
                <%#DataBinder.Eval(Container.DataItem, "mfgName")%></a><br />
        </ItemTemplate>
    </asp:Repeater>
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


<asp:Content ID="Content3" runat="server"  contentplaceholderid="ContentPlaceHolderSectionTop">
   <h1> <asp:Literal ID="Literal2" runat="server"></asp:Literal></h1>
</asp:Content>

