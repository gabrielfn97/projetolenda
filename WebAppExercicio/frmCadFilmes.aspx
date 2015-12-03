<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadFilmes.aspx.cs" Inherits="WebAppExercicio.frmCadFilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Nome do Filme:
        <asp:TextBox ID="txtNomeFilme" runat="server"></asp:TextBox>
        <br />
        Classificação:
        <asp:TextBox ID="txtClassificacao" runat="server"></asp:TextBox>
        <br />
        Gênero:
        <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
        <br />
        Iframe Youtube:
        <asp:TextBox ID="txtIframe" runat="server"></asp:TextBox>
        <br />
        URL Imagem:
        <asp:TextBox ID="txtURLImagem" runat="server"></asp:TextBox>
        <br />
        Nota:
        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
        <br />
        Data de Lançamento:
        <asp:TextBox ID="txtDataLacamento" runat="server"></asp:TextBox>
        <br />
        Atores Principais:
        <asp:TextBox ID="txtAtoresPrincipais" runat="server"></asp:TextBox>
        <br />
        Nacionalidade:
        <asp:TextBox ID="txtNacionalidade" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />
&nbsp;<asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" style="height: 29px" />
&nbsp;<asp:Button ID="btnApagar" runat="server" Text="Apagar" OnClick="btnApagar_Click" />
&nbsp;<asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
&nbsp;<asp:Button ID="btnCartaz" runat="server" Text="Cartaz" />
    
        <br />
    
    </div>
        <asp:GridView ID="gdvCadFilmes" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" Height="178px" PageSize="5" Width="239px">
        </asp:GridView>
    </form>
</body>
</html>
