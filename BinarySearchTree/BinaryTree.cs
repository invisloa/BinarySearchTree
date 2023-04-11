using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeImplementationAlgo
{
	public class BinaryTree
	{
		private TreeNode? root;

		public BinaryTree()
		{
			root = null;
		}

		public void Insert(int value)
		{
			if (root == null)
			{
				root = new TreeNode(value);
				return;
			}

			TreeNode current = root;
			while (true)
			{
				if (value < current.Value)
				{
					if (current.Left == null)
					{
						current.Left = new TreeNode(value);
						return;
					}
					current = current.Left;
				}
				else
				{
					if (current.Right == null)
					{
						current.Right = new TreeNode(value);
						return;
					}
					current = current.Right;
				}
			}
		}

		public TreeNode Search(int value)
		{
			TreeNode current = root;

			while (current != null)
			{
				if (value == current.Value)
				{
					return current;
				}
				else if (value < current.Value)
				{
					current = current.Left;
				}
				else
				{
					current = current.Right;
				}
			}

			return null;
		}

		public void Remove(int value)
		{
			root = RemoveRecursive(root, value);
		}

		private TreeNode RemoveRecursive(TreeNode node, int value)
		{
			if (node == null)
			{
				return node;
			}

			if (value < node.Value)
			{
				node.Left = RemoveRecursive(node.Left, value);
			}
			else if (value > node.Value)
			{
				node.Right = RemoveRecursive(node.Right, value);
			}
			else
			{
				if (node.Left == null)
				{
					return node.Right;
				}
				else if (node.Right == null)
				{
					return node.Left;
				}

				node.Value = MinValue(node.Right);
				node.Right = RemoveRecursive(node.Right, node.Value);
			}
			return node;
		}

		private int MinValue(TreeNode node)
		{
			int minValue = node.Value;
			while (node.Left != null)
			{
				minValue = node.Left.Value;
				node = node.Left;
			}
			return minValue;
		}

		public string PreOrderTraversal()
		{
			StringBuilder sb = new StringBuilder();
			PreOrderTraversalRecursive(root, sb);
			return sb.ToString().Trim();
		}

		private void PreOrderTraversalRecursive(TreeNode node, StringBuilder sb)
		{
			if (node != null)
			{
				sb.Append(node.Value + " ");
				PreOrderTraversalRecursive(node.Left, sb);
				PreOrderTraversalRecursive(node.Right, sb);
			}
		}

		public string InOrderTraversal()
		{
			StringBuilder sb = new StringBuilder();
			InOrderTraversalRecursive(root, sb);
			return sb.ToString().Trim();
		}

		private void InOrderTraversalRecursive(TreeNode node, StringBuilder sb)
		{
			if (node != null)
			{
				InOrderTraversalRecursive(node.Left, sb);
				sb.Append(node.Value + " ");
				InOrderTraversalRecursive(node.Right, sb);
			}
		}

		public string PostOrderTraversal()
		{
			StringBuilder sb = new StringBuilder();
			PostOrderTraversalRecursive(root, sb);
			return sb.ToString().Trim();
		}

		private void PostOrderTraversalRecursive(TreeNode node, StringBuilder sb)
		{
			if (node != null)
			{
				PostOrderTraversalRecursive(node.Left, sb);
				PostOrderTraversalRecursive(node.Right, sb);
				sb.Append(node.Value + " ");
			}
		}
	}
}
