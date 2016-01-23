

using System;

// "Strategy"

abstract class Strategy
{
  // Methods
  abstract public void AlgorithmInterface();
}

// "ConcreteStrategyA"

class ConcreteStrategyA : Strategy
{
  // Methods
  override public void AlgorithmInterface()
  {
    Console.WriteLine(
        "Called ConcreteStrategyA.AlgorithmInterface()");
  }
}

// "ConcreteStrategyB"

class ConcreteStrategyB : Strategy
{
  // Methods
  override public void AlgorithmInterface()
  {
    Console.WriteLine(
        "Called ConcreteStrategyB.AlgorithmInterface()");
  }
}

// "ConcreteStrategyC"

class ConcreteStrategyC : Strategy
{
  // Methods
  override public void AlgorithmInterface()
  {
    Console.WriteLine(
        "Called ConcreteStrategyC.AlgorithmInterface()");
  }
}

// "Context" 

class Context
{
  // Fields
  Strategy strategy;

  // Constructors
  public Context( Strategy strategy )
  {
    this.strategy = strategy;
  }

  // Methods
  public void ContextInterface()
  {
    strategy.AlgorithmInterface();
  }
}

/// <summary>
///  Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Three contexts following different strategies
    Context c = new Context( new ConcreteStrategyA() );
    c.ContextInterface();

    Context d = new Context( new ConcreteStrategyB() );
    d.ContextInterface();

    Context e = new Context( new ConcreteStrategyC() );
    e.ContextInterface();

  }
}

