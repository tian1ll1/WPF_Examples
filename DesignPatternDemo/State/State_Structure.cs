

using System;

// "State" 

abstract class State
{
  // Methods
  abstract public void Handle( Context context );
}

// "ConcreteStateA"

class ConcreteStateA : State
{
  // Methods
  override public void Handle( Context context )
  {
    context.State = new ConcreteStateB();
  }
}

// "ConcreteStateB" 

class ConcreteStateB : State
{
  // Methods
  override public void Handle( Context context )
  {
    context.State = new ConcreteStateA();
  }
}

// "Context" 

class Context
{
  // Fields
  private State state;

  // Constructors
  public Context( State state )
  {
    this.state = state;
  }

  // Properties
  public State State
  {
    get{ return state; }
    set{ state = value; }
  }

  // Methods
  public void Request()
  {
    state.Handle( this );
  }

  public void Show()
  {
    Console.WriteLine( "State: " + state );
  }
}

/// <summary>
///  Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Setup context in a state
    Context c = new Context( new ConcreteStateA() );
    c.Show();

    // Issue request, which toggles state
    c.Request();
    c.Show();

    // Issue request, which toggles state
    c.Request();
    c.Show();

  }
}


