
using System;

// "Target" 

class Target
{
    // Methods
    virtual public void Request()
    {
        // Normal implementation goes here
    }
}

// "Adapter" 

class Adapter : Target
{
    // Fields
    private Adaptee adaptee = new Adaptee();

    // Methods
    override public void Request()
    {
        adaptee.SpecificRequest();

        base.Request();
        // Possibly do some data manipulation
        //   and then call SpecificRequest
       
    }
}

// "Adaptee"

class Adaptee
{
    // Methods
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}

/// <summary>
///   Client test 
/// </summary>
public class Client
{
    public static void MainDemo(string[] args)
    {
        // Create adapter and place a request
        Target t = new Adapter();
        t.Request();

    }
}
