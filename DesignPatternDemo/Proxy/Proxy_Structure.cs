

using System;

// "Subject" 

abstract class Subject 
{
  // Methods
  abstract public void Request();		
}

// "RealSubject" 

 sealed  class RealSubject : Subject
{
  // Methods
  override public void Request()
  {
    Console.WriteLine("Called RealSubject.Request()");
  }
}

// "Proxy" 

class Proxy : Subject
{
  // Fields
  RealSubject realSubject;

  // Methods
  override public void Request()
  {
    // Uses "lazy initialization"
    if( realSubject == null )
      realSubject = new RealSubject();

    realSubject.Request();
  }	

}
/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Create proxy and request a service
    Proxy p = new Proxy();
    p.Request();

  }
}
