<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Akshay_06_task2.WebForm1" %>

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
                    <td>
                        <asp:FileUpload runat="server" ID="fupload" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="IName" Text="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" text="submit" ID="submit" OnClick="submit_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
