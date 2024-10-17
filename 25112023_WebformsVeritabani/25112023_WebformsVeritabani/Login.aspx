<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_25112023_WebformsVeritabani.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş</title>
    <link href="site.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="uyeGiris">
            <h2>Üye Girişi</h2>
            <table>
                <tr>
                    <td><b>Kullanıcı Adı</b></td>
                    <td>
                        <asp:TextBox ID="txtKullanici" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><b>Parola</b></td>
                    <td>
                        <asp:TextBox ID="txtParola" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" Width="126px" OnClick="btnGiris_Click" />
                    </td>
                </tr>

            </table>
            <asp:Label ID="lblBilgi" runat="server" ></asp:Label>

        </div>
    </form>
</body>
</html>
