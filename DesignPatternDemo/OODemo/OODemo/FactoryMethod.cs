


using System;
using System.Collections;

// "Product" 

abstract class Product
{
}

// "ConcreteProductA" 

class ConcreteProductA : Product
{
}

// "ConcreteProductB" 

class ConcreteProductB : Product
{
}

// "Creator"

abstract class Creator
{
    // Methods
    abstract public Product FactoryMethod();
}

// "ConcreteCreator"

class ConcreteCreatorA : Creator
{
    // Methods
    override public Product FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

// "ConcreteCreator"

class ConcreteCreatorB : Creator
{
    // Methods
    override public Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

/// <summary>
///  Client test
/// </summary>
class Client
{
    public static void MainDemo(string[] args)
    {
        // FactoryMethod returns ProductA
        Creator c = new ConcreteCreatorA();
        Product p = c.FactoryMethod();
        Console.WriteLine("Created {0}", p);

        // FactoryMethod returns ProductB
        c = new ConcreteCreatorB();
        p = c.FactoryMethod();
        Console.WriteLine("Created {0}", p);

    }
}
