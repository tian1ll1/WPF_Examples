

using System;
using System.Collections;

// "Subject" 

abstract class Stock
{
  // Fields
  protected string symbol;
  protected double price;
  private ArrayList investors = new ArrayList();

  // Constructor
  public Stock( string symbol, double price )
  {
    this.symbol = symbol;
    this.price = price;
  }

  // Methods
  public void Attach( Investor investor )
  {
    investors.Add( investor );
  }

  public void Detach( Investor investor )
  {
    investors.Remove( investor );
  }

  public void Notify()
  {
    foreach( Investor i in investors )
      i.Update( this );
  }

  // Properties
  public double Price
  {
    get{ return price; }
    set{ price = value;
         Notify(); }
  }

  public string Symbol
  {
    get{ return symbol; }
    set{ symbol = value; }
  }
}

// "ConcreteSubject"

class IBM : Stock
{
  // Constructor
  public IBM( string symbol, double price )
    : base( symbol, price )
  {}
}

// "Observer"

interface IInvestor
{
  // Methods
  void Update( Stock stock );
}

// "ConcreteObserver"

class Investor : IInvestor
{
  // Fields
  private string name;
  private string observerState;
  private Stock stock;

  // Constructors
  public Investor( string name )
  {
    this.name = name;
  }

  // Methods
  public void Update( Stock stock )
  {
    Console.WriteLine( "Notified investor {0} of {1}'s " +
      "change to {2:C}", name, stock.Symbol, stock.Price );
  }

  // Properties
  public Stock Stock
  {
    get{ return stock; }
    set{ stock = value; }
  }
}

/// <summary>
///   ObserverApp test
/// </summary>
public class ObserverApp
{
  public static void Main( string[] args )
  {
    // Create investors
    Investor s = new Investor( "Sorros" );
    Investor b = new Investor( "Berkshire" );

    // Create IBM stock and attach investors
    IBM ibm = new IBM( "IBM", 120.00 );
    ibm.Attach( s );
    ibm.Attach( b );

    // Change price, which notifies investors
    ibm.Price = 120.10;
    ibm.Price = 121.00;
    ibm.Price = 120.50;
    ibm.Price = 120.75;
  }
}
