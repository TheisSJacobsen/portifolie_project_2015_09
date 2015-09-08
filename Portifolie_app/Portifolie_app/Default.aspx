<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Portifolie_app.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1>Portfolio List</h1>

    <ul>
        <asp:Repeater id="portRepeater" runat="server">
            <ItemTemplate>
                <li><a href="portfolio.aspx?=<%#Eval("ID") %>">
                    <img src="<%#Eval("userPicture") %>" alt="Alternate Text" />Portfolio of <%#Eval("userName")%></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
