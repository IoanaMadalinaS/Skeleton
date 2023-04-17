<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the stock entry page
    <form id="form1" runat="server">
        <asp:TextBox ID="txtItemNo" runat="server" style="z-index: 1; left: 112px; top: 46px; position: absolute"></asp:TextBox>
        <div>
        </div>
        <asp:Label ID="lblItemNo" runat="server" style="z-index: 1; left: 12px; top: 48px; position: absolute; bottom: 316px;" Text="Item Number" width="68px"></asp:Label>
        <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 14px; top: 91px; position: absolute; height: 19px" Text="Item Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtItemName" runat="server" OnTextChanged="txtItemName_TextChanged" style="z-index: 1; left: 112px; top: 85px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtItemDesc" runat="server" OnTextChanged="txtItemDesc_TextChanged" style="z-index: 1; left: 112px; top: 120px; position: absolute; margin-bottom: 0px" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblItemDesc" runat="server" style="z-index: 1; left: 12px; top: 116px; position: absolute" Text="Item Description" width="68px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 162px; position: absolute; width: 68px; right: 2064px" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" OnTextChanged="txtDateAdded_TextChanged" style="z-index: 1; left: 112px; top: 160px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Price" width="68px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 112px; top: 200px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblAvaliable" runat="server" style="z-index: 1; top: 262px; position: absolute" Text="Avaliable" width="68px"></asp:Label>
            <asp:TextBox ID="txtAvaliable" runat="server" OnTextChanged="txtAvaliable_TextChanged" style="z-index: 1; left: 112px; top: 260px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 369px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 18px; top: 321px; position: absolute" Text="Active" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 408px; position: absolute; left: 67px" Text="Cancel" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 407px; position: absolute" Text="OK" />
        </p>
    </form>
   
</body>
</html>

