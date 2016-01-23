

using System;
using System.Collections;

// "FlyweightFactory"

class CharacterFactory
{
  // Fields
  private Hashtable characters = new Hashtable();

  // Methods
  public Character GetCharacter( char key )
  {
    // Uses "lazy initialization"
    Character character = (Character)characters[ key ];
    if( character == null )
    {
      switch( key )
      {
        case 'A': character = new CharacterA(); break;
        case 'B': character = new CharacterB(); break;
          //...
        case 'Z': character = new CharacterZ(); break;
      }
      characters.Add( key, character );
    }
    return character;
  }
}

// "Flyweight" 

abstract class Character
{
  // Fields
  protected char symbol;
  protected int width;
  protected int height;
  protected int ascent;
  protected int descent;
  protected int pointSize;

  // Methods
  public abstract void Draw( int pointSize );
}

// "ConcreteFlyweight"

class CharacterA : Character
{
  // Constructors
  public CharacterA( )
  {
    this.symbol = 'A';
    this.height = 100;
    this.width = 120;
    this.ascent = 70;
    this.descent = 0;
  }

  // Methods
  public override void Draw( int pointSize )
  {
    this.pointSize = pointSize;
    Console.Write( this.symbol );
  }
}

// "ConcreteFlyweight"

class CharacterB : Character
{
  // Constructors
  public CharacterB()
  {
    this.symbol = 'B';
    this.height = 100;
    this.width = 140;
    this.ascent = 72;
    this.descent = 0;
  }

  // Methods
  public override void Draw( int pointSize )
  {
    this.pointSize = pointSize;
    Console.Write( this.symbol );
  }

}

// ... C, D, E, etc.

// "ConcreteFlyweight"

class CharacterZ : Character
{
  // Constructors
  public CharacterZ( )
  {
    this.symbol = 'Z';
    this.height = 100;
    this.width = 100;
    this.ascent = 68;
    this.descent = 0;
  }

  // Methods
  public override void Draw( int pointSize )
  {
    this.pointSize = pointSize;
    Console.Write( this.symbol );
  }
}

/// <summary>
///   FlyweightApp test
/// </summary>
public class FlyweightApp
{
  public static void Main( string[] args )
  {
    // Build a document with text
    char[] document = {'A','B','Z','Z','A','A'};

    CharacterFactory f = new CharacterFactory();

    // extrinsic state
    int pointSize = 12;

    // For each character use a flyweight object
    foreach( char c in document )
    {
      Character character = f.GetCharacter( c );
      character.Draw( pointSize );
    }
  }
}
