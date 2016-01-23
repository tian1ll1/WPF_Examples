

using System;

// "SubSystem ClassA"

class Bank
{
  // Methods
  public bool SufficientSavings( Customer c )
  {
    Console.WriteLine("Check bank for {0}", c.Name );
    return true;
  }
}

// "SubSystem ClassB"

class Credit
{
  // Methods
  public bool GoodCredit( int amount, Customer c )
  {
    Console.WriteLine( "Check credit for {0}", c.Name );
    return true;
  }
}

// "SubSystem ClassC"

class Loan
{
  // Methods
  public bool GoodLoan( Customer c )
  {
    Console.WriteLine( "Check loan for {0}", c.Name );
    return true;
  }
}

class Customer
{
  // Fields
  private string name;

  // Constructors
  public Customer( string name )
  {
    this.name = name;
  }

  // Properties
  public string Name
  {
    get{ return name; }
  }
}

// "Facade" 

class MortgageApplication
{
  // Fields
  int amount;
  private Bank bank = new Bank();
  private Loan loan = new Loan();
  private Credit credit = new Credit();

  // Constructors
  public MortgageApplication( int amount )
  {
    this.amount = amount;
  }

  // Methods
  public bool IsEligible( Customer c )
  {
    // Check creditworthyness of applicant
    if( !bank.SufficientSavings( c ) ) return false;
    if( !loan.GoodLoan( c ) ) return false;
    if( !credit.GoodCredit( amount, c )) return false;
    return true;
  }
}

/// <summary>
///   Facade Client
/// </summary>
public class FacadeApp
{
  public static void Main(string[] args)
  {
    // Create Facade
    MortgageApplication mortgage = 
                   new MortgageApplication( 125000 );

    // Call subsystem through Facade
    mortgage.IsEligible( 
                new Customer( "Gabrielle McKinsey" ) );

  }
}
