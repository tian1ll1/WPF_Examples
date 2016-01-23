

using System;

// "Handler" 

abstract class Handler 
{
  // Fields
  protected Handler successor;
  
  // Methods
  public void SetSuccessor( Handler successor )
  {
    this.successor = successor;
  }

  abstract public void HandleRequest( int request );
}

// "ConcreteHandler1"

class ConcreteHandler1 : Handler
{
  // Methods
  override public void HandleRequest( int request )
  {
    if( request >= 0 && request < 10 )
      Console.WriteLine("{0} handled request {1}", 
                        this, request );
    else 
      if( successor != null )
        successor.HandleRequest( request );
  }
}

// "ConcreteHandler2"

class ConcreteHandler2 : Handler
{
  // Methods
  override public void HandleRequest( int request )
  {
    if( request >= 10 && request < 20 )
      Console.WriteLine("{0} handled request {1}", 
        this, request );
    else 
      if( successor != null )
        successor.HandleRequest( request );
  }
}

// "ConcreteHandler3"

class ConcreteHandler3 : Handler
{
  // Methods
  override public void HandleRequest( int request )
  {
    if( request >= 20 && request < 30 )
      Console.WriteLine("{0} handled request {1}", 
        this, request );
    else 
      if( successor != null )
        successor.HandleRequest( request );
  }
}

// "Request"

class Request 
{
  // Fields
  private int iRequestType;
  private string strRequestParameters;

  // Constructors
  public Request(int requestType, string requestParameters)
  {
    iRequestType = requestType;	
    strRequestParameters = requestParameters;
  }

  // Properties
  public int RequestType 
  {
    get{ return iRequestType; }
    set{iRequestType = value; }
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Setup Chain of Responsibility
    Handler h1 = new ConcreteHandler1();
    Handler h2 = new ConcreteHandler2();
    Handler h3 = new ConcreteHandler3();
    h1.SetSuccessor(h2);
    h2.SetSuccessor(h3);

    // Generate and process request
    int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

    foreach( int request in requests )
      h1.HandleRequest( request );

    Console.Read();
  }
}


