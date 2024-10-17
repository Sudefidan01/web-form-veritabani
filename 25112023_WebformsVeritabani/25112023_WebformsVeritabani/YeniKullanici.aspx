<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="YeniKullanici.aspx.cs" Inherits="_25112023_WebformsVeritabani.YeniKullanici" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Kullanıcı Ekle</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Kullanıcı Ekle</h1>
    <hr />
    <table>
        <tr>
            <td>Ad</td>
            <td>
                <asp:TextBox ID="txtAd" runat="server" required="required"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Soyad</td>
            <td>
                <asp:TextBox ID="txtSoyad" runat="server" required="required"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="txtKullAdi" runat="server" required="required"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Parola</td>
            <td>
                <asp:TextBox ID="txtParola" runat="server" required="required"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Durum</td>
            <td>
                <asp:CheckBox ID="chkDurum" runat="server" Text="Aktif" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnGuncelle" runat="server" Text="Kaydet" Width="125px" OnClick="btnGuncelle_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="lblBilgi" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
