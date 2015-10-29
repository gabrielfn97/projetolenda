<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadPessoa.aspx.cs" Inherits="WebAppExercicio.frmCadPessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="CPF:"></asp:Label>
        <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Data de Nascimento:"></asp:Label>
        <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <asp:Button ID="Button4" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
