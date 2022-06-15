<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">

            <div class="col-xs-4">
                <p style="margin-bottom: 0px">Actividades</p>
                <asp:ListBox AutoPostBack="true"
                    ID="ListBoxActividades"
                    Rows="20"
                    Width="450px"
                    SelectionMode="Single"
                    runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            </div>
            <div class="col-xs-4">
                <p style="margin-bottom: 0px">Comisiones</p>
                <asp:ListBox AutoPostBack="true"
                    ID="ListBoxComisiones"
                    Rows="20"
                    Width="450px"
                    SelectionMode="Single"
                    runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged"></asp:ListBox>
            </div>



            <div class="col-xs-4">
                <p style="margin-bottom: 0px">Profesores</p>
                <asp:ListBox AutoPostBack="true"
                    ID="ListBoxProfesores"
                    Rows="20"
                    Width="450px"
                    SelectionMode="Single"
                    runat="server" OnSelectedIndexChanged="ListBox3_SelectedIndexChanged"></asp:ListBox>
            </div>
            <div class="col-xs-4">
                <p style="margin-bottom: 0px; padding-top: 20px">Socios</p>
                <asp:ListBox AutoPostBack="true"
                    ID="ListBoxSocios"
                    Rows="20"
                    Width="450px"
                    SelectionMode="Single"
                    runat="server" OnSelectedIndexChanged="ListBox4_SelectedIndexChanged"></asp:ListBox>
            </div>
            <div class="col-xs-4 justify-content-center">
                <div>
                </div>
            </div>
            <div class="col-xs-4 align-items-end">
                <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server" OnClick="Button1_Click" Text="Mostrar" Style="margin-top: 350px; margin-left: 200px;" />
            </div>
        </div>
    </div>

</asp:Content>
