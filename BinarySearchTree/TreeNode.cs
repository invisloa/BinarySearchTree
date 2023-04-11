using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeImplementationAlgo
{
	public class TreeNode
	{
		int nodeValue;
		TreeNode? left;
		TreeNode? right;
		public TreeNode(int value)
		{
			this.Value = value;
			Left = null;
			Right = null;
		}

		public int Value { get => nodeValue; set => nodeValue = value; }
		public TreeNode Left { get => left; set => left = value; }
		public TreeNode Right { get => right; set => right = value; }
	}
}


