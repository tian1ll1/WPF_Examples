

using System;
using System.Collections;

// "Prototype"

abstract class ColorPrototype
{
  // Methods
  public abstract ColorPrototype Clone();
}

// "ConcretePrototype"

class Color : ColorPrototype
{
  // Fields
  private int red, green, blue;

  // Constructors
  public Color( int red, int green, int blue)
  {
    this.red = red;
    this.green = green;
    this.blue = blue;
  }

  // Methods
  public override ColorPrototype Clone()
  {
    // Creates a 'shallow copy'
    return (ColorPrototype) this.MemberwiseClone();
  }

  public void Display()
  {
    Console.WriteLine( "RGB values are: {0},{1},{2}", 
                                     red, green, blue );
  }
}

// Prototype manager

class ColorManager
{
  // Fields
  Hashtable colors = new Hashtable();

  // Indexers
  public ColorPrototype this[ string name ]
  {
    get{ return (ColorPrototype)colors[ name ]; }
    set{ colors.Add( name, value ); }
  }
}

/// <summary>
///  PrototypeApp test
/// </summary>

class PrototypeApp
{
  public static void Main( string[] args )
  {
    ColorManager colormanager = new ColorManager();

    // Initialize with standard colors
    colormanager[ "red" ] = new Color( 255, 0, 0 );
    colormanager[ "green" ] = new Color( 0, 255, 0 );
    colormanager[ "blue" ] = new Color( 0, 0, 255 );

    // User adds personalized colors
    colormanager[ "angry" ] = new Color( 255, 54, 0 );
    colormanager[ "peace" ] = new Color( 128, 211, 128 );
    colormanager[ "flame" ] = new Color( 211, 34, 20 );

    // User uses selected colors
    string colorName = "red";
    Color c1 = (Color)colormanager[ colorName ].Clone();
    c1.Display();

    colorName = "peace";
    Color c2 = (Color)colormanager[ colorName ].Clone();
    c2.Display();

    colorName = "flame";
    Color c3 = (Color)colormanager[ colorName ].Clone();
    c3.Display();

    Console.Read();
  }
}
