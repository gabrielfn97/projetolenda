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
    
        <asp:Label ID="Label1" runat="server" Text="idFilmes: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtidFilmes" runat="server" Visible="False"></asp:TextBox>
        <br />
    
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
&nbsp;<asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="47px" OnClick="btnAlterar_Click" />
&nbsp;<asp:Button ID="btnApagar" runat="server" Text="Apagar" OnClick="btnApagar_Click1"  />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Listar Todos Filmes" />
    
        <br />
    
    </div>
        <asp:GridView ID="gdvCadFilmes" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" Height="59px" Width="77px" OnSelectedIndexChanged="gdvCadFilmes_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
