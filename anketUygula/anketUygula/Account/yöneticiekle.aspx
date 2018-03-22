<%@ Page Title="" Language="C#" MasterPageFile="~/genel.Master" AutoEventWireup="true" CodeBehind="yöneticiekle.aspx.cs" Inherits="anketUygula.anket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="YÖNETİCİ EKLE" Font-Size="X-Large" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br/>
        <table style="width:75%; height: 258px;">
            <tr>
                <td style="width: 351px">
           
       <asp:CompareValidator ID="valNumbersOnly" runat="server"
    ControlToValidate="yöneticiTC"
    Operator="DataTypeCheck"
    Type="Integer"
    ErrorMessage="11 karakterli TC kimlik no giriniz.." TabIndex="0">11 karakterli TC kimlik no giriniz..</asp:CompareValidator>
                </td>
                <td style="width: 117px">
           
        <asp:Label ID="Label2" runat="server"  Text="Yönetici TC"></asp:Label>
           
                </td>
                <td>
           
        <asp:TextBox ID="yöneticiTC" runat="server" MaxLength="11" Rows="11"></asp:TextBox>
           
                </td>
            </tr>
            <tr>
                <td style="width: 351px">&nbsp;</td>
                <td style="width: 117px">
      
        <asp:Label ID="Label4" runat="server" Text="Yönetici Şifre"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="yöneticiSifre" runat="server" CssClass="col-md-offset-0" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 351px">&nbsp;</td>
                <td style="width: 117px">
      
        <asp:Label ID="Label5" runat="server" Text="Yönetici İsim"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="yöneticiisim" runat="server"></asp:TextBox>
                </td>
                <tr>
                <td style="width: 351px">

                </td>
                <td style="width: 117px">

        <asp:Label ID="Label6" runat="server" Text="Yönetici Soyisim"></asp:Label>

                </td>
                <td>

        <asp:TextBox ID="yöneticiSoyisim" runat="server"></asp:TextBox>

                </td>
                    </tr>
                <tr>
                <td style="width: 351px">

                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                    ControlToValidate="yöneticitelefon" ErrorMessage="Telefon Geçersizdir"
                                    SetFocusOnError="True" ></asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                                        ErrorMessage="Telefon Geçersizdir" ControlToValidate="yöneticitelefon"
                                        SetFocusOnError="True"
                                        ValidationExpression="(([\+]90?)|([0]?))([ ]?)((\([0-9]{3}\))|([0-9]{3}))([ ]?)([0-9]{3})(\s*[\-]?)([0-9]{2})(\s*[\-]?)([0-9]{2})">
        </asp:RegularExpressionValidator>

                </td>
                <td style="width: 117px">

        <asp:Label ID="Label7" runat="server" Text="Yönetici Telefon"></asp:Label>

                </td>
                <td>

        <asp:TextBox ID="yöneticiTelefon" runat="server"></asp:TextBox>
                </td>
                    </tr>
                <tr>
                <td style="width: 351px">

        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                        ErrorMessage="Email Geçersizdir" ControlToValidate="yöneticimail"
                                        SetFocusOnError="True"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
        </asp:RegularExpressionValidator>
      
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="yöneticimail" ErrorMessage="Email Geçersizdir"
                                    SetFocusOnError="True" ></asp:RequiredFieldValidator>

                </td>
                <td style="width: 117px">

        <asp:Label ID="Label8" runat="server" Text="Yönetici E-Mail"></asp:Label>

                </td>
                <td>

        <asp:TextBox ID="yöneticimail" runat="server"></asp:TextBox>

                </td>
                    </tr>
                <tr>
                <td style="width: 351px">

                </td>
                <td style="width: 117px">

        <asp:Label ID="Label9" runat="server" Text="Yönetici Konum İl"></asp:Label>

                </td>
                <td>

        <asp:DropDownList ID="yöneticikonum" runat="server">
           
                <asp:ListItem> Adana</asp:ListItem>
                <asp:ListItem>  Afyonkarahisar</asp:ListItem>
                <asp:ListItem>    Ağrı</asp:ListItem>
                <asp:ListItem>   Aksaray</asp:ListItem>
                <asp:ListItem>   Amasya</asp:ListItem>
                <asp:ListItem>   Ankara</asp:ListItem>
                <asp:ListItem>   Antalya</asp:ListItem>
                <asp:ListItem>   Ardahan</asp:ListItem>
                <asp:ListItem>   Artvin</asp:ListItem>
                <asp:ListItem>   Aydın</asp:ListItem>
                <asp:ListItem>   Balıkesir</asp:ListItem>
                <asp:ListItem>   Bartın</asp:ListItem>
                <asp:ListItem>  Batman</asp:ListItem>
                <asp:ListItem>  Bayburt</asp:ListItem>
                <asp:ListItem>  Bilecik</asp:ListItem>
                <asp:ListItem>Bingöl</asp:ListItem>
            <asp:ListItem>Bitlis</asp:ListItem>
            <asp:ListItem> Bolu</asp:ListItem>
            <asp:ListItem>  Burdur</asp:ListItem>
            <asp:ListItem>  Bursa</asp:ListItem>
            <asp:ListItem>  Çanakkale</asp:ListItem>
            <asp:ListItem>    Çankırı</asp:ListItem>
            <asp:ListItem>  Çorum</asp:ListItem>
            <asp:ListItem>  Denizli</asp:ListItem>
            <asp:ListItem>  Diyarbakır</asp:ListItem>
            <asp:ListItem>  Düzce</asp:ListItem>
            <asp:ListItem>   Edirne</asp:ListItem>
            <asp:ListItem>  Elazığ</asp:ListItem>
            <asp:ListItem>   Erzincan</asp:ListItem>
            <asp:ListItem>   Erzurum</asp:ListItem>
            <asp:ListItem>   Eskişehir</asp:ListItem>
            <asp:ListItem>  Gaziantep</asp:ListItem>
            <asp:ListItem>   Giresun</asp:ListItem>
                <asp:ListItem>   Gümüşhane</asp:ListItem>
            <asp:ListItem>  Hakkari</asp:ListItem>
            <asp:ListItem> Hatay</asp:ListItem>
            <asp:ListItem> Iğdır</asp:ListItem>
            <asp:ListItem> Isparta</asp:ListItem>
            <asp:ListItem> İstanbul</asp:ListItem>
            <asp:ListItem> İzmir</asp:ListItem>
            <asp:ListItem> Kahramanmaraş</asp:ListItem>
            <asp:ListItem> Karabük</asp:ListItem>
            <asp:ListItem>  Karaman</asp:ListItem>
            <asp:ListItem>  Kars</asp:ListItem>
            <asp:ListItem>  Kastamonu</asp:ListItem>
            <asp:ListItem>  Kayseri</asp:ListItem>
            <asp:ListItem> Kırıkkale</asp:ListItem>
            <asp:ListItem> Kırklareli</asp:ListItem>
            <asp:ListItem>  Kırşehir</asp:ListItem>
            <asp:ListItem>  Kilis</asp:ListItem>
            <asp:ListItem>  Kocaeli</asp:ListItem>
            <asp:ListItem>   Konya</asp:ListItem>
            <asp:ListItem>  Kütahya</asp:ListItem>
            <asp:ListItem>   Malatya</asp:ListItem>
            <asp:ListItem> Manisa</asp:ListItem>
            <asp:ListItem>  Mardin</asp:ListItem>
            <asp:ListItem>  Mersin</asp:ListItem>
            <asp:ListItem>  Muğla</asp:ListItem>
            <asp:ListItem> Muş</asp:ListItem>
            <asp:ListItem> Nevşehir</asp:ListItem>
            <asp:ListItem>    Niğde</asp:ListItem>
            <asp:ListItem>    Ordu</asp:ListItem>
            <asp:ListItem>    Osmaniye</asp:ListItem>
            <asp:ListItem>   Rize</asp:ListItem>
            <asp:ListItem>   Sakarya</asp:ListItem>
            <asp:ListItem>  Samsun</asp:ListItem>
            <asp:ListItem>   Siirt</asp:ListItem>
            <asp:ListItem>   Sinop</asp:ListItem>
            <asp:ListItem>   Sivas</asp:ListItem>
            <asp:ListItem>  Şanlıurfa</asp:ListItem>
            <asp:ListItem>  Şırnak</asp:ListItem>
            <asp:ListItem>  Tekirdağ</asp:ListItem>
            <asp:ListItem>   Tokat</asp:ListItem>
            <asp:ListItem>   Trabzon</asp:ListItem>
            <asp:ListItem>   Tunceli</asp:ListItem>
            <asp:ListItem>  Uşak</asp:ListItem>
            <asp:ListItem>   Van</asp:ListItem>
            <asp:ListItem>   Yalova</asp:ListItem>
            <asp:ListItem>  Yozgat</asp:ListItem>
            <asp:ListItem>  Zonguldak</asp:ListItem>
        </asp:DropDownList>
        
                </td>
                    </tr>
                
                <td>

                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Yönetici Ekle" OnClick="Button1_Click" />
                </td>
                <td>

                </td>
                    </tr>

        </table>
        <asp:Label ID="Label10" runat="server" Text="Label" Visible="False"></asp:Label>
        <br/>
        <br/>
           
        <br/>
        <br/>
      
        <br/>
        <br/>
      
        <br/>
        <br/>
      
        <br/>
        <br/>
      
        <br/>
        <br/>
      
        <br/>
        <br/>
      
        <br/>
        
        <br/>
         
        
       
    </div>
</asp:Content>
