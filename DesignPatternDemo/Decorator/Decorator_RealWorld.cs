

using System;
using System.Collections;

// "Component" 

abstract class LibraryItem
{
  // Fields
  private int numCopies;

  // Properties
  public int NumCopies
  {
    get{ return numCopies; }
    set{ numCopies = value; }
  }

  // Methods
  public abstract void Display();
}

// "ConcreteComponent" 

class Book : LibraryItem
{
  // Fields
  private string author;
  private string title;

  // Constructors
  public Book(string author,string title,int numCopies)
  {
    this.author = author;
    this.title = title;
    this.NumCopies = numCopies;
  }

  // Methods
  public override void Display()
  {
    Console.WriteLine( "\nBook ------ " );
    Console.WriteLine( " Author: {0}", author );
    Console.WriteLine( " Title: {0}", title );
    Console.WriteLine( " # Copies: {0}", NumCopies );
  }
}

// "ConcreteComponent"

class Video : LibraryItem
{
  // Fields
  private string director;
  private string title;
  private int playTime;

  // Constructor
  public Video( string director, string title, 
              int numCopies, int playTime )
  {
    this.director = director;
    this.title = title;
    this.NumCopies = numCopies;
    this.playTime = playTime;
  }

  // Methods
  public override void Display()
  {
    Console.WriteLine( "\nVideo ----- " );
    Console.WriteLine( " Director: {0}", director );
    Console.WriteLine( " Title: {0}", title );
    Console.WriteLine( " # Copies: {0}", NumCopies );
    Console.WriteLine( " Playtime: {0}", playTime );
  }
}

// "Decorator"

abstract class Decorator : LibraryItem
{
  // Fields
  protected LibraryItem libraryItem;

  // Constructors
  public Decorator ( LibraryItem libraryItem )
  {
    this.libraryItem = libraryItem;
  }

  // Methods
  public override void Display()
  {
    libraryItem.Display();
  }
}

// "ConcreteDecorator"

class Borrowable : Decorator
{
  // Fields
  protected ArrayList borrowers = new ArrayList();

  // Constructors
  public Borrowable( LibraryItem libraryItem )
    : base( libraryItem ) {}

  // Methods
  public void BorrowItem( string name )
  {
    borrowers.Add( name );
    libraryItem.NumCopies--;
  }

  public void ReturnItem( string name )
  {
    borrowers.Remove( name );
    libraryItem.NumCopies++;
  }

  public override void Display()
  {
    base.Display();
    foreach( string borrower in borrowers )
       Console.WriteLine( " borrower: {0}", borrower );
  }
}


/// <summary>
///   DecoratorApp test
/// </summary>
public class DecoratorApp
{
  public static void Main( string[] args )
  {
    // Create book and video and display
    Book book = new Book( "Schnell", "My Home", 10 );
    Video video = new Video( "Spielberg", 
                     "Schindler's list", 23, 60 );

    book.Display();
    video.Display();

    // Make video borrowable, then borrow and display
    Console.WriteLine( "\nVideo made borrowable:" );
    Borrowable borrowvideo = new Borrowable( video );
    borrowvideo.BorrowItem( "Cindy Lopez" );
    borrowvideo.BorrowItem( "Samuel King" );

    borrowvideo.Display();

  }
}

