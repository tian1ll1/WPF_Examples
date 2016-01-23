

using System;
using System.Collections;

// "Context" 

class Context 
{
}

// "AbstractExpression"

abstract class AbstractExpression 
{
  abstract public void Interpret( Context context );
}

// "TerminalExpression" 

class TerminalExpression : AbstractExpression
{
  override public void Interpret( Context context )	
  {
    Console.WriteLine( "Called Terminal.Interpret()" );
  }
}

// "NonterminalExpression" 

class NonterminalExpression : AbstractExpression
{
  override public void Interpret( Context context )	
  {
    Console.WriteLine( "Called Nonterminal.Interpret()" );
  }	
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {
    Context c = new Context();

    // Usually a tree 
    ArrayList l = new ArrayList(); 

    // Populate 'abstract syntax tree' 
    l.Add(new TerminalExpression());
    l.Add(new NonterminalExpression());
    l.Add(new TerminalExpression());
    l.Add(new TerminalExpression());

    // Interpret
    foreach( AbstractExpression exp in l )
      exp.Interpret(c);

  }
}


