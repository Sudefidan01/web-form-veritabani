<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KullaniciListesi.aspx.cs" Inherits="_25112023_WebformsVeritabani.KullaniciListesi" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Kullanıcı Listesi</title>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Kullanıcı Listesi</h1>
    <hr />
    <asp:Button ID="btnEkle" runat="server" Text="Kullanıcı Ekle" OnClick="btnEkle_Click" />
    <hr />
    <asp:Repeater ID="rptListe" runat="server">
        <HeaderTemplate>
            <table class="liste">
                <thead>
                <tr>
                    <th>Ad</th>
                    <th>Soyad</th>
                    <th>Kullanıcı Adı</th>
                    <th>Durum</th>
                    <th>İşlemler</th>
                </tr>
            </thead>
             <tbody>

            
        </HeaderTemplate>
        <%-- --------- --%>
        <ItemTemplate>
            <tr>
                <td><%#Eval("Ad") %></td>
                <td><%#Eval("Soyad") %></td>
                <td><%#Eval("KullaniciAdi") %></td>
                <td><%#Eval("Durum") %></td>
                <td>
                    <a href="KisiDuzenle.aspx?id=<%#Eval("id") %>">Düzenle</a>
                    <a href="#">Sil</a>
                </td>

            </tr>

        </ItemTemplate>
        <FooterTemplate>

                </tbody>
            </table>
        </FooterTemplate>



    </asp:Repeater>
</asp:Content>
