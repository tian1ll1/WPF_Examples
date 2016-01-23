

using System;
using System.Collections;

// "FlyweightFactory" 

class FlyweightFactory 
{
  // Fields
  private Hashtable flyweights = new Hashtable();

  // Constructors
  public FlyweightFactory()
  {
    flyweights.Add("X", new ConcreteFlyweight());		
    flyweights.Add("Y", new ConcreteFlyweight());
    flyweights.Add("Z", new ConcreteFlyweight());
  }

  // Methods
  public Flyweight GetFlyweight(string key)
  {
    return((Flyweight)flyweights[ key ]); 
  }
}

// "Flyweight" 

abstract class Flyweight 
{
  // Methods
  abstract public void Operation( int extrinsicstate );
}

// "ConcreteFlyweight" 

class ConcreteFlyweight : Flyweight
{
  // Methods
  override public void Operation( int extrinsicstate )
  {
    Console.WriteLine("ConcreteFlyweight: {0}", 
                                     extrinsicstate );
  }
}

// "UnsharedConcreteFlyweight" 

class UnsharedConcreteFlyweight : Flyweight
{
  // Methods
  override public void Operation( int extrinsicstate )
  {
    Console.WriteLine("UnsharedConcreteFlyweight: {0}", 
                                       extrinsicstate );
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Arbitrary extrisic state
    int extrinsicstate = 22;
		
    FlyweightFactory f = new FlyweightFactory();

    // Work with different flyweight instances
    Flyweight fx = f.GetFlyweight("X");
    fx.Operation( --extrinsicstate );

    Flyweight fy = f.GetFlyweight("Y");
    fy.Operation( --extrinsicstate );

    Flyweight fz = f.GetFlyweight("Z");
    fz.Operation( --extrinsicstate );

    UnsharedConcreteFlyweight fu = new 
                       UnsharedConcreteFlyweight();
    fu.Operation( --extrinsicstate );

  }
}
