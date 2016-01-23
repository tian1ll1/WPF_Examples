

using System;
using System.Collections;

class Item
{
  // Fields
  string name;

  // Constructors
  public Item( string name )
  {
    this.name = name;
  }

  // Properties
  public string Name
  {
    get{ return name; }
  }
}

// "Aggregate"

abstract class AbstractCollection
{
  abstract public Iterator CreateIterator();
}

// "ConcreteAggregate" 

class Collection : AbstractCollection
{
  // Fields
  private ArrayList items = new ArrayList();

  // Methods
  public override Iterator CreateIterator()
  {
    return new Iterator( this );
  }
  // Properties
  public int Count
  {
    get{ return items.Count; }
  }
  // Indexers
  public object this[ int index ]
  {
    get{  return items[ index ]; }
    set{ items.Add( value ); }
  }
}

//  "Iterator" 

abstract class AbstractIterator
{
  // Methods
  abstract public Item First();
  abstract public Item Next();
  abstract public bool IsDone();
  abstract public Item CurrentItem();
}

// "ConcreteIterator" 

class Iterator : AbstractIterator
{
  // Fields
  private Collection collection;
  private int current = 0;
  private int step = 1;

  // Constructor
  public Iterator( Collection collection )
  {
    this.collection = collection;
  }

  // Properties
  public int Step
  {
    get{ return step; }
    set{ step = value; }
  }

  // Methods
  override public Item First()
  {
    current = 0;
    return (Item)collection[ current ];
  }

  override public Item Next()
  {
    current += step;
    if( !IsDone() )
      return (Item)collection[ current ];
    else
      return null;
  }

  override public Item CurrentItem()
  {
    return (Item)collection[ current ];
  }

  override public bool IsDone()
  {
    return current >= collection.Count  ? true : false ;
  }
}

/// <summary>
///   IteratorApp test
/// </summary>
public class IteratorApp
{
  public static void Main(string[] args)
  {
    // Build a collection
    Collection collection = new Collection();
    collection[0] = new Item( "Item 0" );
    collection[1] = new Item( "Item 1" );
    collection[2] = new Item( "Item 2" );
    collection[3] = new Item( "Item 3" );
    collection[4] = new Item( "Item 4" );
    collection[5] = new Item( "Item 5" );
    collection[6] = new Item( "Item 6" );
    collection[7] = new Item( "Item 7" );
    collection[8] = new Item( "Item 8" );

    // Create iterator
    Iterator iterator = new Iterator( collection );
    
    // Skip every other item
    iterator.Step = 2;

    // Loop using iterator
    for( Item item = iterator.First(); 
         !iterator.IsDone(); item = iterator.Next() )
    {
      Console.WriteLine( item.Name );
    }

    Console.Read();
  }
}
