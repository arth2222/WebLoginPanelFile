<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LagMeny.aspx.cs" Inherits="WebLoginPanelFile.LagMeny" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LagMeny</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tast passord: <asp:TextBox ID="TextBoxPassWord" runat="server"></asp:TextBox><br />
            <asp:Button ID="ButtonLogin" runat="server" Text="LogIn" OnClick="ButtonLogin_Click" />


            <asp:Panel ID="Panel1" runat="server" Visible="false">

                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="ButtonLagreMeny" runat="server" Text="Lagre" OnClick="ButtonLagreMeny_Click" />

            </asp:Panel>


        </div>
    </form>
</body>
</html>
