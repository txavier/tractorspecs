<%@ Page Language="VB" AutoEventWireup="false" Inherits="TractorSpecsWebApp.review" Codebehind="edit.aspx.vb" MasterPageFile="~/2Columnb.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
 </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="server">

    
				<div style="background: url(../images/bigarrow.png) no-repeat; height:30px;  padding-left:10px;"><h3 style="top:-4px; position:relative;">Write a Review</h3></div>
				
			<asp:Panel ID="Panel2" runat="server">
					Your Name  <asp:TextBox ID="txtname" runat="server" Width="155px">Anonymous</asp:TextBox>
                    <br />
                    Your Email
                    <asp:TextBox ID="txtemail" runat="server" Width="155px"></asp:TextBox>
                    <br />
                    (*email addresses are not shared)<br />
                    <br />
                    Review Text<br />
                    <asp:TextBox ID="txtreview" runat="server" Height="103px" MaxLength="4000" 
                        TextMode="MultiLine" Width="250px"></asp:TextBox>
                    <br />
                    Score <asp:RadioButtonList ID="RadioButtonList1"  runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    <asp:ListItem>4</asp:ListItem>
    <asp:ListItem Selected="true">5</asp:ListItem>
</asp:RadioButtonList>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
    <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                   
                    </asp:Panel>
                  
				<br /><br />
			
				<div style="background: url(../images/bigarrow.png) no-repeat; height:30px;  padding-left:10px;"><h3 style="top:-4px; position:relative;">Upload Pictures</h3></div>
					<asp:Panel ID="Panel3" runat="server">
						Step 1: Select the file<br /><asp:FileUpload ID="ulbox" runat="server" />
    <br />
  
    <br />
        Step 2: Enter a description<br /><asp:TextBox ID="TextBox1" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
    <br />
    Step 3:  Upload to the site<br /> <asp:Button ID="btnupload" runat="server" Text="Upload" />
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <asp:Label ID="lblError" runat="server"></asp:Label>
				
                        </asp:Panel>
                        
						<br /><br />
				<div style="background: url(../images/bigarrow.png) no-repeat; height:30px;  padding-left:10px;"><h3 style="top:-4px; position:relative;">Add a Link</h3></div>
			
				 <asp:Panel ID="Panel1" runat="server">
           Step 1: Enture the URL (http://)<br /><asp:TextBox ID="url" runat="server" MaxLength="50" Width="200px"></asp:TextBox>
    <br />
    <br />
    Step 2: Enter a description<br /><asp:TextBox ID="urldesc" runat="server" MaxLength="50" Width="200px"></asp:TextBox>
    <br />
    Step 3:  Submit for Approval<br /> <asp:Button ID="Addurl" runat="server" Text="Submit" 
                        Height="24px" Width="63px" />
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
           		   
                    </asp:Panel>
           	
			
				
			           <asp:Literal ID="Literal5" runat="server"></asp:Literal>
			<br /><br />
		
<div style="background: url(../images/bigarrow.png) no-repeat; height:30px;  padding-left:10px;"><h3 style="top:-4px; position:relative;">Add Pricing</h3></div>
				<asp:Panel ID="Panel4" runat="server">
Dealer / Private   <asp:DropDownList ID="DorP" runat="server"></asp:DropDownList><br />
Price: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
Model Year:  <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
Notes:  <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
           		   
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Submit" /><br />
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
           		   
                    </asp:Panel>
           		
           	
</asp:Content>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolderRight">
    
<div style="background: url(../images/bigarrowsm.png) no-repeat; height:30px;  padding-left:10px;"><h3 style="top:-4px; position:relative;">Edit Specs</h3></div>
				<div>
				Specification Class<br />
                    <asp:DropDownList ID="ddspecclass" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <br />
                    <asp:GridView ID="specGrid" runat="server" AutoGenerateColumns="False" 
                        BorderStyle="None" EnableTheming="False" GridLines="None">
                        <Columns>
                            <asp:TemplateField HeaderText="Specifiction">
                                                             <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("displayname") %>'></asp:Label>
                                </ItemTemplate>                                
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Value">
                            <ItemTemplate>
                                <asp:TextBox ID="txtspec" runat="server" Width="80px" Text='<%# Bind("specvalue") %>'></asp:TextBox>                            
                            </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="75px" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="specmeasure" HeaderText="Measure" />
                           
                            <asp:BoundField DataField="SpecNameID" Visible="False" />
                           
                        </Columns>
                    </asp:GridView>
				    <br />
                    Source(website, book, etc)<br />
                    <asp:TextBox ID="TextBox2" runat="server" MaxLength="50"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnspecsave" runat="server" Text="Save Values" />
                    <br />
                    <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                    <br />
                    <hr />
                    Changes to machine specifications are moderated and do not appear right away. 
                    </div>
				
				
 
</asp:Content>

<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolderSectionTop">
  <h1>  <asp:Literal ID="Literal6" runat="server"></asp:Literal></h1>
</asp:Content>


