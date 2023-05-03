<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Customer Viewer</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 191px;
            top: 13px;
            position: absolute;
            width: 220px;
        }
        .auto-style2 {
            z-index: 1;
            left: 196px;
            top: 88px;
            position: absolute;
            width: 222px;
        }
        .auto-style3 {
            z-index: 1;
            left: 10px;
            top: 94px;
            position: absolute;
            width: 87px;
        }
        .auto-style4 {
            z-index: 1;
            left: 29px;
            top: 343px;
            position: absolute;
            right: 906px;
        }
        .auto-style5 {
            z-index: 1;
            left: 97px;
            top: 343px;
            position: absolute;
            height: 35px;
        }
        .auto-style6 {
            z-index: 1;
            left: 10px;
            top: 289px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 7px;
            top: 52px;
            position: absolute;
            bottom: 785px;
        }
        .auto-style8 {
            z-index: 1;
            left: 7px;
            top: 253px;
            position: absolute;
            width: 307px;
        }
        .auto-style9 {
            z-index: 1;
            left: 10px;
            top: 213px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 192px;
            top: 211px;
            position: absolute;
            width: 221px;
        }
        .auto-style11 {
            z-index: 1;
            left: 10px;
            top: 179px;
            position: absolute;
            width: 86px;
        }
        .auto-style12 {
            z-index: 1;
            left: 190px;
            top: 167px;
            position: absolute;
            width: 221px;
        }
        .auto-style13 {
            z-index: 1;
            left: 10px;
            top: 135px;
            position: absolute;
        }
        .auto-style14 {
            z-index: 1;
            left: 191px;
            top: 121px;
            position: absolute;
            width: 220px;
        }
        .auto-style15 {
            z-index: 1;
            left: 192px;
            top: 47px;
            position: absolute;
            width: 221px;
        }
        .auto-style16 {
            z-index: 1;
            left: 9px;
            top: 13px;
            position: absolute;
            height: 13px;
            width: 153px;
            right: 894px;
            bottom: 849px;
        }
        .auto-style17 {
            z-index: 1;
            left: 427px;
            top: 17px;
            position: absolute;
        }
    </style>
</head>
<body>

<form id="form1" runat="server">
        <asp:TextBox ID="txtCustomer_ID" runat="server" CssClass="auto-style1"></asp:TextBox>
    <p>
        <asp:Label ID="lblFirstname" runat="server" Text="Firstname" CssClass="auto-style7"></asp:Label>
        <asp:Label ID="lblLastname" runat="server" Text="Lastname" CssClass="auto-style3"></asp:Label>
        <asp:TextBox ID="txtFirstname" runat="server" CssClass="auto-style15"></asp:TextBox>
        <asp:TextBox ID="txtLastname" runat="server" CssClass="auto-style2"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblDateofBirth" runat="server" Text="Date of Birth" CssClass="auto-style13"></asp:Label>
        <asp:TextBox ID="txtDate_of_Birth" runat="server" CssClass="auto-style14"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="IblCustomer_ID" runat="server" style="margin-top: 0px" Text="Customer ID" CssClass="auto-style16"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-bottom: 0px" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style10"></asp:TextBox>
    </p>
    <asp:Label ID="IblEmail" runat="server" Text="Email" CssClass="auto-style11"></asp:Label>
    <p>
        <asp:Label ID="lblAddress" runat="server" Text="Address" CssClass="auto-style9"></asp:Label>
        <asp:CheckBox ID="ChkActive" runat="server" Text="Active" CssClass="auto-style8" />
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="[IblError]" CssClass="auto-style6"></asp:Label>
    </p>
    <p style="width: 351px; margin-left: 0px">
        <asp:Button ID="btnCANCEL" runat="server" Text="Cancel" OnClick="btnCANCEL_Click" CssClass="auto-style5" />
    </p>
    <p style="width: 351px; margin-left: 0px">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" Text="OK" CssClass="auto-style4" />
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style17" OnClick="btnFind_Click" Text="Find" />
    </p>
</form>
</body>
</html>

