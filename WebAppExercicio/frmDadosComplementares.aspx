<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDadosComplementares.aspx.cs" Inherits="WebAppExercicio.frmDadosComplementares" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Dados Complementares"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="idDadosComplementares :" Visible="False"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtidDadosComplementares" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Endereço :"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Telefone :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Bairro :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Estado Civil :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtEstadoCivil" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Imagem Perfil  URL:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtImgPerfilUrl" runat="server" Height="16px"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Data Nascimento :"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Sexo :"></asp:Label>
&nbsp;<asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inserir" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Alterar" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Apagar" />
        <br />
        <br />
        <asp:GridView ID="gdvDadosComplementares" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gdvDadosComplementares_SelectedIndexChanged">
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
    
    </div>
    </form>
</body>
</html>
