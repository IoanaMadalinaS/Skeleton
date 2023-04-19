
<!DOCTYPE html>
<script runat="server">

    Protected Sub btnOK_Click1(sender As Object, e As EventArgs)

    End Sub
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Customer Viewer</title>
</head>
<body>

<form id="form1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 93px; top: 13px; position: absolute; width: 220px"></asp:TextBox>
    <p>
        <asp:Label ID="lblFirstname" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 615px" Text="Firstname"></asp:Label>
        <asp:Label ID="lblLastname" runat="server" style="z-index: 1; left: 10px; top: 57px; position: absolute; width: 87px" Text="Lastname"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 93px; top: 57px; position: absolute; width: 221px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 93px; top: 34px; position: absolute; width: 222px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblDateofBirth" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 94px; top: 79px; position: absolute; width: 220px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="IblCustomer_ID" runat="server" style="z-index: 1; left: 9px; top: 13px; position: absolute; height: 13px; width: 111px; right: 518px; bottom: 636px; margin-top: 0px" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 94px; top: 101px; position: absolute; width: 221px; margin-bottom: 0px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 95px; top: 125px; position: absolute; width: 221px"></asp:TextBox>
    </p>
    <asp:Label ID="IblEmail" runat="server" style="z-index: 1; left: 10px; top: 101px; position: absolute; width: 86px" Text="Email"></asp:Label>
    <p>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 128px; position: absolute" Text="Address"></asp:Label>
        <asp:CheckBox ID="ChkActive" runat="server" style="z-index: 1; left: 7px; top: 158px; position: absolute; width: 307px" Text="Active" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 191px; position: absolute" Text="[IblError]"></asp:Label>
    </p>
    <p style="width: 351px; margin-left: 0px">
        <asp:Button ID="btnCANCEL" runat="server" style="z-index: 1; left: 67px; top: 224px; position: absolute" Text="Cancel" OnClick="btnCANCEL_Click" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 10px; top: 224px; position: absolute; right: 704px" Text="OK" />
    </p>
</form>
</body>
</html>

