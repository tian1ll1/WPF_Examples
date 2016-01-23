<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default5.aspx.vb" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="AddressID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="AddressID" HeaderText="AddressID" InsertVisible="False"
                    ReadOnly="True" SortExpression="AddressID" />
                <asp:BoundField DataField="AddressLine1" HeaderText="AddressLine1" SortExpression="AddressLine1" />
                <asp:BoundField DataField="AddressLine2" HeaderText="AddressLine2" SortExpression="AddressLine2" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="StateProvinceID" HeaderText="StateProvinceID" SortExpression="StateProvinceID" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
                <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>"
            SelectCommand="SELECT Person.Address.* FROM Person.Address"></asp:SqlDataSource>
    </form>
</body>
</html>
