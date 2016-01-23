


using System;
using System.Collections;
using System.Threading;

// "Singleton"

class LoadBalancer
{
  // Fields
  private static LoadBalancer balancer;
  private ArrayList servers = new ArrayList();
  private Random random = new Random();

  // Constructors (protected)
  protected LoadBalancer() 
  {
    // List of available servers
    servers.Add( "ServerI" );
    servers.Add( "ServerII" );
    servers.Add( "ServerIII" );
    servers.Add( "ServerIV" );
    servers.Add( "ServerV" );
  }

  // Methods
  public static LoadBalancer GetLoadBalancer()
  {
    // Support multithreaded applications through
    // "Double checked locking" pattern which avoids 
    // locking every time the method is invoked
    if( balancer == null )
    {
      // Only one thread can obtain a mutex
      Mutex mutex = new Mutex();
      mutex.WaitOne();

      if( balancer == null )
        balancer = new LoadBalancer();

      mutex.Close();
    }
    
    return balancer;
  }

  // Properties
  public string Server
  {
    get
    {
      // Simple, but effective random load balancer
      int r = random.Next( servers.Count );
      return servers[ r ].ToString();
    }
  }
}

/// <summary>
///  SingletonApp test
/// </summary>
/// 
public class SingletonApp
{
  public static void Main( string[] args )
  {
    LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
    LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
    LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
    LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

    // Same instance?
    if( (b1 == b2) && (b2 == b3) && (b3 == b4) )
      Console.WriteLine( "Same instance" );

    // Do the load balancing
    Console.WriteLine( b1.Server );
    Console.WriteLine( b2.Server );
    Console.WriteLine( b3.Server );
    Console.WriteLine( b4.Server );

    Console.Read();
  }
}
