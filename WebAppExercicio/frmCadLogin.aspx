<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadLogin.aspx.cs" Inherits="WebAppExercicio.frmCadLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Usuário:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <asp:Button ID="Button4" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
