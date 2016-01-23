

using System;
using System.Collections;

// "Director"

class Shop
{
  // Methods
  public void Construct( VehicleBuilder vehicleBuilder )
  {
    vehicleBuilder.BuildFrame();
    vehicleBuilder.BuildEngine();
    vehicleBuilder.BuildWheels();
    vehicleBuilder.BuildDoors();
  }
}

// "Builder"

abstract class VehicleBuilder
{
  // Fields
  protected Vehicle vehicle;

  // Properties
  public Vehicle Vehicle
  {
    get{ return vehicle; }
  }

  // Methods
  abstract public void BuildFrame();
  abstract public void BuildEngine();
  abstract public void BuildWheels();
  abstract public void BuildDoors();
}

// "ConcreteBuilder1"

class MotorCycleBuilder : VehicleBuilder
{
  // Methods
  override public void BuildFrame()
  {
    vehicle = new Vehicle( "MotorCycle" );
    vehicle[ "frame" ] = "MotorCycle Frame";
  }

  override public void BuildEngine()
  {
    vehicle[ "engine" ] = "500 cc";
  }

  override public void BuildWheels()
  {
    vehicle[ "wheels" ] = "2";
  }

  override public void BuildDoors()
  {
    vehicle[ "doors" ] = "0";
  }
}

// "ConcreteBuilder2"

class CarBuilder : VehicleBuilder
{
  // Methods
  override public void BuildFrame()
  {
    vehicle = new Vehicle( "Car" );
    vehicle[ "frame" ] = "Car Frame";
  }

  override public void BuildEngine()
  {
    vehicle[ "engine" ] = "2500 cc";
  }

  override public void BuildWheels()
  {
    vehicle[ "wheels" ] = "4";
  }

  override public void BuildDoors()
  {
    vehicle[ "doors" ] = "4";
  }
}

// "ConcreteBuilder3"

class ScooterBuilder : VehicleBuilder
{
  // Methods
  override public void BuildFrame()
  {
    vehicle = new Vehicle( "Scooter" );
    vehicle[ "frame" ] = "Scooter Frame";
  }

  override public void BuildEngine()
  {
    vehicle[ "engine" ] = "none";
  }

  override public void BuildWheels()
  {
    vehicle[ "wheels" ] = "2";
  }

  override public void BuildDoors()
  {
    vehicle[ "doors" ] = "0";
  }
}

// "Product" 

class Vehicle
{
  // Fields
  private string type;
  private Hashtable parts = new Hashtable();

  // Constructors
  public Vehicle( string type )
  {
    this.type = type;
  }

  // Indexers
  public object this[ string key ]
  {
    get{ return parts[ key ]; }
    set{ parts[ key ] = value; }
  }

  // Methods
  public void Show()
  {
    Console.WriteLine( "\n---------------------------");
    Console.WriteLine( "Vehicle Type: {0}", type );
    Console.WriteLine( " Frame  : {0}", parts[ "frame" ] );
    Console.WriteLine( " Engine : {0}", parts[ "engine" ] );
    Console.WriteLine( " #Wheels: {0}", parts[ "wheels" ] );
    Console.WriteLine( " #Doors : {0}", parts[ "doors" ] );
  }
}
/// <summary>
///   BuilderApp test
/// </summary>
public class BuilderApp
{
  public static void Main( string[] args )
  {
    // Create shop with vehicle builders
    Shop shop = new Shop();
    VehicleBuilder b1 = new ScooterBuilder();
    VehicleBuilder b2 = new CarBuilder();
    VehicleBuilder b3 = new MotorCycleBuilder();

    // Construct and display vehicles
    shop.Construct( b1 );
    b1.Vehicle.Show();

    shop.Construct( b2 );
    b2.Vehicle.Show();

    shop.Construct( b3 );
    b3.Vehicle.Show();
  }
}
