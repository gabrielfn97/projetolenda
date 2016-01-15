<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadNoticia.aspx.cs" Inherits="WebAppExercicio.frmCadNoticia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        #Select1 {
            width: 111px;
        }
        #txtTipoNoticia {
            width: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label5" runat="server" Text="CADASTRO DE NOTICIAS    "></asp:Label>
    
        <asp:Label ID="Label1" runat="server" Text="idNoticia" Visible="False"></asp:Label>
        <asp:TextBox ID="txtidNoticia" runat="server" Visible="False"></asp:TextBox>
        <br />
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Noticia: "></asp:Label>
        <br />
        <asp:TextBox ID="txtNoticia" runat="server" Height="142px" Width="500px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Data: "></asp:Label>
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label4" runat="server" Text="Tipo Notícia: "></asp:Label>
        <asp:DropDownList ID="cboTipoNoticia" runat="server">
            <asp:ListItem>Selecione</asp:ListItem>
            <asp:ListItem Value="cinema">Cinema</asp:ListItem>
            <asp:ListItem Value="site">Site</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        :&nbsp;
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="Button1_Click" Text="Inserir" />
&nbsp;<asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
&nbsp;<asp:Button ID="btnApagar" runat="server" OnClick="Button3_Click" Text="Apagar" />
    
    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Lista Todas as Noticias" />
    
    &nbsp;<asp:Button ID="ltNoticiasCinema" runat="server" OnClick="ltNoticiasCinema_Click" Text="Lista Noticias Cinema" />
        <br />
    
    </div>
        <asp:GridView ID="gdvCadNoticia" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
