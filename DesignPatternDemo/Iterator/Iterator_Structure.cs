


using System;
using System.Collections;

// "Aggregate" 

abstract class Aggregate
{
  // Methods
  public abstract Iterator CreateIterator();
}

// "ConcreteAggregate" 

class ConcreteAggregate : Aggregate
{
  // Fields
  private ArrayList items = new ArrayList();

  // Methods
  public override Iterator CreateIterator()
  {
    return new ConcreteIterator( this );
  }

  // Properties
  public int Count
  {
    get{ return items.Count; }
  }

  // Indexers
  public object this[ int index ]
  {
    get{ return items[ index ]; }
    set{ items.Insert( index, value ); }
  }
}

// "Iterator"

abstract class Iterator
{
  // Methods
  public abstract object First();
  public abstract object Next();
  public abstract bool IsDone();
  public abstract object CurrentItem();
}

// "ConcreteIterator" 

class ConcreteIterator : Iterator
{
  // Fields
  private ConcreteAggregate aggregate;
  private int current = 0;

  // Constructor
  public ConcreteIterator( ConcreteAggregate aggregate )
  {
    this.aggregate = aggregate;
  }

  // Methods
  override public object First()
  {
    return aggregate[ 0 ];
  }

  override public object Next()
  {
    if( current < aggregate.Count-1 )
      return aggregate[ ++current ];
    else
      return null;
  }

  override public object CurrentItem()
  {
    return aggregate[ current ];
  }

  override public bool IsDone()
  {
    return current >= aggregate.Count ? true : false ;
  }
}

/// <summary>
///  Client test
/// </summary>
public class Client
{
  public static void Main(string[] args)
  {   
    ConcreteAggregate a = new ConcreteAggregate();
    a[0] = "Item A";
    a[1] = "Item B";
    a[2] = "Item C";
    a[3] = "Item D";

    // Create Iterator and provide aggregate
    ConcreteIterator i = new ConcreteIterator(a);

    // Iterate over collection
    object item = i.First();

    while( item != null )
    {
      Console.WriteLine( item );
      item = i.Next();
    } 
  }
}
