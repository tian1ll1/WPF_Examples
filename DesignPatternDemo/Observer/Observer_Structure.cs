


using System;
using System.Collections;

// "Subject" 

abstract class Subject
{
  // Fields
  private ArrayList observers = new ArrayList();

  // Methods
  public void Attach( Observer observer )
  {
    observers.Add( observer );
  }

  public void Detach( Observer observer )
  {
    observers.Remove( observer );
  }

  public void Notify()
  {
    foreach( Observer o in observers )
      o.Update();
  }
}

// "ConcreteSubject" 

class ConcreteSubject : Subject
{
  // Fields
  private string subjectState;

  // Properties
  public string SubjectState
  {
    get{ return subjectState; }
    set{ subjectState = value; }
  }
}

// "Observer" 

abstract class Observer
{
  // Methods
  abstract public void Update();
}

// "ConcreteObserver" 

class ConcreteObserver : Observer
{
  // Fields
  private string name;
  private string observerState;
  private ConcreteSubject subject;

  // Constructors
  public ConcreteObserver( ConcreteSubject subject, string name )
  {
    this.subject = subject;
    this.name = name;
  }

  // Methods
  override public void Update()
  {
    observerState = subject.SubjectState;
    Console.WriteLine( "Observer {0}'s new state is {1}",
      name, observerState );
  }

  // Properties
  public ConcreteSubject Subject
  {
    get { return subject; }
    set { subject = value; }
  }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    // Configure Observer structure
    ConcreteSubject s = new ConcreteSubject();

    s.Attach( new ConcreteObserver( s, "X" ) );
    s.Attach( new ConcreteObserver( s, "Y" ) );
    s.Attach( new ConcreteObserver( s, "Z" ) );

    // Change subject and notify observers
    s.SubjectState = "ABC";
    s.Notify();
  }
}

