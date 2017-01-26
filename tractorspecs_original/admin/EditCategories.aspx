<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditCategories.aspx.vb" Inherits="TractorSpecsWebApp.EditCategories" MasterPageFile="~/Admin.Master"  %>

<asp:Content runat="server" ID="asdf" ContentPlaceHolderID = "ContentPlaceHolderSectionTop">Category Edit</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID = "ContentPlaceHolderMain">

    <div style="width:300px; float:left">
Category List

    <br />
    <asp:ListBox ID="LstCategories" runat="server" AutoPostBack="True" Height="600px" Width="276px"></asp:ListBox>
    <br />
    
    <div style="width:264px; height:71px; border : solid 2px dimgray">
        Add new Category<br />
        <asp:TextBox runat="server" ID="newCategory"></asp:TextBox><br /><asp:Button runat="server" ID="btnnewcat" Text="add category" />
        
    </div>
    
    </div>

<div style="width:300px; float:right">Spec Groups<br />
    <asp:CheckBoxList ID="ckCategories" runat="server" AutoPostBack="True">
    </asp:CheckBoxList>
    <br />
    </div>


</asp:Content>

