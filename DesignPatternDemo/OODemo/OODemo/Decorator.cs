

using System;

// "Component"

abstract class Component
{
    // Methods
    abstract public void Operation();
}

// "ConcreteComponent"

class ConcreteComponent : Component
{
    // Methods
    override public void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation()");
    }
}

// "Decorator"

abstract class Decorator : Component
{
    // Fields
    protected Component component;

    // Methods
    public void SetComponent(Component component)
    {
        this.component = component;
    }

    override public void Operation()
    {
        if (component != null)
            component.Operation();
    }
}

// "ConcreteDecoratorA" 

class ConcreteDecoratorA : Decorator
{
    // Fields
    private string addedState;

    // Methods
    override public void Operation()
    {
        base.Operation();
        addedState = "new state";
        Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
}

// "ConcreteDecoratorB"

class ConcreteDecoratorB : Decorator
{
    // Methods
    override public void Operation()
    {
        base.Operation();
        AddedBehavior();
        Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior()
    {
    }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
    public static void MainDemo(string[] args)
    {
        // Create ConcreteComponent and two Decorators
        ConcreteComponent c = new ConcreteComponent();
        ConcreteDecoratorA d1 = new ConcreteDecoratorA();
        ConcreteDecoratorB d2 = new ConcreteDecoratorB();

        // Link decorators
        d1.SetComponent(c);
        d2.SetComponent(d1);

        d2.Operation();

    }
}

