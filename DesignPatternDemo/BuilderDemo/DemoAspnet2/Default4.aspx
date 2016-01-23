<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete"
            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData"
            TypeName="DataSet1TableAdapters.AddressTableAdapter" UpdateMethod="UpdateAddress">
            <DeleteParameters>
                <asp:Parameter Name="Original_AddressID" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="AddressLine1" Type="String" />
                <asp:Parameter Name="AddressLine2" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="StateProvinceID" Type="Int32" />
                <asp:Parameter Name="PostalCode" Type="String" />
                <asp:Parameter Name="rowguid" Type="Object" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                <asp:Parameter Name="Original_AddressID" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="AddressLine1" Type="String" />
                <asp:Parameter Name="AddressLine2" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="StateProvinceID" Type="Int32" />
                <asp:Parameter Name="PostalCode" Type="String" />
                <asp:Parameter Name="rowguid" Type="Object" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            </InsertParameters>
        </asp:ObjectDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AddressID"
            DataSourceID="ObjectDataSource1">
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
    </form>
</body>
</html>
