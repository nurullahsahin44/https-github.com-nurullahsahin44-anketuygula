<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sifremiunuttum.aspx.cs" Inherits="anketUygula.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <br />
        <br />
       Mail Adresinizi Yazınız <asp:TextBox ID="sifremiunutttummail" class="form-control"  runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
</asp:Content>
