<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Portifolie_app.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div>
        <header>
            <h1>Login</h1>
        </header>
        <section>
            <ul>
                <li>
                    <asp:Label Text="Username" runat="server" /><asp:TextBox ID="txtUserName" runat="server" />
                </li>
                <li>
                    <asp:Label Text="Password" runat="server" /><asp:TextBox ID="txtPassword" runat="server" />
                </li>
                <li>
                    <asp:LinkButton ID="btnForgot" Text="Forgot your password?" runat="server" OnClick="btnForgot_Click" />
                    <asp:LinkButton ID="btnNewUser" Text="Need a user?" runat="server" OnClick="btnNewUser_Click" />
                    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
                </li>
                <li>
                    <asp:Label ID="lblStatus" runat="server" />
                </li>
            </ul>
        </section>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
