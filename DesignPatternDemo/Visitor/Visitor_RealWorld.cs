

using System;
using System.Collections;

// "Visitor"

abstract class Visitor
{
  // Methods
  abstract public void Visit( Element element );
}

// "ConcreteVisitor1"

class IncomeVisitor : Visitor
{
  // Methods
  public override void Visit( Element element )
  {
    Employee employee = ((Employee)element);
    
    // Provide 10% pay raise
    employee.Income *= 1.10;
    Console.WriteLine( "{0}'s new income: {1:C}", 
                     employee.Name, employee.Income );
  }
}

// "ConcreteVisitor2"

class VacationVisitor : Visitor
{
  public override void Visit( Element element )
  {
    Employee employee = ((Employee)element);
    // Provide 3 extra vacation days
    employee.VacationDays += 3;
    Console.WriteLine( "{0}'s new vacation days: {1}", 
               employee.Name, employee.VacationDays );
  }
}

// "Element" 

abstract class Element
{
  // Methods
  abstract public void Accept( Visitor visitor );
}

// "ConcreteElement"

class Employee : Element
{
  // Fields
  string name;
  double income;
  int vacationDays;

  // Constructors
  public Employee( string name, double income, 
                                   int vacationDays )
  {
    this.name = name;
    this.income = income;
    this.vacationDays = vacationDays;
  }

  // Properties
  public string Name
  {
    get{ return name; }
    set{ name = value; }
  }

  public double Income
  {
    get{ return income; }
    set{ income = value; }
  }

  public int VacationDays
  {
    get{ return vacationDays; }
    set{ vacationDays = value; }
  }

  // Methods
  public override void Accept( Visitor visitor )
  {
    visitor.Visit( this );
  }
}

// "ObjectStructure"

class Employees
{
  // Fields
  private ArrayList employees = new ArrayList();

  // Methods
  public void Attach( Employee employee )
  {
    employees.Add( employee );
  }

  public void Detach( Employee employee )
  {
    employees.Remove( employee );
  }

  public void Accept( Visitor visitor )
  {
    foreach( Employee e in employees )
      e.Accept( visitor );
  }
}

/// <summary>
///   VisitorApp test
/// </summary>
public class VisitorApp
{
  public static void Main( string[] args )
  {
    // Setup employee collection
    Employees e = new Employees();
    e.Attach( new Employee( "Hank", 25000.0, 14 ) );
    e.Attach( new Employee( "Elly", 35000.0, 16 ) );
    e.Attach( new Employee( "Dick", 45000.0, 21 ) );

    // Create two visitors
    IncomeVisitor v1 = new IncomeVisitor();
    VacationVisitor v2 = new VacationVisitor();

    // Employees are visited
    e.Accept( v1 );
    e.Accept( v2 );

  }
}
