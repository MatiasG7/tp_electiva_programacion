<%@ Page Title="Mostrar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="WebApplication.Mostrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>
            <asp:Image ID="Image1" runat="server" Height="39px" Width="65px" />
            <asp:Label ID="LabelDescripcion" runat="server" Text="Label"></asp:Label>
        </h2>
        <p>
            <asp:Label ID="LabelID" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server" Height="170px" Width="230px"></asp:ListBox>
    </div>
</asp:Content>
