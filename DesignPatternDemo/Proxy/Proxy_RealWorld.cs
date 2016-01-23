

using System;
using System.Runtime.Remoting;

// "Subject" 

public interface IMath
{
  // Methods
  double Add( double x, double y );
  double Sub( double x, double y );
  double Mul( double x, double y );
  double Div( double x, double y );
}

// "RealSubject" 

class Math : MarshalByRefObject, IMath
{
  // Methods
  public double Add( double x, double y ){ return x + y; }
  public double Sub( double x, double y ){ return x - y; }
  public double Mul( double x, double y ){ return x * y; }
  public double Div( double x, double y ){ return x / y; }
}

// Remote "Proxy Object" 

class MathProxy : IMath
{
  // Fields
  Math math;

  // Constructors
  public MathProxy()
  {
    // Create Math instance in a different AppDomain
    AppDomain ad = System.AppDomain.CreateDomain("MathDomain",null, null );
    ObjectHandle o = ad.CreateInstance("Proxy_RealWorld", "Math", false,
      System.Reflection.BindingFlags.CreateInstance, null, null, null,null,null );
    math = (Math) o.Unwrap();
  }

  // Methods
  public double Add( double x, double y )
  { 
    return math.Add(x,y); 
  }
  public double Sub( double x, double y )
  { 
    return math.Sub(x,y); 
  }
  public double Mul( double x, double y )
  { 
    return math.Mul(x,y); 
  }
  public double Div( double x, double y )
  { 
    return math.Div(x,y); 
  }
}
/// <summary>
///   ProxyApp test
/// </summary>

public class ProxyApp
{
  public static void Main( string[] args )
  {
    // Create math proxy
    MathProxy p = new MathProxy();

    // Do the math
    Console.WriteLine( "4 + 2 = {0}", p.Add( 4, 2 ) );
    Console.WriteLine( "4 - 2 = {0}", p.Sub( 4, 2 ) );
    Console.WriteLine( "4 * 2 = {0}", p.Mul( 4, 2 ) );
    Console.WriteLine( "4 / 2 = {0}", p.Div( 4, 2 ) );

    Console.Read();
  }
}
