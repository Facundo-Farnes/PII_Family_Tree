namespace Library;

public class LongestNameVisitor : IVisitor<Person>
{
    public string LongestName { get; private set; } = "";

    public void Visit(Node<Person> node)
    {
        if (node.Value.Name.Length > LongestName.Length)
        {
            LongestName = node.Value.Name;
        }

        foreach (Node<Person> child in node.Children)
        {
            child.Accept(this);
        }
    }

}
