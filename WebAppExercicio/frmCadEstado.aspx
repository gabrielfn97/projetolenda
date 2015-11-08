<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadEstado.aspx.cs" Inherits="WebAppExercicio.frmCadEstado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 145px">
    
        <asp:Label ID="Label1" runat="server" Text="Estado:"></asp:Label>
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sigla:"></asp:Label>
        <asp:TextBox ID="txtSigla" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        <asp:Button ID="btnDeletar" runat="server" Text="Deletar" />
        <asp:Button ID="btnConsutar" runat="server" Text="Consutar" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
    
    </div>
    </form>
</body>
</html>
