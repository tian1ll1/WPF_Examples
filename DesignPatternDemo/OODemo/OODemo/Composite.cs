
using System;
using System.Text;
using System.Collections;

// "Component" 

abstract class Component
{
    // Fields
    protected string name;

    // Constructors
    public Component(string name)
    {
        this.name = name;
    }

    // Methods
    abstract public void Add(Component c);
    abstract public void Remove(Component c);
    abstract public void Display(int depth);
}

// "Composite" 

class Composite : Component
{
    // Fields
    private ArrayList children = new ArrayList();

    // Constructors
    public Composite(string name) : base(name) { }

    // Methods
    public override void Add(Component component)
    {
        children.Add(component);
    }

    public override void Remove(Component component)
    {
        children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
        // Display each of the node's children
        foreach (Component component in children)
            component.Display(depth + 2);
    }
}

// "Leaf" 

class Leaf : Component
{
    // Constructors
    public Leaf(string name) : base(name) { }

    // Methods
    public override void Add(Component c)
    {
        Console.WriteLine("Cannot add to a leaf");
    }
    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
    }
}

/// <summary>
///   Client test
/// </summary>
public class Client
{
    public static void MainDemo(string[] args)
    {
        // Create a tree structure
        Composite root = new Composite("root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        Composite comp = new Composite("Composite X");
        comp.Add(new Leaf("Leaf XA"));
        comp.Add(new Leaf("Leaf XB"));

        root.Add(comp);
        root.Add(new Leaf("Leaf C"));

        // Add and remove a leaf
        Leaf l = new Leaf("Leaf D");
        root.Add(l);
        root.Remove(l);

        // Recursively display nodes
        root.Display(1);

    }
}
