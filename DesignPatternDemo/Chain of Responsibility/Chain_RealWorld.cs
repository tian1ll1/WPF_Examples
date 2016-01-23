

using System;

// "Handler"

abstract class Approver
{
  // Fields
  protected string name;
  protected Approver successor;

  // Constructors
  public Approver( string name )
  {
    this.name = name;
  }

  // Methods
  public void SetSuccessor( Approver successor )
  {
    this.successor = successor;
  }

  abstract public void ProcessRequest( 
                   PurchaseRequest request );
}

// "ConcreteHandler"

class Director : Approver
{
  // Constructors
  public Director ( string name ) : base( name ) {}

  // Methods
  override public void ProcessRequest( 
                      PurchaseRequest request )
  {
    if( request.Amount < 10000.0 )
      Console.WriteLine( "{0} {1} approved request# {2}", 
        this, name, request.Number);
    else
      if( successor != null )
        successor.ProcessRequest( request );
  }
}

// "ConcreteHandler"

class VicePresident : Approver
{
  // Constructors
  public VicePresident ( string name ) : base( name ) {}

  // Methods
  override public void ProcessRequest( 
                            PurchaseRequest request )
  {
    if( request.Amount < 25000.0 )
      Console.WriteLine( "{0} {1} approved request# {2}", 
        this, name, request.Number);
    else
      if( successor != null )
        successor.ProcessRequest( request );
  }
}
// "ConcreteHandler"

class President : Approver
{
  // Constructors
  public President ( string name ) : base( name ) {}

  // Methods
  override public void ProcessRequest( 
                              PurchaseRequest request )
  {
    if( request.Amount < 100000.0 )
      Console.WriteLine( "{0} {1} approved request# {2}", 
        this, name, request.Number);
    else
      Console.WriteLine( "Request# {0} requires " +
        "an executive meeting!", request.Number );
  }
}

// Request details

class PurchaseRequest
{
  // Member Fields
  private int number;
  private double amount;
  private string purpose;

  // Constructors
  public PurchaseRequest( int number, double amount, string purpose )
  {
    this.number = number;
    this.amount = amount;
    this.purpose = purpose;
  }

  // Properties
  public double Amount
  {
    get{ return amount; }
    set{ amount = value; }
  }

  public string Purpose
  {
    get{ return purpose; }
    set{ purpose = value; }
  }

  public int Number
  {
    get{ return number; }
    set{ number = value; }
  }
}

/// <summary>
///    Chain Application
/// </summary>
public class ChainApp
{
  public static void Main( string[] args )
  {
    // Setup Chain of Responsibility
    Director Larry = new Director( "Larry" );
    VicePresident Sam = new VicePresident( "Sam" );
    President Tammy = new President( "Tammy" );
    Larry.SetSuccessor( Sam );
    Sam.SetSuccessor( Tammy );

    // Generate and process different requests
    PurchaseRequest rs = new PurchaseRequest( 
                          2034, 350.00, "Supplies" );
    Larry.ProcessRequest( rs );

    PurchaseRequest rx = new PurchaseRequest( 
                          2035, 32590.10, "Project X" );
    Larry.ProcessRequest( rx );

    PurchaseRequest ry = new PurchaseRequest( 
                          2036, 122100.00, "Project Y" );
    Larry.ProcessRequest( ry );

  }
}
