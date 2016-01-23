

using System;
using System.Collections;

// "Mediator" 

abstract class Mediator
{
  // Methods
  abstract public void Send( string message, 
                                Colleague colleague );
}

// "ConcreteMediator" 

class ConcreteMediator : Mediator
{
  // Fields
  private ConcreteColleague1 colleague1;
  private ConcreteColleague2 colleague2;

  // Properties
  public ConcreteColleague1 Colleague1
  {
    set{ colleague1 = value; }
  }

  public ConcreteColleague2 Colleague2
  {
    set{ colleague2 = value; }
  }

  // Methods
  override public void Send( string message, 
                                Colleague colleague )
  {
    if( colleague == colleague1 )
      colleague2.Notify( message );
    else
      colleague1.Notify( message );
  }
}

// "Colleague" 

abstract class Colleague
{
  // Fields
  protected Mediator mediator;

  // Constructors
  public Colleague( Mediator mediator )
  {
    this.mediator = mediator;
  }
}

// "ConcreteColleague1" 

class ConcreteColleague1 : Colleague
{

  // "Constructors" 
  public ConcreteColleague1( Mediator mediator ) 
                                 : base ( mediator ) { }

  // Methods
  public void Send( string message )
  {
    mediator.Send( message, this  );
  }

  public void Notify( string message )
  {
    Console.WriteLine( "Colleague1 gets message: " 
                                        + message );
  }
}

// "ConcreteColleague2" 

class ConcreteColleague2 : Colleague
{

  // Constructors
  public ConcreteColleague2( Mediator mediator ) 
                                 : base ( mediator ) { }
  
  // Methods
  public void Send( string message )
  {
    mediator.Send( message, this  );
  }

  public void Notify( string message )
  {
    Console.WriteLine( "Colleague2 gets message: " 
                                         + message );
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main(string[] args)
  {
    ConcreteMediator m = new ConcreteMediator();

    ConcreteColleague1 c1 = new ConcreteColleague1( m );
    ConcreteColleague2 c2 = new ConcreteColleague2( m );

    m.Colleague1 = c1;
    m.Colleague2 = c2;

    c1.Send( "How are you?" );
    c2.Send( "Fine, thanks" );

    Console.Read();
  }
}
