using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T> 
    {
        private T value;
        private List<Node<T>> children = new List<Node<T>>();

        public T Value => this.value;

        public ReadOnlyCollection<Node<T>> Children => this.children.AsReadOnly();

        public Node(T value)
        {
            this.value = value;
        }

        public void AddChild(Node<T> child)
        {
            this.children.Add(child);
        }
        
        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
            foreach (Node<T> child in children)
            {
                child.Accept(visitor);
            }
        }
    }
}
