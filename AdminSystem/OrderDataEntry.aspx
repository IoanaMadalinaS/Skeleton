<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 538px;
            width: 600px;
        }
    </style>
</head>
<body style="height: 473px; width: 493px">
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderNo" runat="server" height="19px" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="OrderID" width="105px"></asp:Label>
        <div>
        </div>
        <asp:TextBox ID="txtCostumerNo" runat="server" height="22px" style="z-index: 1; left: 149px; top: 88px; position: absolute; width: 128px;"></asp:TextBox>
        <asp:TextBox ID="txtOrderId" runat="server"  style="z-index: 1; left: 149px; top: 14px; position: absolute; height: 17px; width: 126px"></asp:TextBox>
        <asp:Label ID="lblCostumer" runat="server" height="19px" style="z-index: 1; left: 10px; position: absolute; top: 94px; right: 515px; width: 7px; bottom: 504px;" Text="Costumer Name"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server" height="22px" style="z-index: 1; left: 149px; top: 47px; position: absolute; bottom: 176px" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPrice" runat="server" height="19px" style="z-index: 1; left: 7px; top: 53px; position: absolute" Text="Total Price" width="105px"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 11px; top: 208px; position: absolute; height: 19px; width: 105px" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" height="22px" style="z-index: 1; left: 149px; top: 207px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtAdressD" runat="server" height="22px" style="z-index: 1; left: 149px; top: 126px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" height="19px" style="z-index: 1; left: 11px; top: 169px; position: absolute" Text="Post Code" width="105px"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" height="22px" style="z-index: 1; left: 149px; top: 167px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkDelivered" runat="server" style="z-index: 1; left: 20px; top: 242px; position: absolute" Text="Delivered" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 128px; top: 247px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 224px; top: 319px; position: absolute" Text="OK" />
        <p>
            <asp:Label ID="Adress" runat="server" height="19px" style="z-index: 1; left: 9px; top: 132px; position: absolute; bottom: 466px" Text="Delivery Address" width="105px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
       
        
        <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 100px; top: 319px; position: absolute; height: 26px; width: 60px;" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
    </form>
</body>
</html>
