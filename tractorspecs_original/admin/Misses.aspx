<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Misses.aspx.vb" Inherits="TractorSpecsWebApp.Misses" MasterPageFile="~/admin.Master" %>



<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolderMain">
        API Requests with no results. 
        <asp:UpdatePanel runat="server" ID="up1">
        <ContentTemplate>
        
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="thisid">
        <Columns>
            <asp:BoundField DataField="thisid" Visible="False" />
            <asp:BoundField DataField="misses" HeaderText="Misses" />
            <asp:BoundField DataField="Make" HeaderText="Make" />
            <asp:BoundField DataField="Model" HeaderText="Model" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
        </Columns>
    </asp:GridView>
</ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
