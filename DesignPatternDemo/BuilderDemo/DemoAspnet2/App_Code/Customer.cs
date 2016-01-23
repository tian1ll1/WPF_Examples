using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Customer 的摘要说明
/// </summary>
public class Customer
{
    private string _Name = string.Empty;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    private string _Address = string.Empty;

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }

	public Customer()
	{

	}

    public DataSet GetCustomers()
    { 
        //select query
        return null;
    }

    public System.Collections.Generic.List<Customer> GetCustomersEx()
    {
        //select query
        return null;
    }
}
