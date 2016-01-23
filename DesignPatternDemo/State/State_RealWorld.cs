

using System;

// "State"

abstract class State
{
  // Fields
  protected Account account;
  protected double balance;

  protected double interest;
  protected double lowerLimit;
  protected double upperLimit;

  // Properties
  public Account Account
  {
    get{ return account; }
    set{ account = value; }
  }

  public double Balance
  {
    get{ return balance; }
    set{ balance = value; }
  }

  // Methods
  abstract public void Initialize();
  abstract public void Deposit( double amount );
  abstract public void Withdraw( double amount );
  abstract public void PayInterest();
  abstract public void StateChangeCheck();
}

// "ConcreteState"

// Account is overdrawn

class RedState : State
{
  // Fields
  double serviceFee;

  // Constructors
  public RedState( State state )
  {
    this.balance = state.Balance;
    this.account = state.Account;
    Initialize();
  }

  // Methods
  override public void Initialize()
  {
    // Should come from a database
    interest   = 0.0;
    lowerLimit = -100.0;
    upperLimit = 0.0;
    serviceFee = 15.00;
  }

  override public void Deposit( double amount )
  {
    balance += amount;
    StateChangeCheck();
  }

  override public void Withdraw( double amount )
  {
    amount = amount - serviceFee;
    Console.WriteLine( "No funds available to withdraw!" );
  }

  override public void PayInterest()
  {
    // No interest is paid
  }

  override public void StateChangeCheck()
  {
    if( balance > upperLimit )
      account.State = new SilverState( this );
  }
}

// "ConcreteState"

// Silver is non-interest bearing state

class SilverState : State
{
  // Constructors
  public SilverState( double balance, Account account )
  {
    this.balance = balance;
    this.account = account;
    Initialize();
  }

  public SilverState( State state )
  {
    this.balance = state.Balance;
    this.account = state.Account;
    Initialize();
  }

  // Methods
  override public void Initialize()
  {
    // Should come from a database
    interest = 0.0;
    lowerLimit = 0.0;
    upperLimit = 1000.0;
  }

  override public void Deposit( double amount )
  {
    balance += amount;
    StateChangeCheck();
  }

  override public  void Withdraw( double amount )
  {
    balance -= amount;
    StateChangeCheck();
  }

  override public void PayInterest()
  {
    balance += interest * balance;
    StateChangeCheck();
  }

  override public void StateChangeCheck()
  {
    if( balance < lowerLimit )
      account.State = new RedState( this );
    else if( balance > upperLimit )
      account.State = new GoldState( this );
  }
}

// "ConcreteState"

// Interest bearing state

class GoldState : State
{
  // Constructors
  public GoldState( double balance, Account account )
  {
    this.balance = balance;
    this.account = account;
    Initialize();
  }

  public GoldState( State state )
  {
    this.balance = state.Balance;
    this.account = state.Account;
    Initialize();
  }

  // Methods
  override public void Initialize()
  {
    // Should come from a database
    interest = 0.05;
    lowerLimit = 1000.0;
    upperLimit = 10000000.0;
  }

  override public void Deposit( double amount )
  {
    balance += amount;
    StateChangeCheck();
  }

  override public  void Withdraw( double amount )
  {
    balance -= amount;
    StateChangeCheck();
  }

  override public void PayInterest()
  {
    balance += interest * balance;
    StateChangeCheck();
  }

  override public void StateChangeCheck()
  {
    if( balance < 0.0 )
      account.State = new RedState( this );
    else if( balance < lowerLimit )
      account.State = new SilverState( this );
  }
}

// "Context"

class Account
{
  // Fields
  private State state;
  private string owner;

  // Constructors
  public Account( string owner )
  {
    // New accounts are 'Silver' by default
    this.owner = owner;
    state = new SilverState( 0.0, this );
  }

  // Properties
  public double Balance
  {
    get{ return state.Balance; }
  }

  public State State
  {
    get{ return state; }
    set{ state = value; }
  }

  // Methods
  public void Deposit( double amount )
  {
    state.Deposit( amount );
    Console.WriteLine( "Deposited {0:C} --- ", amount);
    Console.WriteLine( " Balance = {0:C}", this.Balance );
    Console.WriteLine( " Status  = {0}" , this.State );
    Console.WriteLine( "" );
  }

  public void Withdraw( double amount )
  {
    state.Withdraw( amount );
    Console.WriteLine( "Withdrew {0:C} --- ", amount);
    Console.WriteLine( " Balance = {0:C}", this.Balance );
    Console.WriteLine( " Status  = {0}" , this.State );
    Console.WriteLine( "" );
  }

  public void PayInterest()
  {
    state.PayInterest();
    Console.WriteLine( "Interest Paid --- ");
    Console.WriteLine( " Balance = {0:C}", this.Balance );
    Console.WriteLine( " Status  = {0}" , this.State );
    Console.WriteLine( "" );
  }
}

/// <summary>
///  StateApp test
/// </summary>
public class StateApp
{
  public static void Main( string[] args )
  {
    // Open a new account
    Account account = new Account( "Patty La Belle" );

    // Apply financial transactions
    account.Deposit( 500.0 );
    account.Deposit( 300.0 );
    account.Deposit( 550.0 );
    account.PayInterest();
    account.Withdraw( 2000.00 );
    account.Withdraw( 1100.00 );
    
  }
}
