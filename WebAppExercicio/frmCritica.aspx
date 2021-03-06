﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCritica.aspx.cs" Inherits="WebAppExercicio.frmCritica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="PORTAL DE CRITICAS"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="idCritica" Visible="False"></asp:Label>
        <asp:TextBox ID="txtidCritica" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
    
    </div>
        <asp:Label ID="Label3" runat="server" Text="Data:"></asp:Label>
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Critica:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCritica" runat="server" Height="93px" Width="486px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inserir" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Alterar" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Apagar" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Ultimas Criticas" />
        <br />
        <br />
        <br />
        <asp:GridView ID="gdvCadCritica" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gdvCadCritica_SelectedIndexChanged" AutoGenerateSelectButton="True">
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
        <br />
    </form>
</body>
</html>
