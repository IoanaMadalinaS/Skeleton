<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderNo" runat="server" height="19px" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="OrderID" width="105px"></asp:Label>
        <div>
        </div>
        <asp:TextBox ID="CostumerNo" runat="server" height="22px" style="z-index: 1; left: 149px; top: 84px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="OrderId" runat="server"  style="z-index: 1; left: 149px; top: 14px; position: absolute; height: 17px; width: 123px"></asp:TextBox>
        <asp:Label ID="Costumer" runat="server" height="19px" style="z-index: 1; left: 10px; position: absolute; top: 89px" Text="Costumer Name" width="105px"></asp:Label>
        <asp:TextBox ID="TotalPrice" runat="server" height="22px" style="z-index: 1; left: 149px; top: 47px; position: absolute; bottom: 176px" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="Price" runat="server" height="19px" style="z-index: 1; left: 7px; top: 53px; position: absolute" Text="Total Price" width="105px"></asp:Label>
        <asp:Label ID="OrderDate" runat="server" style="z-index: 1; left: 10px; top: 180px; position: absolute; height: 19px; width: 105px" Text="Order Date"></asp:Label>
        <asp:TextBox ID="Date" runat="server" height="22px" style="z-index: 1; left: 149px; top: 179px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="AdressD" runat="server" height="22px" style="z-index: 1; left: 149px; top: 118px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="PostCode" runat="server" height="19px" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Post Code" width="105px"></asp:Label>
        <asp:TextBox ID="DPostCode" runat="server" height="22px" style="z-index: 1; left: 149px; top: 151px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkDelivered" runat="server" style="z-index: 1; left: 53px; top: 214px; position: absolute" Text="Delivered" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 244px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 18px; top: 279px; position: absolute" Text="OK" />
        <p>
            <asp:Label ID="Adress" runat="server" height="19px" style="z-index: 1; left: 10px; top: 123px; position: absolute; bottom: 103px" Text="Delivery Address" width="105px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 101px; top: 281px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
