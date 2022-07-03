<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page2.aspx.cs" Inherits="page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
    <div class="main">
            <div class="left">
                <ul>
                    <li>
                        <a href="#"><i class="fa fa-dashboard"></i>Dashborard</a>
                    </li>
                    <li>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>select page</asp:ListItem>
                            <asp:ListItem>entrypage.aspx</asp:ListItem>
                            <asp:ListItem>page2.aspx</asp:ListItem>
                            <asp:ListItem>page3.aspx</asp:ListItem>
                        </asp:DropDownList>
                    </li>
                </ul>
            </div>
        <div class="right">
                <div class="header">
                    <div class="hdiv">
                        <ul class="lh">
                            <li>
                                <input type="text" name="search" placeholder="  Searchfor.." class="inp" />
                            </li>
                            <li>
                                <button type="button" class="bt"><i class="fa fa-search"></i></button>
                            </li>
                            <div class="clr"></div>


                        </ul>
                        <ul class="rh">
                            <li><i class="fa fa-envelope" style="color: rgb(213,213,225)"><sup><span style="background-color: rgb(227,72,52);">3+</span></sup></i></li>
                            <li><i class="fa fa-bell" style="color: rgb(213,213,225)"><sup><span style="background-color: rgb(227,72,52);">3+</span></sup></i></li>
                            <div class="clr"></div>
                        </ul>

                        <div class="clr"></div>

                    </div>
                    <div class="h2div">
                        Keshwani Jitesh&nbsp;<i class="fa fa-pencil"></i>
                    </div>

                    <div class="clr"></div>
                </div>
            <div class="content">

                    <h1>Add SubCategory<span style="float: right"><asp:Button runat="server" Text="Button" CssClass="btn fa-arrow-left"></asp:Button></span></h1>
                    <br />
                    <div class="material">
                        <div class="materialinside1">Add SubCategories</div>
                        <div class="materialinside2">
                            Category<br />
                            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="edit" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" >
                                <asp:ListItem>--SelectCategory--</asp:ListItem>
                                <asp:ListItem>Electronics</asp:ListItem>
                                <asp:ListItem>Clothes</asp:ListItem>
                                <asp:ListItem>Books,Sports and more</asp:ListItem>
                            </asp:DropDownList>
                            SubCategory<br />
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="edit"></asp:TextBox>
                            <br />
                            STATUS:<br />
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="edit" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                <asp:ListItem>ACTIVE</asp:ListItem>
                                <asp:ListItem>NOT-ACTIVE</asp:ListItem>
                            </asp:DropDownList>
                            </div>
                        <div style="text-align: center;">
                            <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn" Style="background-color: red;" />
                            </div>
                    </div>
                    <div style="margin: 20px auto">
                        <asp:GridView ID="GridView1" runat="server" CssClass="grd"></asp:GridView>
                        </div>

                </div>


                <div class="footer">
                    copyright &copy; your website 2020
                </div>
                <br />
            </div>
            <div class="clr"></div>
                        

        </div>
    </form>
</body>
</html>
