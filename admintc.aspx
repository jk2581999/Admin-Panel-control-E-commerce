<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admintc.aspx.cs" Inherits="admintc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Add Thirdcategory<span style="float: right"><asp:Button runat="server" Text="Back" CssClass="btn fa-arrow-left" OnClick="Unnamed1_Click"></asp:Button></span></h1>
    <br />
    <div class="material">
                        <div class="materialinside1">Add Categories</div>
                        <div class="materialinside2">
                            Category<br />
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="edit"></asp:DropDownList>
                            SubCategory<br />
                            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="edit"></asp:DropDownList>
                            Third Category<br />
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="edit"></asp:TextBox>
                            <br />
                            STATUS:<br />
                            <asp:DropDownList ID="DropDownList4" runat="server" CssClass="edit">
                                <asp:ListItem>ACTIVE</asp:ListItem>
                                <asp:ListItem>NOT-ACTIVE</asp:ListItem>
                            </asp:DropDownList><br />
                        </div>
                        <div style="text-align: center;">
                            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" CssClass="btn" />
                            <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn" Style="background-color: red;" />
                        </div>

                    
</asp:Content>

