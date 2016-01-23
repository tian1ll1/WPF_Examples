

using System;

// "SubSystem" 

class SubSystemOne
{
  public void MethodOne()
  {
    Console.WriteLine("SubSystemOne Method");
  }
}

class SubSystemTwo
{
  public void MethodTwo()
  {
    Console.WriteLine("SubSystemTwo Method");
  }
}

class SubSystemThree
{
  public void MethodThree()
  {
    Console.WriteLine("SubSystemThree Method");
  }
}
class SubSystemFour
{
  public void MethodFour()
  {
    Console.WriteLine("SubSystemFour Method");
  }
}

// "Facade"

class Facade
{
  // Fields
  SubSystemOne one;
  SubSystemTwo two;
  SubSystemThree three;
  SubSystemFour four;

  // Constructors
  public Facade()
  {
    one = new SubSystemOne();
    two = new SubSystemTwo();
    three = new SubSystemThree();
    four = new SubSystemFour();
  }

  // Methods
  public void MethodA()
  {
    Console.WriteLine( "\nMethodA() ---- " );
    one.MethodOne();
    two.MethodTwo();
    four.MethodFour();
  }

  public void MethodB()
  {
    Console.WriteLine( "\nMethodB() ---- " );
    two.MethodTwo();
    three.MethodThree();
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main(string[] args)
  {
    Facade f = new Facade();

    f.MethodA();
    f.MethodB();

    Console.Read();
  }
}
