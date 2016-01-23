using System;

// "AbstractFactory"

abstract class AbstractFactory
{
    // Methods
    abstract public AbstractProductA CreateProductA();
    abstract public AbstractProductB CreateProductB();

    //abstract public AbstractProductC CreateProductC();
}

// "ConcreteFactory1"

class ConcreteFactory1 : AbstractFactory
{
    // Methods
    override public AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
    override public AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}

// "ConcreteFactory2"

class ConcreteFactory2 : AbstractFactory
{
    // Methods
    override public AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
    override public AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}

// "AbstractProductA"

abstract class AbstractProductA
{
}

// "AbstractProductB"

abstract class AbstractProductB
{
    // Methods
    abstract public void Interact(AbstractProductA a);
}

// "ProductA1"


class ProductA1 : AbstractProductA
{
}

// "ProductB1"

class ProductB1 : AbstractProductB
{
    // Methods
    override public void Interact(AbstractProductA a)
    {
        Console.WriteLine(this + " interacts with " + a);
    }
}

// "ProductA2"

class ProductA2 : AbstractProductA
{
}

// "ProductB2"

class ProductB2 : AbstractProductB
{
    // Methods
    override public void Interact(AbstractProductA a)
    {
        Console.WriteLine(this + " interacts with " + a);
    }
}

// "Client" - the interaction environment of the products

//Context
class Environment
{
    // Fields
    private AbstractProductA AbstractProductA;
    private AbstractProductB AbstractProductB;

    // Constructors
    public Environment(AbstractFactory factory)
    {
        AbstractProductB = factory.CreateProductB(); //child B
        AbstractProductA = factory.CreateProductA(); // child A
    }

    // Methods
    public void Run()
    {
        AbstractProductB.Interact(AbstractProductA);
    }
}

/// <summary>
///  ClientApp test environment
/// </summary>

class ClientApp
{
    public static void Demo(string[] args)
    {
        AbstractFactory factory1 = new ConcreteFactory1();
        Environment e1 = new Environment(factory1);
        e1.Run();

        AbstractFactory factory2 = new ConcreteFactory2();
        Environment e2 = new Environment(factory2);
        e2.Run();

        Console.Read();
    }
}
