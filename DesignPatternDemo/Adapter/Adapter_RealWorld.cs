using System;

// "Target"

class ChemicalCompound
{
  // Fields
  protected string name;
  protected float boilingPoint;
  protected float meltingPoint;
  protected double molecularWeight;
  protected string molecularFormula;

  // Constructors
  public ChemicalCompound( string name )
  {
    this.name = name;
  }

  // Properties
  public float BoilingPoint
  {
    get{ return boilingPoint; }
  }

  public float MeltingPoint
  {
    get{ return meltingPoint;  }
  }

  public double MolecularWeight
  {
    get{ return molecularWeight; }
  }

  public string MolecularFormula
  {
    get{ return molecularFormula; }
  }
}

// "Adapter"

class Compound : ChemicalCompound
{
  // Fields
  private ChemicalDatabank bank;

  // Constructors
  public Compound( string name ) : base( name )
  {
    // Adaptee
    bank = new ChemicalDatabank();

    // Adaptee request methods
    boilingPoint = bank.GetCriticalPoint( name, "B" );
    meltingPoint = bank.GetCriticalPoint( name, "M" );
    molecularWeight = bank.GetMolecularWeight( name );
    molecularFormula = bank.GetMolecularStructure( name );
  }

  // Methods
  public void Display()
  {
    Console.WriteLine("\nCompound: {0} ------ ",name );
    Console.WriteLine(" Formula: {0}",MolecularFormula);
    Console.WriteLine(" Weight : {0}",MolecularWeight );
    Console.WriteLine(" Melting Pt: {0}",MeltingPoint );
    Console.WriteLine(" Boiling Pt: {0}",BoilingPoint );
  }
}

// "Adaptee"

class ChemicalDatabank
{
  // Methods -- the Databank 'legacy API'
  public float GetCriticalPoint( string compound, string point )
  {
    float temperature = 0.0F;

    // Melting Point
    if( point == "M" )
    {
      switch( compound.ToLower() )
      {
        case "water": temperature = 0.0F;break;
        case "benzene" : temperature = 5.5F; break;
        case "alcohol": temperature = -114.1F; break;
      }
    }
    // Boiling Point
    else
    {
      switch( compound.ToLower() )
      {
        case "water": temperature = 100.0F;break;
        case "benzene" : temperature = 80.1F; break;
        case "alcohol": temperature = 78.3F; break;
      }
    }
    return temperature;
  }

  public string GetMolecularStructure( string compound )
  {
    string structure = "";

    switch( compound.ToLower() )
    {
      case "water": structure = "H20"; break;
      case "benzene" : structure = "C6H6"; break;
      case "alcohol": structure = "C2H6O2"; break;
    }
    return structure;
  }

  public double GetMolecularWeight( string compound )
  {
    double weight = 0.0;
    switch( compound.ToLower() )
    {
      case "water": weight = 18.015; break;
      case "benzene" : weight = 78.1134; break;
      case "alcohol": weight = 46.0688; break;
    }
    return weight;
  }
}

/// <summary>
///   AdapterApp test application
/// </summary>
public class AdapterApp
{
  public static void Main(string[] args)
  {
    // Retrieve and display water characteristics
    Compound water = new Compound( "Water" );
    water.Display();

    // Retrieve and display benzene characteristics
    Compound benzene = new Compound( "Benzene" );
    benzene.Display();

    // Retrieve and display alcohol characteristics
    Compound alcohol = new Compound( "Alcohol" );
    alcohol.Display();

    Console.Read();
  }
}
