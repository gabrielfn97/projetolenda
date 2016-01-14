<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCidade.aspx.cs" Inherits="WebAppExercicio.frmCadCidade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="idCadCidade: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtidCadCidade" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Estado: "></asp:Label>
        <asp:DropDownList ID="cboEstado" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cidade: "></asp:Label>
        <asp:TextBox ID="txtcidade" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
&nbsp;<asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
&nbsp;<asp:Button ID="btnApagar" runat="server" OnClick="btnApagar_Click" Text="Apagar" />
    
    </div>
        <asp:GridView ID="gdvCadCidade" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True">
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
    &nbsp;</form>
</body>
</html>
