<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppExercicio.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/figuras/1.jpg" Width="110px" />
        <br />
        <asp:ImageButton ID="btn1" runat="server" AlternateText="1" Height="20px" ImageUrl="~/figuras/estrela.jpg" OnClick="ImageButton1_Click" Width="20px" />
        <asp:ImageButton ID="btn2" runat="server" AlternateText="2" Height="20px" ImageUrl="~/figuras/estrela.jpg" OnClick="btn2_Click" Width="20px" />
        <asp:ImageButton ID="btn3" runat="server" AlternateText="3" Height="20px" ImageUrl="~/figuras/estrela.jpg" OnClick="btn3_Click" Width="20px" />
        <asp:ImageButton ID="btn4" runat="server" AlternateText="4" Height="20px" ImageUrl="~/figuras/estrela.jpg" OnClick="btn4_Click" Width="20px" />
        <asp:ImageButton ID="btn5" runat="server" AlternateText="5" Height="20px" ImageUrl="~/figuras/estrela.jpg" OnClick="btn5_Click" Width="20px" />
        <br />
        <asp:HiddenField ID="txtidfilme" runat="server" Value="1" />
    
    </div>
    </form>
</body>
</html>
