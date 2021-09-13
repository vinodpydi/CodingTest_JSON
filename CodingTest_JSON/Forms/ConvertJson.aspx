<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvertJson.aspx.cs" Inherits="CodingTest_JSON.Forms.ConvertJson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFirstname" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" ></asp:TextBox>
            <asp:Label ID="lblLastname" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
        </div>
    </form>
</body>
</html>
