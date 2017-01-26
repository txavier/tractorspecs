<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SpecGroups.aspx.vb" Inherits="TractorSpecsWebApp.SpecGroups" MasterPageFile="~/Admin.Master" %>

<asp:Content runat="server" ID="top1" ContentPlaceHolderID="ContentPlaceHolderSectionTop">
    <span>
Spec Groups
    and Fields
</span>
</asp:Content>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain">
    <div style="width:300px; float:left;">
<asp:ListBox runat="server" ID="LstSpecClass" AutoPostBack="True" Height="442px" Width="261px"></asp:ListBox>
    <br />
      <div style="border: solid 2px dimgray;margin-top:20px;">
    <br />
    <asp:TextBox ID="txtNewGroup" runat="server"></asp:TextBox>
    <asp:Button ID="btnAdd0" runat="server" Text="Add" />
    

    <asp:Button ID="btnDelete0" runat="server" Text="Delete" />
    <br />
    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    <br />
    </div> 
</div>

<div style="width:300px; float:right; height: 280px;">

<asp:ListBox runat="server" ID="LstSpecFields" Height="200px" Width="261px"></asp:ListBox>
    <br />
    <div style="border: solid 2px dimgray; margin-top:20px;">
    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    <br />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <br />
    Spec Field <asp:TextBox ID="TxtAdd" runat="server"></asp:TextBox><br />
    Measure (lb/kg/etc) <asp:TextBox ID="txtmeasure" runat="server"></asp:TextBox><br />
    Allow Multi <asp:CheckBox runat="server" ID="option" />       
    <asp:Button ID="btnAdd" runat="server" Text="Add" />
    </div>
</div>
    <br />
    <br />
    

</asp:Content>
