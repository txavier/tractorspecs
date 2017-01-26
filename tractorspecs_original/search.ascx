<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="search.ascx.vb" Inherits="TractorSpecsWebApp.search" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<div class="search_bg03">
<div class="search_bg01">
<div class="fom01">
<div class="fom02">MODEL</div>
<div class="fom03">
<div class="fom04">
    <asp:TextBox ID="TextBox1" runat="server" class="field01" ></asp:TextBox>
    <asp:AutoCompleteExtender ID="autoComplete1" runat="server" 
        CompletionInterval="250" CompletionSetCount="12" EnableCaching="False" 
        MinimumPrefixLength="2" ServiceMethod="GetCompletionList" 
        ServicePath="search.asmx" TargetControlID="TextBox1" FirstRowSelected="True" 
        ContextKey="False"></asp:AutoCompleteExtender>
</div>
<div class="fom05">
    <asp:ImageButton ID="Button1" runat="server" Text="Search" ImageUrl="/images/go_24.png" />
</div>
</div>
<div class="c"></div>
</div>
</div>
