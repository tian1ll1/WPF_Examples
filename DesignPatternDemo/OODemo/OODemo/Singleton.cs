

using System;

// "Singleton"

class Singleton
{
    // Fields
    private static Singleton instance;

    // Constructor
    public Singleton() { }

    // Methods
    public static Singleton Instance()
    {
        // Uses "Lazy initialization"
        if (instance == null)
            instance = new Singleton();

        return instance;
    }
}

/// <summary>
///  Client test
/// </summary>
public class Client
{
    public static void MainDemo()
    {
        // Constructor is protected -- cannot use new
        Singleton s1 = Singleton.Instance();
        Singleton s2 = Singleton.Instance();
      
        Singleton s3 = new Singleton();
        Singleton s4 = new Singleton();

        if (s1 == s2)
            Console.WriteLine("The same instance");

        Console.Read();
    }
}
