﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGeneros.aspx.cs" Inherits="WebAppExercicio.frmcategoriasfilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;<asp:Label ID="Label2" runat="server" Text="idGeneros" Visible="False"></asp:Label>
        <asp:TextBox ID="txtidGeneros" runat="server" Visible="False"></asp:TextBox>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Generos:"></asp:Label>
        <asp:TextBox ID="txtGeneros" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
    
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
    
        <asp:Button ID="btnApagar" runat="server" OnClick="btnApagar_Click" Text="Apagar" />
    
        <br />
    
    </div>
        <asp:GridView ID="gdvGeneros" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="16px" PageSize="5" Width="16px" OnSelectedIndexChanged="gdvGeneros_SelectedIndexChanged">
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
