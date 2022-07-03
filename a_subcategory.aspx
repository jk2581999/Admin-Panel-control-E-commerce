<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="a_subcategory.aspx.cs" Inherits="a_subcategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Add SubCategory<span style="float: right"><asp:Button runat="server" Text="Back" CssClass="btn fa-arrow-left" OnClick="Unnamed1_Click"></asp:Button></span></h1>
                    <br />
                    <div class="material">
                        <div class="materialinside1">Add SubCategories</div>
                        <div class="materialinside2">
                            Category<br />
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="edit" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" >
                            </asp:DropDownList>
                            SubCategory<br />
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="edit"></asp:TextBox>
                            <br />
                            STATUS:<br />
                            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="edit" >
                                <asp:ListItem>ACTIVE</asp:ListItem>
                                <asp:ListItem>NOT-ACTIVE</asp:ListItem>
                            </asp:DropDownList>
                            </div>
                        <div style="text-align: center;">
                            <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn" Style="background-color: red;" />
                            </div>
                    </div>
</asp:Content>

