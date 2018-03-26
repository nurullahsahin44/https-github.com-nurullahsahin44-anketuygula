<%@ Page Title="" Language="C#" MasterPageFile="~/genel.Master" AutoEventWireup="true" CodeBehind="yöneticisil.aspx.cs" Inherits="anketUygula.yöneticisil1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server"  Text="YÖNETİCİ SİL" style="text-align: right;" Font-Size="X-Large" Font-Bold="True" BorderWidth="0px"></asp:Label>
        <br />
        
       
        <br />
        <asp:Label ID="Label2" runat="server" Text="Yönetici ID Giriniz :"></asp:Label>
        <asp:TextBox ID="yoneticisil" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Yönetici Sil" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Yönetici Silindi" Visible="False"></asp:Label>
        <br />
        
       
    </div>
</asp:Content>
