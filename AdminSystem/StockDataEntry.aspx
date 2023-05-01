<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the stock entry page
   
    <form id="form1" runat="server">
        <asp:TextBox ID="txtItemNo" runat="server" Style="z-index: 1; left: 112px; top: 46px; position: absolute"></asp:TextBox>
        <asp:Button ID="txtFind" runat="server" Style="z-index: 1; left: 252px; top: 46px; position: absolute" Text="Find" OnClick="txtFind_Click" />
        <div>
        </div>
        <asp:Label ID="lblItemNo" runat="server" Style="z-index: 1; left: 12px; top: 48px; position: absolute; bottom: 316px;" Text="Item Number" Width="68px"></asp:Label>
        <asp:Label ID="lblItemName" runat="server" Style="z-index: 1; left: 14px; top: 91px; position: absolute; height: 19px" Text="Item Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtItemName" runat="server" OnTextChanged="txtItemName_TextChanged" Style="z-index: 1; left: 112px; top: 85px; position: absolute" Width="128px"></asp:TextBox>
            <asp:TextBox ID="txtItemDesc" runat="server" OnTextChanged="txtItemDesc_TextChanged" Style="z-index: 1; left: 112px; top: 120px; position: absolute; margin-bottom: 0px" Width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblItemDesc" runat="server" Style="z-index: 1; left: 12px; top: 116px; position: absolute" Text="Item Description" Width="68px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Style="z-index: 1; left: 11px; top: 162px; position: absolute; width: 68px; right: 2064px" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" OnTextChanged="txtDateAdded_TextChanged" Style="z-index: 1; left: 112px; top: 160px; position: absolute" Width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" Style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Price" Width="68px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" Style="z-index: 1; left: 112px; top: 200px; position: absolute" Width="128px"></asp:TextBox>
        <p>
            &nbsp;
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Label ID="lblAvaliable" runat="server" Style="z-index: 1; top: 262px; position: absolute" Text="Avaliable" Width="68px" AssociatedControlID="chkAvailable"><asp:CheckBox ID="chkAvailable" runat="server" Style="position: absolute" /></asp:Label>
            <%--<asp:TextBox ID="txtAvaliable" runat="server" OnTextChanged="txtAvaliable_TextChanged" Style="z-index: 1; left: 112px; top: 260px; position: absolute" Width="128px"></asp:TextBox>--%>
            
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 9px; top: 369px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Style="z-index: 1; left: 18px; top: 321px; position: absolute" Text="Active" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; top: 408px; position: absolute; left: 67px" Text="Cancel" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Style="z-index: 1; left: 10px; top: 407px; position: absolute" Text="OK" />
        </p>
    </form>

</body>
</html>

