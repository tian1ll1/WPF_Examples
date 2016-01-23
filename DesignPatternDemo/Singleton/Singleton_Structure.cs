

using System;

// "Singleton"

class Singleton
{
  // Fields
  private static Singleton instance;

  // Constructor
  protected Singleton() {}

  // Methods
  public static Singleton Instance()
  {
    // Uses "Lazy initialization"
    if( instance == null )
      instance = new Singleton();

    return instance;
  }
}

/// <summary>
///  Client test
/// </summary>
public class Client
{
  public static void Main()
  {
    // Constructor is protected -- cannot use new
    Singleton s1 = Singleton.Instance();
    Singleton s2 = Singleton.Instance();

    if( s1 == s2 )
      Console.WriteLine( "The same instance" );

    Console.Read();
  }
}
