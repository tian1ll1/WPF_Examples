<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>"
            DeleteCommand="DELETE FROM Person.Address WHERE (AddressID = @id)" SelectCommand="SELECT AddressID, AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, rowguid, ModifiedDate FROM Person.Address">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" />
            </DeleteParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
            DataKeyNames="AddressID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None">
            <FooterStyle BackColor="Tan" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
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
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
    </form>
</body>
</html>
