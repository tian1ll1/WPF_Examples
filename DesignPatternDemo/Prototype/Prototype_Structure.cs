

using System;

// "Prototype" 

abstract class Prototype
{
  // Fields
  private string id;

  // Constructors
  public Prototype( string id )
  {
    this.id = id;
  }

  public string Id
  {
    get{ return id; }
  }

  // Methods
  abstract public Prototype Clone();
}

// "ConcretePrototype1"

class ConcretePrototype1 : Prototype
{
  // Constructors
  public ConcretePrototype1( string id ) : base ( id ) {}

  // Methods
  override public Prototype Clone()
  {
    // Shallow copy
    return (Prototype)this.MemberwiseClone();
  }
}

// "ConcretePrototype2"

class ConcretePrototype2 : Prototype
{
  // Constructors
  public ConcretePrototype2( string id ) : base ( id ) {}

  // Methods
  override public Prototype Clone()
  {
    // Shallow copy
    return (Prototype)this.MemberwiseClone();
  }
}

/// <summary>
///   Client test
/// </summary>
class Client
{
  public static void Main( string[] args )
  {
    // Create two instances and clone each
    ConcretePrototype1 p1 = new ConcretePrototype1("I");
    ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
    Console.WriteLine( "Cloned: {0}", c1.Id );

    ConcretePrototype2 p2 = new ConcretePrototype2("II");
    ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
    Console.WriteLine( "Cloned: {0}", c2.Id );

  }
}

