using System;

// "Abstraction"

class Abstraction
{
  // Fields
  protected Implementor implementor;

  // Properties
  public Implementor Implementor
  {
    set{ implementor = value; }
  }

  // Methods
  virtual public void Operation()
  {
    implementor.Operation();
  }
}

// "Implementor" 

abstract class Implementor
{
  // Methods
  abstract public void Operation();
}

// "RefinedAbstraction"

class RefinedAbstraction : Abstraction
{
  // Methods
  override public void Operation()
  {
    implementor.Operation();
  }
}

// "ConcreteImplementorA"

class ConcreteImplementorA : Implementor
{
  // Methods
  override public void Operation()
  {
    Console.WriteLine("ConcreteImplementorA Operation");
  }
}

// "ConcreteImplementorB"

class ConcreteImplementorB : Implementor
{
  // Methods
  override public void Operation()
  {
    Console.WriteLine("ConcreteImplementorB Operation");
  }
}

/// <summary>
///    Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    Abstraction abstraction = new RefinedAbstraction();

    // Set implementation and call
    abstraction.Implementor = new ConcreteImplementorA();
    abstraction.Operation();

    // Change implemention and call
    abstraction.Implementor = new ConcreteImplementorB();
    abstraction.Operation();

  }
}
