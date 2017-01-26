<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditModels.aspx.vb" Inherits="TractorSpecsWebApp.EditModels" MasterPageFile="~/admin.master" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolderSectionTop">
    Models Edit
</asp:Content>

<asp:Content runat="server" ID="asdf" ContentPlaceHolderID ="ContentPlaceHolderMain">

       <div style="float:left; width:175px;">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
            <asp:DropDownList ID="ddlMake" runat="server" AutoPostBack="True" 
            Font-Size="11pt" Height="31px" Width="175px">
        </asp:DropDownList>
        
        <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="True" 
            Font-Size="11pt" Height="31px" Width="175px">
        </asp:DropDownList>
      
        <asp:ListBox ID="lstModels" runat="server" Height="575px" Width="175px" 
                AutoPostBack="True">
        </asp:ListBox>
        <div style="border:solid 1px black; width:173px; height:75px; text-align: center;">
        Add Model.
            <asp:TextBox ID="txtnewModel" runat="server" Width="148px"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddNew" runat="server" Text="Add New" />
            <asp:Button ID="Button1" runat="server" Text="Delete" />
        </div>
        
           </ContentTemplate>
         <Triggers>
             <asp:AsyncPostBackTrigger ControlID="ddlClass" 
                 EventName="SelectedIndexChanged" />
             <asp:AsyncPostBackTrigger ControlID="ddlMake" 
                 EventName="SelectedIndexChanged" />
         </Triggers>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
    <ProgressTemplate>
    <div style="left:400px; top:200px; position:absolute; height:200px; width:400px; background-color:#DCDCDC;">
    LOADING
    </div>    
    </ProgressTemplate>
    </asp:UpdateProgress>
        
        </div>
         <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
        <div style="overflow:scroll; height:700px; width:500px; float:left;">
           
                    <asp:GridView ID="specGrid" runat="server" AutoGenerateColumns="False" 
                EnableTheming="False" GridLines="None" CellPadding="4" ForeColor="#333333">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Label ID="lblSpecID" runat="server" Visible ="false" Text='<%# Bind("SpecNameID") %>'></asp:Label>
                                </ItemTemplate>
                                
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Label ID="lblOption" runat="server" Visible ="false" Text='<%# Bind("isoption") %>'></asp:Label>
                                </ItemTemplate>                                
                            </asp:TemplateField>
                           
                            <asp:BoundField DataField="classname" HeaderText="Class" />
                            <asp:TemplateField HeaderText="Specifiction">
                                                             <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("displayname") %>'></asp:Label>
                                </ItemTemplate>                                
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Value">
                            <ItemTemplate>
                                <asp:TextBox ID="txtspec" runat="server" Width="75px" Text='<%# Bind("specvalue") %>'></asp:TextBox>     
                                <asp:DataList ID="lstOption" runat="server">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtopt" runat="server" Width="75px" Text='<%# Bind("specvalue") %>'></asp:TextBox>    
                                       </ItemTemplate>                                
                                </asp:DataList>        
                            </ItemTemplate>
                            
                                <ItemStyle HorizontalAlign="Center" Width="75px" />
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                  
                                </ItemTemplate>                                
                            </asp:TemplateField>
                            <asp:BoundField DataField="specmeasure" HeaderText="Measure" />
                           
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
				    <asp:Button ID="btnSpecSave" runat="server" Text="Save" />
				 
            <br />
        </div>
        <div style="clear:both"></div>
        
        <div style="width:600px; height:130px; background-color:#ECECEC; padding:20px; margin:20px;">
        Model Alias Names<br />
        <div style="float:left;width:100px;">
        <asp:ListBox runat="server" ID="lstAlias"></asp:ListBox><br />
        <asp:Button runat="server" Text="Delete" ID="btnDeleteAlias" />
        </div>
        <div style="float:right;">
        Alias Name <asp:TextBox runat="server" ID="txtAlias"></asp:TextBox><br />
        Description <asp:TextBox runat="server" ID="txtAliasDesc"></asp:TextBox><br />
        <asp:Button runat="server" Text="add" ID="btnaddalias" /><br />
        
        </div>
        <div></div>
               
        
        </div> 
        
           </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="lstAttModels" 
                        EventName="SelectedIndexChanged" />
                </Triggers>
            </asp:UpdatePanel>
        
        <div style="clear:both"></div>
        
        
        <div style="width:600px; height:130px; background-color:#ECECEC; padding:20px; margin:20px;">
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
    <ContentTemplate>
        <div style="width:181px; text-align: center; float:left;">
            Available Attachments
            <br />
        <asp:DropDownList ID="ddlAttClass" runat="server" AutoPostBack="True" 
            Font-Size="11pt" Height="31px" Width="175px">
        </asp:DropDownList>
            <br />
        <asp:ListBox ID="lstAttModels" runat="server" Height="96px" Width="175px">
        </asp:ListBox>
        </div>
        <div style="text-align:center; padding:0px 200px 0px 200px;">
            <asp:Button ID="btnAdd" runat="server" Text="Add" Width="64px" /><br />
            <asp:Button ID="btnDel" runat="server" Text="Delete" Width="64px" />
            </div>
            <div style="float:right; position:relative; width:200px; top:-40px;">
            Selected Attachments<br />
        <asp:ListBox ID="lstAttachments" runat="server" Height="96px" Width="175px">
        </asp:ListBox>
        
        </div>
</ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="lstAttModels" 
                EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel></div>
    
</asp:Content>
