using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmExercises.Graphs
{
    public class Node<T>
    {
//        public List<Node<T>> children;
        public Node<T> left;
        public Node<T> right;
        public T value;

        public Node(T value, Node<T> left = null, Node<T> right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }


    public class BinaryTree<T>
    {
        public Node<T> root;

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        public Node<int> GenerateRandomCompleteIntBinaryTree(int nNodes)
        {
            var random = new Random();
            var root = new Node<int>(random.Next());

            //TODO nNodes is not accurate
            root.left = GenerateRandomCompleteIntBinaryTree(nNodes - 1);
            root.right = GenerateRandomCompleteIntBinaryTree(nNodes - 1);

            return root;
        }

        public void PrintBinaryTree(Node<T> root)
        {
            var q = new Queue<Node<T>>();
            q.Enqueue(root);

            var nbNodes = 0;
            var level = 0;

            var strBuilder = new StringBuilder();

            while (q.Count > 0)
            {
                var current = q.Dequeue();
                //TODO implement a custom toString
                strBuilder.Append(current.value.ToString() + " ");
                if (Math.Pow(2, level) == nbNodes)
                {
                    nbNodes = 0;
                    level++;
                    Console.WriteLine(strBuilder);
                    //TODO set new capacity to x2
                    strBuilder.Clear();
                }

                if (current.left != null)
                    q.Enqueue(current.left);

                if (current.right != null)
                    q.Enqueue(current.right);
            }
        }
    }
}
