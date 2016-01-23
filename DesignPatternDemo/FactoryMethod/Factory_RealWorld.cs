

using System;
using System.Collections;

// "Product"

abstract class Page
{
}

// "ConcreteProduct"

class SkillsPage : Page
{
}

// "ConcreteProduct"

class EducationPage : Page
{
}

// "ConcreteProduct"

class ExperiencePage : Page
{
}

// "ConcreteProduct"

class IntroductionPage : Page
{
}

// "ConcreteProduct"

class ResultsPage : Page
{
}

// "ConcreteProduct"

class ConclusionPage : Page
{
}

// "ConcreteProduct"

class SummaryPage : Page
{
}

// "ConcreteProduct"

class BibliographyPage : Page
{
}

// "Creator"

abstract class Document
{
  // Fields
  protected ArrayList pages = new ArrayList();

  // Constructor
  public Document()
  {
    this.CreatePages();
  }

  // Properties 
  public ArrayList Pages
  {
    get{ return pages; }
  }

  // Factory Method
  abstract public void CreatePages();
}

// "ConcreteCreator"

class Resume : Document
{
  // Factory Method implementation
  override public void CreatePages()
  {
    pages.Add( new SkillsPage() );
    pages.Add( new EducationPage() );
    pages.Add( new ExperiencePage() );
  }
}

// "ConcreteCreator"

class Report : Document
{
  // Factory Method implementation
  override public void CreatePages()
  {
    pages.Add( new IntroductionPage() );
    pages.Add( new ResultsPage() );
    pages.Add( new ConclusionPage() );
    pages.Add( new SummaryPage() );
    pages.Add( new BibliographyPage() );
  }
}
/// <summary>
///  FactoryMethodApp test
/// </summary>

class FactoryMethodApp
{
  public static void Main( string[] args )
  {
    Document[] docs = new Document[ 2 ];

    // Note: constructors call Factory Method
    docs[0] = new Resume();
    docs[1] = new Report();

    // Display document pages
    foreach( Document document in docs )
    {
      Console.WriteLine( "\n" + document + " ------- " );
      foreach( Page page in document.Pages )
        Console.WriteLine( " " + page );
    }

    Console.Read();
  }
}
