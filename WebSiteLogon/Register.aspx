<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebSiteLogon.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td colspan="2"><hr />Cadastrar Novo usuário<hr /></td></tr>
                <tr><td><asp:Label runat="server" ID="LabelError" ForeColor="Red"></asp:Label></td></tr>
                <tr><td>Nome de Usuário</td><td><asp:TextBox runat="server" ID="txtUser"></asp:TextBox></td></tr>
                <tr><td>Senha</td><td><asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox></td></tr>
                <tr><td>Confirmar Senha</td><td><asp:TextBox runat="server" ID="txtConfirmPassword"></asp:TextBox></td></tr>
                <tr><td><asp:Button runat="server" ID="btnConfirma" Text="Registrar" OnClick="btnConfirma_Click"/></tr>
            </table>
        </div>
    </form>
</body>
</html>
