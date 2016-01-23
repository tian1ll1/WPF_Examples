

using System;

// "AbstractClass"

abstract class AbstractClass
{
  // Methods
  abstract public void PrimitiveOperation1();
  abstract public void PrimitiveOperation2();

  // The Template method
  public void TemplateMethod()
  {
    Console.WriteLine("In AbstractClass.TemplateMethod()");

    PrimitiveOperation1();
    PrimitiveOperation2();
  }
}

// "ConcreteClass"

class ConcreteClass : AbstractClass
{
  // Methods
  public override void PrimitiveOperation1()
  {
    Console.WriteLine("Called ConcreteClass.PrimitiveOperation1()");
  }
  public override void PrimitiveOperation2()
  {
    Console.WriteLine("Called ConcreteClass.PrimitiveOperation2()");
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Create instance and call template method
    ConcreteClass c = new ConcreteClass();
    c.TemplateMethod();

  }
}
