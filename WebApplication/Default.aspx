<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:ListBox AutoPostBack="true"
            ID="ListBoxActividades"
            Rows="20"
            Width="500px"
            SelectionMode="Single"
            runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox AutoPostBack="true"
            ID="ListBoxComisiones"
            Rows="20"
            Width="500px"
            SelectionMode="Single"
            runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged"></asp:ListBox>
    </div>

</asp:Content>
