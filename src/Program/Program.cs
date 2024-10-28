using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Person> root = new Node<Person>(new Person("Abuelo", 80));
            Node<Person> parent1 = new Node<Person>(new Person("Padre1", 50));
            Node<Person> parent2 = new Node<Person>(new Person("Padre2", 48));
            Node<Person> child1 = new Node<Person>(new Person("Hijo1", 20));
            Node<Person> child2 = new Node<Person>(new Person("Hijo2", 18));
            Node<Person> child3 = new Node<Person>(new Person("Hijo3", 16));
            Node<Person> child4 = new Node<Person>(new Person("Hijo4", 15));

            root.AddChild(parent1);
            root.AddChild(parent2);

            parent1.AddChild(child1);
            parent1.AddChild(child2);

            parent2.AddChild(child3);
            parent2.AddChild(child4);

            SumAgesVisitor sumAgesVisitor = new SumAgesVisitor();
            root.Accept(sumAgesVisitor);
            Console.WriteLine("Suma de las edades: " + sumAgesVisitor.TotalAge);

            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();
            root.Accept(oldestChildVisitor);
            Console.WriteLine("Edad del hijo más grande: " + oldestChildVisitor.OldestAge);

            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            root.Accept(longestNameVisitor);
            Console.WriteLine("Nombre más largo: " + longestNameVisitor.LongestName);
        }
    }
}
