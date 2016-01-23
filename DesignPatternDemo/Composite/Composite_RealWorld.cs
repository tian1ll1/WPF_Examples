

using System;
using System.Collections;

// "Component"

abstract class DrawingElement
{
  // Fields
  protected string name;

  // Constructors
  public DrawingElement( string name )
  {
    this.name = name;
  }
  
  // Methods
  abstract public void Add(DrawingElement d);
  abstract public void Remove( DrawingElement d );
  abstract public void Display( int indent );
}

// "Leaf" 

class PrimitiveElement : DrawingElement
{
  public PrimitiveElement( string name ) : base( name ) {}

  public override void Add( DrawingElement c )
  {
    Console.WriteLine("Cannot add to a PrimitiveElement");
  }
  public override void Remove( DrawingElement c )
  {
    Console.WriteLine("Cannot remove from a PrimitiveElement");
  }
  public override void Display( int indent )
  {
    Console.WriteLine( new String( '-', indent ) + " draw a {0}", name );
  }
}

// "Composite" 

class CompositeElement : DrawingElement
{
  // Fields
  private ArrayList elements = new ArrayList();
	
  // Constructors
  public CompositeElement( string name ) 
                              : base( name ) {}

  // Methods
  public override void Add( DrawingElement d )
  {
    elements.Add( d );
  }

  public override void Remove( DrawingElement d )
  {
    elements.Remove( d );
  }

  public override void Display( int indent )
  {
    Console.WriteLine( new String( '-', indent ) + 
                                  "+ " + name );

    // Display each child element on this node
    foreach( DrawingElement c in elements )
      c.Display( indent + 2 );
  }
}


/// <summary>
///    Summary description for Client.
/// </summary>
public class Client
{
  public static void Main( string[] args )
  {   
    // Create a tree structure 
    CompositeElement root = new CompositeElement( "Picture" );
    root.Add( new PrimitiveElement( "Red Line" ));
    root.Add( new PrimitiveElement( "Blue Circle" ));
    root.Add( new PrimitiveElement( "Green Box" ));

    CompositeElement comp = new CompositeElement( "Two Circles" );
    comp.Add( new PrimitiveElement( "Black Circle" ) );
    comp.Add( new PrimitiveElement( "White Circle" ) );
    root.Add( comp );

    // Add and remove a PrimitiveElement
    PrimitiveElement l = new PrimitiveElement( "Yellow Line" );
    root.Add( l );
    root.Remove( l );

    // Recursively display nodes
    root.Display( 1 );
  }
}

