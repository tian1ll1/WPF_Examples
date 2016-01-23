using System;

// "AbstractFactory"

abstract class ContinentFactory
{
    // Methods
    abstract public Herbivore CreateHerbivore();
    abstract public Carnivore CreateCarnivore();
}

// "ConcreteFactory1"

class AfricaFactory : ContinentFactory
{
    // Methods
    override public Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }
    override public Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}

// "ConcreteFactory2"

class AmericaFactory : ContinentFactory
{
    // Methods
    override public Herbivore CreateHerbivore()
    {
        return new Bison();
    }
    override public Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}

// "AbstractProductA"

abstract class Herbivore
{
}

// "AbstractProductB"

abstract class Carnivore
{
    // Methods
    abstract public void Eat(Herbivore h);
}

// "ProductA1"

class Wildebeest : Herbivore
{
}

// "ProductB1"

class Lion : Carnivore
{
    // Methods
    override public void Eat(Herbivore h)
    {
        // eat wildebeest
        Console.WriteLine(this + " eats " + h);
    }
}

// "ProductA2"

class Bison : Herbivore
{
}

// "ProductB2"

class Wolf : Carnivore
{
    // Methods
    override public void Eat(Herbivore h)
    {
        // Eat bison
        Console.WriteLine(this + " eats " + h);
    }
}

// "Client" 

class AnimalWorld
{
    // Fields
    private Herbivore herbivore;
    private Carnivore carnivore;

    // Constructors
    public AnimalWorld(ContinentFactory factory)
    {
        carnivore = factory.CreateCarnivore();
        herbivore = factory.CreateHerbivore();
    }

    // Methods
    public void RunFoodChain()
    {
        carnivore.Eat(herbivore);
    }
}

/// <summary>
///  GameApp test class
/// </summary>

//class GameApp
//{
//    public static void Main(string[] args)
//    {
//        // Create and run the Africa animal world
//        ContinentFactory africa = new AfricaFactory();
//        AnimalWorld world = new AnimalWorld(africa);
//        world.RunFoodChain();

//        // Create and run the America animal world
//        ContinentFactory america = new AmericaFactory();
//        world = new AnimalWorld(america);
//        world.RunFoodChain();

//        Console.Read();
//    }
//}
