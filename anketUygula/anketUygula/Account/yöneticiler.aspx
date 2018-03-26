<%@ Page Title="" Language="C#" MasterPageFile="~/genel.Master" AutoEventWireup="true" CodeBehind="yöneticiler.aspx.cs" Inherits="anketUygula.yöneticiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server"  Text="YÖNETİCİLER" style="text-align: right;" Font-Size="X-Large" Font-Bold="True" BorderWidth="0px"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
         <asp:Table ID="Table1" runat="server" BorderColor="DarkGreen" BorderWidth="1" Width="80%" Font-Size="12">  
            <asp:TableHeaderRow ForeColor="SeaGreen">  
                <asp:TableHeaderCell>Yönetici ID</asp:TableHeaderCell>  
                <asp:TableHeaderCell>Yönetici TC</asp:TableHeaderCell>
                <asp:TableHeaderCell>Yönetici İsim</asp:TableHeaderCell>  
                <asp:TableHeaderCell>Yönetici Soyisim</asp:TableHeaderCell> 
                <asp:TableHeaderCell>Yönetici Telefon</asp:TableHeaderCell>  
                <asp:TableHeaderCell>Yönetici E-Mail</asp:TableHeaderCell> 
                <asp:TableHeaderCell>Yönetici Şehir</asp:TableHeaderCell>  
                  
            </asp:TableHeaderRow>  
            <asp:TableRow>  
                <asp:TableCell></asp:TableCell>  
                <asp:TableCell></asp:TableCell>  
                <asp:TableCell></asp:TableCell>  
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>  
                <asp:TableCell></asp:TableCell>  
                <asp:TableCell></asp:TableCell>  
            </asp:TableRow>  
        </asp:Table>  
        <br />
        <br />
        
        <br />
        <br />
       
    </div>
    
</asp:Content>
