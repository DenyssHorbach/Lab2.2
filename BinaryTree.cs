using System;

public class BinaryTree<T> where T : class
{
    public Node<T>? Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (Root == null)
        {
            Root = newNode;
        }
        else
        {
            if (Root.Left == null)
                Root.Left = newNode;
            else if (Root.Right == null)
                Root.Right = newNode;
            else
                Console.WriteLine("tree is done");
        }
    }
}