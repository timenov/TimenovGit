using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.BalancedTree
{
    class BinarySearchTree<T> : ICloneable, IEnumerable<T>
        where T : IComparable<T>
    {
        private class TreeNode
        {
            private T value;
            private TreeNode parent;
            private TreeNode left;
            private TreeNode right;

            public T Value
            {
                get { return this.value; }
                set { this.value = value; }
            }
            public TreeNode Parent
            {
                get { return this.parent; }
                set { this.parent = value; }
            }
            public TreeNode Left
            {
                get { return this.left; }
                set { this.left = value; }
            }
            public TreeNode Right
            {
                get { return this.right; }
                set { this.right = value; }
            }

            public TreeNode(T value)
            {
                this.Value = value;
                this.Parent = null;
                this.Left = null;
                this.Right = null;
            }
        }

        private TreeNode root;
        private int count;
        private int tempHash;

        private TreeNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public BinarySearchTree()
        {
            this.Root = null;
            this.Count = 0;
        }

        public void Add(T value)
        {
            if (this.Root == null)
            {
                this.Root = new TreeNode(value);
            }
            else
            {
                Insert(this.Root, value);
            }
            this.Count++;
            this.tempHash |= value.GetHashCode();
        }

        private void Insert(TreeNode node, T value)
        {
            if (value.CompareTo(node.Value) == -1)
            {
                if (node.Left == null)
                    node.Left = new TreeNode(value);
                else
                    Insert(node.Left, value);
            }
            else
            {
                if (node.Right == null)
                    node.Right = new TreeNode(value);
                else
                    Insert(node.Right, value);
            }
        }

        public TreeNode Find(T value)
        {
            TreeNode node = this.Root;
            if (value.CompareTo(node.Value) == 0)
            {
                return node;
            }
            else
            {
                while (node != null)
                {
                    if (value.CompareTo(node.Value) < 0)
                        node = node.Left;
                    else
                        node = node.Right;
                }
                return node;
            }
        }

        public void Remove(T value)
        {
            TreeNode node = new TreeNode(value);
            if (node.Left == null && node.Right == null)
            {
                TreeNode replacement = node.Right;
                while (replacement.Left != null)
                {
                    replacement = replacement.Left;
                }
                node.Value = replacement.Value;
                node = replacement;
            }

            TreeNode theChild = node.Left != null ? node.Left : node.Right;
            
            if (theChild != null)
            {
                theChild.Parent = node.Parent;

                if (node.Parent == null)
                {
                    root = theChild;
                }
                else
                {
                    if (node.Parent.Left == node)
                    {
                        node.Parent.Left = theChild;
                    }
                    else
                    {
                        node.Parent.Right = theChild;
                    }
                }
            }
            else
            {
                if (node.Parent == null)
                {
                    root = null;
                }
                else
                {
                    if (node.Parent.Left == null)
                    {
                        node.Parent.Left = null;
                    }
                    else
                    {
                        node.Parent.Right = null;
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Join<T>(", ", this);
        }

        public override int GetHashCode()
        {
            return this.tempHash | this.Count;
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode() ? true : false;
        }

        public static bool operator ==(BinarySearchTree<T> first, BinarySearchTree<T> second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BinarySearchTree<T> first, BinarySearchTree<T> second)
        {
            return first.Equals(second);
        }

        public BinarySearchTree<T> Clone()
        {
            return (BinarySearchTree<T>)this.MemberwiseClone();
        }

        private IEnumerable<T> Traverse(TreeNode root)
        {
            if (root != null)
            {
                foreach (var item in Traverse(root.Left))
                {
                    yield return item;
                }

                yield return root.Value;

                foreach (var item in Traverse(root.Right))
                {
                    yield return item;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Traverse(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
