<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGeneros.aspx.cs" Inherits="WebAppExercicio.frmcategoriasfilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Generos:"></asp:Label>
        <asp:TextBox ID="txtGeneros" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
    
    </div>
    </form>
</body>
</html>
