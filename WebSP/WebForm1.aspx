<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebSP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="4">
                        <b>Search Person</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNameLike" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <b>Salary > </b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSalaryGreaterThan" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="btnSerach" runat="server" Text="Search"
                            OnClick="btnSerach_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:GridView ID="gvEmployees" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
