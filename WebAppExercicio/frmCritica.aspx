<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCritica.aspx.cs" Inherits="WebAppExercicio.frmCritica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="PORTAL DE CRITICAS"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="idCritica" Visible="False"></asp:Label>
        <asp:TextBox ID="txtidCritica" runat="server" Visible="False"></asp:TextBox>
        <br />
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
    
    </div>
        <asp:Label ID="Label3" runat="server" Text="Data:"></asp:Label>
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Critica:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtCritica" runat="server" Height="93px" Width="486px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inserir" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Alterar" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Apagar" />
        <br />
        <br />
        <br />
        <asp:GridView ID="gdvCadCritica" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gdvCadCritica_SelectedIndexChanged">
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
