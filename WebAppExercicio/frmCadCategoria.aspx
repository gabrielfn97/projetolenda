﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadCategoria.aspx.cs" Inherits="WebAppExercicio.frmCadCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Classificação de Idade: "></asp:Label>
        <asp:TextBox ID="txtdescricao" runat="server"></asp:TextBox>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Label ID="Label3" runat="server" Text="idCategoria: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtidCategoria" runat="server" Visible="False"></asp:TextBox>
        <br />
    
        <br />
        <asp:Button ID="btnInserir" runat="server"  Text="Inserir" OnClick="btnInserir_Click1" />
    
        &nbsp;<asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click1" />
    
        &nbsp;<asp:Button ID="btnApagar" runat="server" Text="Apagar" OnClick="btnApagar_Click1" />
    
        <br />
    
    </div>
        <asp:GridView ID="gdvCadCategoria" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="42px" Width="18px" OnSelectedIndexChanged="gdvCadCategoria_SelectedIndexChanged1">
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
