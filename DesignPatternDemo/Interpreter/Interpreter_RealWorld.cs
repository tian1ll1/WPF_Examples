

using System;
using System.Text;
using System.Collections;

// "Context"

class Context
{
  // Fields
  private string input;
  private int output;

  // Constructors
  public Context( string input )
  {
    this.input = input;
  }

  // Properties
  public string Input
  {
    get{ return input; }
    set{ input = value; }
  }

  public int Output
  {
    get{ return output; }
    set{ output = value; }
  }
}

// "AbstractExpression"

abstract class Expression
{
  // Methods
  public void Interpret( Context context )
  {
    //string input = context.Input;
    if( context.Input.Length == 0 ) return;

    if( context.Input.StartsWith( Nine() ) )
    {
      context.Output += 9 * Multiplier();
      context.Input = context.Input.Substring(2);
    }
    else if( context.Input.StartsWith( Four() ) )
    {
      context.Output += 4 * Multiplier();
      context.Input = context.Input.Substring( 2);
    }
    else if( context.Input.StartsWith( Five() ) )
    {
      context.Output += 5 * Multiplier();
      context.Input = context.Input.Substring( 1);
    }

    while( context.Input.StartsWith( One() ) )
    {
      context.Output += 1 * Multiplier();
      context.Input = context.Input.Substring( 1 );
    }
  }

  abstract public string One();
  abstract public string Four();
  abstract public string Five();
  abstract public string Nine();
  abstract public int  Multiplier();
}

// Thousand checks for the Roman Numeral M
// "TerminalExpression"

class ThousandExpression : Expression
{
  // Methods
  override public string One() { return "M"; }
  override public string Four(){ return " "; }
  override public string Five(){ return " "; }
  override public string Nine(){ return " "; }
  override public int  Multiplier() { return 1000; }
}
// Hundred checks C, CD, D or CM
// "TerminalExpression"

class HundredExpression : Expression
{
  // Methods
  override public string One() { return "C"; }
  override public string Four(){ return "CD"; }
  override public string Five(){ return "D"; }
  override public string Nine(){ return "CM"; }
  override public int  Multiplier() { return 100; }
}
// Ten checks for X, XL, L and XC
// "TerminalExpression"

class TenExpression : Expression
{
  // Methods
  override public string One() { return "X"; }
  override public string Four(){ return "XL"; }
  override public string Five(){ return "L"; }
  override public string Nine(){ return "XC"; }
  override public int  Multiplier() { return 10; }
}

// One checks for I, II, III, IV, V, VI, VI, VII, VIII, IX
// "TerminalExpression"

class OneExpression : Expression
{
  // Methods
  override public string One() { return "I"; }
  override public string Four(){ return "IV"; }
  override public string Five(){ return "V"; }
  override public string Nine(){ return "IX"; }
  override public int  Multiplier() { return 1; }
}

/// <summary>
///   InterpreterApp Test
/// </summary>
public class InterpreterApp
{
  public static void Main( string[] args )
  {
    string roman = "MCMXXVIII";
    Context context = new Context( roman );

    // Build the 'parse tree'
    ArrayList parse = new ArrayList();
    parse.Add(new ThousandExpression());
    parse.Add(new HundredExpression());
    parse.Add(new TenExpression());
    parse.Add(new OneExpression());

    // Interpret
    foreach( Expression exp in parse )
      exp.Interpret( context );

    Console.WriteLine( "{0} = {1}", 
                   roman, context.Output );

  }
}

