

using System;

// "Command" 

abstract class Command 
{
  // Fields
  protected Receiver receiver;

  // Constructors
  public Command( Receiver receiver )
  {
    this.receiver = receiver;
  }

  // Methods
  abstract public void Execute();
}

// "ConcreteCommand" 

class ConcreteCommand : Command
{

  // Constructors
  public ConcreteCommand( Receiver receiver ) : 
            base ( receiver ) {}

  // Methods
  public override void Execute()
  {
    receiver.Action();
  }
}

// "Receiver"

class Receiver 
{
  // Methods
  public void Action()
  {
    Console.WriteLine("Called Receiver.Action()");
  }
}

// "Invoker" 

class Invoker 
{
  // Fields
  private Command command;

  // Methods
  public void SetCommand( Command command )
  {
    this.command = command;
  }

  public void ExecuteCommand()
  {
    command.Execute();
  }		
}

/// <summary>
///    Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {	
    // Create receiver, command, and invoker
    Receiver r = new Receiver();
    Command c = new ConcreteCommand( r );
    Invoker i = new Invoker();

    // Set and execute command
    i.SetCommand(c);
    i.ExecuteCommand();

  }
}

