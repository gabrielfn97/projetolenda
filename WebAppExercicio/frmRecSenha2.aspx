<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRecSenha2.aspx.cs" Inherits="WebAppExercicio.frmRecSenha2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Digite seu Usuario e sua nova senha:<br />
    
        <br />
        <asp:Label ID="Label4" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label3" runat="server" Text="idCadLogin: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtidCadLogin" runat="server" Visible="False"></asp:TextBox>
&nbsp;<br />
        <asp:Label ID="Label1" runat="server" Text="Digite sua nova senha: "></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRecSenha" runat="server" OnClick="btnRecSenha_Click" Text="Redefinir senha" />
    
    </div>
    </form>
</body>
</html>
