<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="a" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="a" HeaderText="a" SortExpression="a" />
                <asp:BoundField DataField="b" HeaderText="b" SortExpression="b" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>"
            DeleteCommand="DELETE FROM Demo.B WHERE (a = @a)" SelectCommand="SELECT Demo.B.* FROM Demo.B">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView1" Name="a" PropertyName="SelectedValue" />
            </DeleteParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
