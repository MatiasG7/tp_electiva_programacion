<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:ListBox AutoPostBack="true"
            ID="ListBoxActividades"
            Rows="20"
            Width="450px"
            SelectionMode="Single"
            runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox AutoPostBack="true"
            ID="ListBoxComisiones"
            Rows="20"
            Width="450px"
            SelectionMode="Single"
            runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox AutoPostBack="true"
            ID="ListBoxProfesores"
            Rows="20"
            Width="450px"
            SelectionMode="Single"
            runat="server" OnSelectedIndexChanged="ListBox3_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox AutoPostBack="true"
            ID="ListBoxSocios"
            Rows="20"
            Width="450px"
            SelectionMode="Single"
            runat="server" OnSelectedIndexChanged="ListBox4_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar" BackColor="White" BorderStyle="Inset" Font-Bold="True" Font-Size="Large" Height="69px" Width="186px" Style="margin-left: 250px" />
    </div>

</asp:Content>
