namespace Library;

public class SumAgesVisitor : IVisitor<Person>
{
    public int TotalAge { get; private set; } = 0;

    public void Visit(Node<Person> node)
    {
        TotalAge += node.Value.Age;
        foreach (Node<Person> child in node.Children)
        {
            child.Accept(this);
        }
    }

   
}