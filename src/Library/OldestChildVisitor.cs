using System;

namespace Library;

public class OldestChildVisitor : IVisitor<Person>
{
    public int OldestAge { get; private set; } = int.MinValue;

    public void Visit(Node<Person> node)
    {
        if (node.Children.Count == 0) // Nodo hoja
        {
            OldestAge = Math.Max(OldestAge, node.Value.Age);
        }

        foreach (Node<Person> child in node.Children)
        {
            child.Accept(this);
        }
    }
    
}