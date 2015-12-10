<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadEstado.aspx.cs" Inherits="WebAppExercicio.frmCadEstado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 98px">
    
        <asp:Label ID="Label3" runat="server" Text="IdCadEstado" Visible="False"></asp:Label>
        <asp:TextBox ID="txtidCadEstado" runat="server" Visible="False" Width="26px"></asp:TextBox>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Estado:"></asp:Label>
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sigla:"></asp:Label>
        <asp:TextBox ID="txtSigla" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        <asp:Button ID="btnApagar" runat="server" Text="Apagar" OnClick="btnApagar_Click" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
    
    </div>
        <asp:GridView ID="gdvCadEstado" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="188px" PageSize="5" Width="232px" OnSelectedIndexChanged="gdvCadEstado_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </form>
</body>
</html>
