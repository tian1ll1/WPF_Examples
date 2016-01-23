

using System;
using System.Collections;

// "Strategy"

abstract class SortStrategy
{
  // Methods
  abstract public void Sort( ArrayList list );
}

// "ConcreteStrategy" 

class QuickSort : SortStrategy
{
  // Methods
  public override void Sort(ArrayList list )
  {
    list.Sort();  // Default is Quicksort
    Console.WriteLine("QuickSorted list ");
  }
}

// "ConcreteStrategy" 

class ShellSort : SortStrategy
{
  // Methods
  public override void Sort(ArrayList list )
  {
    //list.ShellSort();
    Console.WriteLine("ShellSorted list ");
  }
}

// "ConcreteStrategy" 

class MergeSort : SortStrategy
{
  // Methods
  public override void Sort( ArrayList list )
  {
    //list.MergeSort();
    Console.WriteLine("MergeSorted list ");
  }
}

// "Context" 

class SortedList
{
  // Fields
  private ArrayList list = new ArrayList();
  private SortStrategy sortstrategy;

  // Constructors
  public void SetSortStrategy( SortStrategy sortstrategy )
  {
    this.sortstrategy = sortstrategy;
  }

  // Methods
  public void Sort()
  {
    sortstrategy.Sort( list );
  }
  public void Add( string name )
  {
    list.Add( name );
  }
  public void Display()
  {
    foreach( string name in list )
      Console.WriteLine( " " + name );
  }
}

/// <summary>
///   StrategyApp test
/// </summary>
public class StrategyApp
{
  public static void Main( string[] args )
  {
    // Two contexts following different strategies
    SortedList studentRecords = new SortedList( );

    studentRecords.Add( "Samual" );
    studentRecords.Add( "Jimmy" );
    studentRecords.Add( "Sandra" );
    studentRecords.Add( "Anna" );
    studentRecords.Add( "Vivek" );

    studentRecords.SetSortStrategy( new QuickSort() );

    studentRecords.Sort();
    studentRecords.Display();

  }
}

