<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default6.aspx.vb" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>"
            SelectCommand="SELECT Person.Address.* FROM Person.Address" UpdateCommand="UPDATE Person.Address SET AddressLine2 = @addr, City = @city, StateProvinceID = @provider WHERE (AddressID = @id)">
            <UpdateParameters>
                <asp:ControlParameter ControlID="FormView1" Name="newparameter" PropertyName="SelectedValue" />
                <asp:Parameter Name="newparameter" />
                <asp:Parameter Name="newparameter" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
            DataKeyNames="AddressID" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="AddressID" HeaderText="AddressID" InsertVisible="False"
                    ReadOnly="True" SortExpression="AddressID" />
                <asp:BoundField DataField="AddressLine1" HeaderText="AddressLine1" SortExpression="AddressLine1" />
                <asp:BoundField DataField="AddressLine2" HeaderText="AddressLine2" SortExpression="AddressLine2" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="StateProvinceID" HeaderText="StateProvinceID" SortExpression="StateProvinceID" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="rowguid" HeaderText="rowguid" SortExpression="rowguid" />
                <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" />
                <asp:CommandField ShowEditButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="AddressID"
            DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                AddressID:
                <asp:Label ID="AddressIDLabel1" runat="server" Text='<%# Eval("AddressID") %>'></asp:Label><br />
                AddressLine1:
                <asp:TextBox ID="AddressLine1TextBox" runat="server" Text='<%# Bind("AddressLine1") %>'>
                </asp:TextBox><br />
                AddressLine2:
                <asp:TextBox ID="AddressLine2TextBox" runat="server" Text='<%# Bind("AddressLine2") %>'>
                </asp:TextBox><br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>'>
                </asp:TextBox><br />
                StateProvinceID:
                <asp:TextBox ID="StateProvinceIDTextBox" runat="server" Text='<%# Bind("StateProvinceID") %>'>
                </asp:TextBox><br />
                PostalCode:
                <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>'>
                </asp:TextBox><br />
                rowguid:
                <asp:TextBox ID="rowguidTextBox" runat="server" Text='<%# Bind("rowguid") %>'>
                </asp:TextBox><br />
                ModifiedDate:
                <asp:TextBox ID="ModifiedDateTextBox" runat="server" Text='<%# Bind("ModifiedDate") %>'>
                </asp:TextBox><br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                    Text="更新">
                </asp:LinkButton>
                <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                    Text="取消">
                </asp:LinkButton>
            </EditItemTemplate>
            <InsertItemTemplate>
                AddressLine1:
                <asp:TextBox ID="AddressLine1TextBox" runat="server" Text='<%# Bind("AddressLine1") %>'>
                </asp:TextBox><br />
                AddressLine2:
                <asp:TextBox ID="AddressLine2TextBox" runat="server" Text='<%# Bind("AddressLine2") %>'>
                </asp:TextBox><br />
                City:
                <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>'>
                </asp:TextBox><br />
                StateProvinceID:
                <asp:TextBox ID="StateProvinceIDTextBox" runat="server" Text='<%# Bind("StateProvinceID") %>'>
                </asp:TextBox><br />
                PostalCode:
                <asp:TextBox ID="PostalCodeTextBox" runat="server" Text='<%# Bind("PostalCode") %>'>
                </asp:TextBox><br />
                rowguid:
                <asp:TextBox ID="rowguidTextBox" runat="server" Text='<%# Bind("rowguid") %>'>
                </asp:TextBox><br />
                ModifiedDate:
                <asp:TextBox ID="ModifiedDateTextBox" runat="server" Text='<%# Bind("ModifiedDate") %>'>
                </asp:TextBox><br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                    Text="插入">
                </asp:LinkButton>
                <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                    Text="取消">
                </asp:LinkButton>
            </InsertItemTemplate>
            <ItemTemplate>
                AddressID:
                <asp:Label ID="AddressIDLabel" runat="server" Text='<%# Eval("AddressID") %>'></asp:Label><br />
                AddressLine1:
                <asp:Label ID="AddressLine1Label" runat="server" Text='<%# Bind("AddressLine1") %>'>
                </asp:Label><br />
                AddressLine2:
                <asp:Label ID="AddressLine2Label" runat="server" Text='<%# Bind("AddressLine2") %>'>
                </asp:Label><br />
                City:
                <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>'></asp:Label><br />
                StateProvinceID:
                <asp:Label ID="StateProvinceIDLabel" runat="server" Text='<%# Bind("StateProvinceID") %>'>
                </asp:Label><br />
                PostalCode:
                <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Bind("PostalCode") %>'>
                </asp:Label><br />
                rowguid:
                <asp:Label ID="rowguidLabel" runat="server" Text='<%# Bind("rowguid") %>'></asp:Label><br />
                ModifiedDate:
                <asp:Label ID="ModifiedDateLabel" runat="server" Text='<%# Bind("ModifiedDate") %>'>
                </asp:Label><br />
            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
