

using System;

// "Originator" 

class Originator
{
  // Fields
  private string state = "OFF";

  // Properties
  public string State
  {
    get{ return state; }
    set{ state = value; }
  }

  // Methods
  public Memento CreateMemento()
  {
    return (new Memento( state ));
  }

  public void SetMemento( Memento memento )
  {
    state = memento.State;
    Console.WriteLine( "Restored to state: {0}", state );
  }
}

// "Memento"

class Memento
{
  // Fields
  private string state;

  // Constructors
  public Memento( string state )
  {
    this.state = state;
  }

  // Properties
  public string State
  {
    get{ return state; }
  }
}

// "Caretaker" 

class Caretaker
{
  // Fields
  private Memento memento;

  // Properties
  public Memento Memento
  {
    set{ memento = value; }
    get{ return memento; }
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    Originator o = new Originator();
    o.State = "On";

    // Store internal state
    Caretaker c = new Caretaker();
    c.Memento = o.CreateMemento();

    // Continue changing originator
    o.State = "Off";

    // Restore saved state
    o.SetMemento( c.Memento );

    Console.Read();
  }
}
