﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admintcshow.aspx.cs" Inherits="admintcshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>SubCategory List<span style="float:right"><asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn fa-arrow-left" OnClick="Button1_Click"/></span></h1>
    <div>
    <asp:GridView ID="GridView1" runat="server" class="grd"></asp:GridView>
     </div>
</asp:Content>

