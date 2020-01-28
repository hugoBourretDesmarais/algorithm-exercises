using System;
using System.Collections.Generic;

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

        public Node<int> GenerateCompleteIntBinaryTree(int nNodes)
        {
            var random = new Random();
            var root = new Node<int>(random.Next());
            var current = root;
            for (int i = 0; i < nNodes; i++)
            {
                var left = new Node<int>(random.Next());
                var right = new Node<int>(random.Next());


            }

            return root;
        }
    }
}
