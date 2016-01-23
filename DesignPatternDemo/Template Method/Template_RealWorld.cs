

using System;
using System.Data;
using System.Data.OleDb;

// "AbstractClass"

abstract class DataObject
{
  // Methods
  abstract public void Connect();
  abstract public void Select();
  abstract public void Process();
  abstract public void Disconnect();

  // The "Template Method" 
  public void Run()
  {
    Connect();
    Select();
    Process();
    Disconnect();
  }
}

// "ConcreteClass" 

class CustomerDataObject : DataObject
{
  private string connectionString = 
        "provider=Microsoft.JET.OLEDB.4.0; "
        + "data source=c:\\nwind.mdb";
  private string commandString;
  private DataSet dataSet;


  // Methods
  public override void Connect( )
  {
    // Nothing to do
  }

  public override void Select( )
  {
    commandString = "select CompanyName from Customers";
    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
        commandString, connectionString );

    dataSet = new DataSet();
    dataAdapter.Fill( dataSet, "Customers" );
  }

  public override void Process()
  {
    DataTable dataTable = dataSet.Tables["Customers"];
    foreach( DataRow dataRow in dataTable.Rows )
      Console.WriteLine( dataRow[ "CompanyName" ] );
  }

  public override void Disconnect()
  {
    // Nothing to do
  }
}

/// <summary>
///  TemplateMethodApp test
/// </summary>
public class TemplateMethodApp
{
  public static void Main( string[] args )
  {
    CustomerDataObject c = new CustomerDataObject( );
    c.Run();

    Console.Read();
  }
}
