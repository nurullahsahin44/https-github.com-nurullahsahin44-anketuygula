﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace anketUygula.WebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.dahafazlaoku.com/WebService1.asmx", ConfigurationName="WebService.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/userSorgula", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string userSorgula(string Eposta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/userSorgula", ReplyAction="*")]
        System.Threading.Tasks.Task<string> userSorgulaAsync(string Eposta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool login(string Email, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/login", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> loginAsync(string Email, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/AddUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddUser(string Adi, string Soyadi, string Email, string KanGrubu, string Telefon, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/AddUser", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddUserAsync(string Adi, string Soyadi, string Email, string KanGrubu, string Telefon, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/IlanEkle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool IlanEkle(int ilanSahabiId, string hastaAdiSoyadi, int hastayasi, string hastaBilgi, string hastaneil, string hastaneAd, string HastaTelefon, string hastaKangrubu, int uniteSayisi, int ilanSuresi, string konum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/IlanEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> IlanEkleAsync(int ilanSahabiId, string hastaAdiSoyadi, int hastayasi, string hastaBilgi, string hastaneil, string hastaneAd, string HastaTelefon, string hastaKangrubu, int uniteSayisi, int ilanSuresi, string konum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/UserGuncelle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool UserGuncelle(int ID, string Adi, string Soyadi, string Telefon, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/UserGuncelle", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> UserGuncelleAsync(int ID, string Adi, string Soyadi, string Telefon, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/userGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string userGetir(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/userGetir", ReplyAction="*")]
        System.Threading.Tasks.Task<string> userGetirAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/izinSorgula", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string izinSorgula(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/izinSorgula", ReplyAction="*")]
        System.Threading.Tasks.Task<string> izinSorgulaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/izinGuncelle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool izinGuncelle(int ID, int konum, int numara, int bildirim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/izinGuncelle", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> izinGuncelleAsync(int ID, int konum, int numara, int bildirim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/izinEkle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool izinEkle(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/izinEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> izinEkleAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/ilanGetirr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ilanGetirr(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/ilanGetirr", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ilanGetirrAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/TumilanlariGetirr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string TumilanlariGetirr(string il);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/TumilanlariGetirr", ReplyAction="*")]
        System.Threading.Tasks.Task<string> TumilanlariGetirrAsync(string il);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/KonumEkle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool KonumEkle(int UserId, string konumUlke, string konumIl, string konumMahalle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/KonumEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> KonumEkleAsync(int UserId, string konumUlke, string konumIl, string konumMahalle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/hastaneGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string hastaneGetir(string il);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/hastaneGetir", ReplyAction="*")]
        System.Threading.Tasks.Task<string> hastaneGetirAsync(string il);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/ilanSil", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ilanSil(int ilanID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/ilanSil", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ilanSilAsync(int ilanID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/EpostaGonder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool EpostaGonder(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/EpostaGonder", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EpostaGonderAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/EmailKontrolEt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool EmailKontrolEt(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/EmailKontrolEt", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EmailKontrolEtAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/TelefonIDEkle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool TelefonIDEkle(int UserId, string telefonID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/TelefonIDEkle", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> TelefonIDEkleAsync(int UserId, string telefonID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/sendNotification", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool sendNotification(string il, string Hastane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/sendNotification", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> sendNotificationAsync(string il, string Hastane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/sendSozNotification", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void sendSozNotification();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/sendSozNotification", ReplyAction="*")]
        System.Threading.Tasks.Task sendSozNotificationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/telefonGonder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string telefonGonder(int markaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/telefonGonder", ReplyAction="*")]
        System.Threading.Tasks.Task<string> telefonGonderAsync(int markaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool anketLogin(string KullaniciAdi, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> anketLoginAsync(string KullaniciAdi, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketAdminLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool anketAdminLogin(string KullaniciAdi, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketAdminLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> anketAdminLoginAsync(string KullaniciAdi, string Parola);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketWebYoneticiAdd", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool anketWebYoneticiAdd(string tc, string sifre, string isim, string soyisim, string telefon, string mail, string konum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketWebYoneticiAdd", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> anketWebYoneticiAddAsync(string tc, string sifre, string isim, string soyisim, string telefon, string mail, string konum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketYoneticiTumListe", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string anketYoneticiTumListe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/anketYoneticiTumListe", ReplyAction="*")]
        System.Threading.Tasks.Task<string> anketYoneticiTumListeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/SoruGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SoruGetir(int SoruId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/SoruGetir", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SoruGetirAsync(int SoruId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/soruIDgonder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string soruIDgonder(int soruSeviye);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.dahafazlaoku.com/WebService1.asmx/soruIDgonder", ReplyAction="*")]
        System.Threading.Tasks.Task<string> soruIDgonderAsync(int soruSeviye);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : anketUygula.WebService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<anketUygula.WebService.WebService1Soap>, anketUygula.WebService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string userSorgula(string Eposta) {
            return base.Channel.userSorgula(Eposta);
        }
        
        public System.Threading.Tasks.Task<string> userSorgulaAsync(string Eposta) {
            return base.Channel.userSorgulaAsync(Eposta);
        }
        
        public bool login(string Email, string Parola) {
            return base.Channel.login(Email, Parola);
        }
        
        public System.Threading.Tasks.Task<bool> loginAsync(string Email, string Parola) {
            return base.Channel.loginAsync(Email, Parola);
        }
        
        public bool AddUser(string Adi, string Soyadi, string Email, string KanGrubu, string Telefon, string Parola) {
            return base.Channel.AddUser(Adi, Soyadi, Email, KanGrubu, Telefon, Parola);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAsync(string Adi, string Soyadi, string Email, string KanGrubu, string Telefon, string Parola) {
            return base.Channel.AddUserAsync(Adi, Soyadi, Email, KanGrubu, Telefon, Parola);
        }
        
        public bool IlanEkle(int ilanSahabiId, string hastaAdiSoyadi, int hastayasi, string hastaBilgi, string hastaneil, string hastaneAd, string HastaTelefon, string hastaKangrubu, int uniteSayisi, int ilanSuresi, string konum) {
            return base.Channel.IlanEkle(ilanSahabiId, hastaAdiSoyadi, hastayasi, hastaBilgi, hastaneil, hastaneAd, HastaTelefon, hastaKangrubu, uniteSayisi, ilanSuresi, konum);
        }
        
        public System.Threading.Tasks.Task<bool> IlanEkleAsync(int ilanSahabiId, string hastaAdiSoyadi, int hastayasi, string hastaBilgi, string hastaneil, string hastaneAd, string HastaTelefon, string hastaKangrubu, int uniteSayisi, int ilanSuresi, string konum) {
            return base.Channel.IlanEkleAsync(ilanSahabiId, hastaAdiSoyadi, hastayasi, hastaBilgi, hastaneil, hastaneAd, HastaTelefon, hastaKangrubu, uniteSayisi, ilanSuresi, konum);
        }
        
        public bool UserGuncelle(int ID, string Adi, string Soyadi, string Telefon, string Parola) {
            return base.Channel.UserGuncelle(ID, Adi, Soyadi, Telefon, Parola);
        }
        
        public System.Threading.Tasks.Task<bool> UserGuncelleAsync(int ID, string Adi, string Soyadi, string Telefon, string Parola) {
            return base.Channel.UserGuncelleAsync(ID, Adi, Soyadi, Telefon, Parola);
        }
        
        public string userGetir(int ID) {
            return base.Channel.userGetir(ID);
        }
        
        public System.Threading.Tasks.Task<string> userGetirAsync(int ID) {
            return base.Channel.userGetirAsync(ID);
        }
        
        public string izinSorgula(int ID) {
            return base.Channel.izinSorgula(ID);
        }
        
        public System.Threading.Tasks.Task<string> izinSorgulaAsync(int ID) {
            return base.Channel.izinSorgulaAsync(ID);
        }
        
        public bool izinGuncelle(int ID, int konum, int numara, int bildirim) {
            return base.Channel.izinGuncelle(ID, konum, numara, bildirim);
        }
        
        public System.Threading.Tasks.Task<bool> izinGuncelleAsync(int ID, int konum, int numara, int bildirim) {
            return base.Channel.izinGuncelleAsync(ID, konum, numara, bildirim);
        }
        
        public bool izinEkle(int ID) {
            return base.Channel.izinEkle(ID);
        }
        
        public System.Threading.Tasks.Task<bool> izinEkleAsync(int ID) {
            return base.Channel.izinEkleAsync(ID);
        }
        
        public string ilanGetirr(int ID) {
            return base.Channel.ilanGetirr(ID);
        }
        
        public System.Threading.Tasks.Task<string> ilanGetirrAsync(int ID) {
            return base.Channel.ilanGetirrAsync(ID);
        }
        
        public string TumilanlariGetirr(string il) {
            return base.Channel.TumilanlariGetirr(il);
        }
        
        public System.Threading.Tasks.Task<string> TumilanlariGetirrAsync(string il) {
            return base.Channel.TumilanlariGetirrAsync(il);
        }
        
        public bool KonumEkle(int UserId, string konumUlke, string konumIl, string konumMahalle) {
            return base.Channel.KonumEkle(UserId, konumUlke, konumIl, konumMahalle);
        }
        
        public System.Threading.Tasks.Task<bool> KonumEkleAsync(int UserId, string konumUlke, string konumIl, string konumMahalle) {
            return base.Channel.KonumEkleAsync(UserId, konumUlke, konumIl, konumMahalle);
        }
        
        public string hastaneGetir(string il) {
            return base.Channel.hastaneGetir(il);
        }
        
        public System.Threading.Tasks.Task<string> hastaneGetirAsync(string il) {
            return base.Channel.hastaneGetirAsync(il);
        }
        
        public bool ilanSil(int ilanID) {
            return base.Channel.ilanSil(ilanID);
        }
        
        public System.Threading.Tasks.Task<bool> ilanSilAsync(int ilanID) {
            return base.Channel.ilanSilAsync(ilanID);
        }
        
        public bool EpostaGonder(string Email) {
            return base.Channel.EpostaGonder(Email);
        }
        
        public System.Threading.Tasks.Task<bool> EpostaGonderAsync(string Email) {
            return base.Channel.EpostaGonderAsync(Email);
        }
        
        public bool EmailKontrolEt(string Email) {
            return base.Channel.EmailKontrolEt(Email);
        }
        
        public System.Threading.Tasks.Task<bool> EmailKontrolEtAsync(string Email) {
            return base.Channel.EmailKontrolEtAsync(Email);
        }
        
        public bool TelefonIDEkle(int UserId, string telefonID) {
            return base.Channel.TelefonIDEkle(UserId, telefonID);
        }
        
        public System.Threading.Tasks.Task<bool> TelefonIDEkleAsync(int UserId, string telefonID) {
            return base.Channel.TelefonIDEkleAsync(UserId, telefonID);
        }
        
        public bool sendNotification(string il, string Hastane) {
            return base.Channel.sendNotification(il, Hastane);
        }
        
        public System.Threading.Tasks.Task<bool> sendNotificationAsync(string il, string Hastane) {
            return base.Channel.sendNotificationAsync(il, Hastane);
        }
        
        public void sendSozNotification() {
            base.Channel.sendSozNotification();
        }
        
        public System.Threading.Tasks.Task sendSozNotificationAsync() {
            return base.Channel.sendSozNotificationAsync();
        }
        
        public string telefonGonder(int markaID) {
            return base.Channel.telefonGonder(markaID);
        }
        
        public System.Threading.Tasks.Task<string> telefonGonderAsync(int markaID) {
            return base.Channel.telefonGonderAsync(markaID);
        }
        
        public bool anketLogin(string KullaniciAdi, string Parola) {
            return base.Channel.anketLogin(KullaniciAdi, Parola);
        }
        
        public System.Threading.Tasks.Task<bool> anketLoginAsync(string KullaniciAdi, string Parola) {
            return base.Channel.anketLoginAsync(KullaniciAdi, Parola);
        }
        
        public bool anketAdminLogin(string KullaniciAdi, string Parola) {
            return base.Channel.anketAdminLogin(KullaniciAdi, Parola);
        }
        
        public System.Threading.Tasks.Task<bool> anketAdminLoginAsync(string KullaniciAdi, string Parola) {
            return base.Channel.anketAdminLoginAsync(KullaniciAdi, Parola);
        }
        
        public bool anketWebYoneticiAdd(string tc, string sifre, string isim, string soyisim, string telefon, string mail, string konum) {
            return base.Channel.anketWebYoneticiAdd(tc, sifre, isim, soyisim, telefon, mail, konum);
        }
        
        public System.Threading.Tasks.Task<bool> anketWebYoneticiAddAsync(string tc, string sifre, string isim, string soyisim, string telefon, string mail, string konum) {
            return base.Channel.anketWebYoneticiAddAsync(tc, sifre, isim, soyisim, telefon, mail, konum);
        }
        
        public string anketYoneticiTumListe() {
            return base.Channel.anketYoneticiTumListe();
        }
        
        public System.Threading.Tasks.Task<string> anketYoneticiTumListeAsync() {
            return base.Channel.anketYoneticiTumListeAsync();
        }
        
        public string SoruGetir(int SoruId) {
            return base.Channel.SoruGetir(SoruId);
        }
        
        public System.Threading.Tasks.Task<string> SoruGetirAsync(int SoruId) {
            return base.Channel.SoruGetirAsync(SoruId);
        }
        
        public string soruIDgonder(int soruSeviye) {
            return base.Channel.soruIDgonder(soruSeviye);
        }
        
        public System.Threading.Tasks.Task<string> soruIDgonderAsync(int soruSeviye) {
            return base.Channel.soruIDgonderAsync(soruSeviye);
        }
    }
}
