

using System;
using System.Collections;

// "Mediator"

interface IChatroom
{
  // Methods
  void Register( Participant participant );
  void Send( string from, string to, string message );
}

// "ConcreteMediator"

class Chatroom : IChatroom
{
  // Fields
  private Hashtable participants = new Hashtable();

  // Methods
  public void Register( Participant participant )
  {
    if( participants[ participant.Name ] == null )
      participants[ participant.Name ] = participant;

    participant.Chatroom = this;
  }

  public void Send( string from, string to, string message )
  {
    Participant pto = (Participant)participants[ to ];
    if( pto != null )
      pto.Receive( from, message );
  }
}

// "AbstractColleague"

class Participant
{
  // Fields
  private Chatroom chatroom;
  private string name;

  // Constructors
  public Participant( string name )
  {
    this.name = name;
  }

  // Properties
  public string Name
  {
    get{ return name; }
  }

  public Chatroom Chatroom
  {
    set{ chatroom = value; }
    get{ return chatroom; }
  }

  // Methods
  public void Send( string to, string message )
  {
    chatroom.Send( name, to, message );
  }

  virtual public void Receive( 
                       string from, string message )
  {
    Console.WriteLine( "{0} to {1}: '{2}'",
      from, this.name, message );
  }
}

//" ConcreteColleague1"

class BeatleParticipant : Participant
{
  // Constructors
  public BeatleParticipant( string name ) 
                                : base ( name ) { }

  override public void Receive( 
                  string from, string message )
  {
    Console.Write( "To a Beatle: " );
    base.Receive( from, message );
  }
}

//" ConcreteColleague2"

class NonBeatleParticipant : Participant
{
  // Constructors
  public NonBeatleParticipant( string name ) 
                                   : base ( name ) { }

  override public void Receive( 
                        string from, string message )
  {
    Console.Write( "To a non-Beatle: " );
    base.Receive( from, message );
  }
}

/// <summary>
///   MediatorApp test
/// </summary>
public class MediatorApp
{
  public static void Main(string[] args)
  {
    // Create chatroom
    Chatroom c = new Chatroom();

    // Create 'chatters' and register them
    Participant George =new BeatleParticipant("George");
    Participant Paul = new BeatleParticipant("Paul");
    Participant Ringo = new BeatleParticipant("Ringo");
    Participant John = new BeatleParticipant("John") ;
    Participant Yoko = new NonBeatleParticipant("Yoko");

    c.Register( George );
    c.Register( Paul );
    c.Register( Ringo );
    c.Register( John );
    c.Register( Yoko );

    // Chatting participants
    Yoko.Send( "John", "Hi John!" );
    Paul.Send( "Ringo", "All you need is love" );
    Ringo.Send( "George", "My sweet Lord" );
    Paul.Send( "John", "Can't buy me love" );
    John.Send( "Yoko", "My sweet love" ) ;

  }
}

