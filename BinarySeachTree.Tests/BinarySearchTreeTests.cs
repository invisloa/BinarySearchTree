using BinaryTreeImplementationAlgo;
using Xunit;

namespace BinaryTreeTests
{
	public class BinaryTreeTests
	{
		[Fact]
		public void TestInsertAndSearch()
		{
			BinaryTree tree = new BinaryTree();
			tree.Insert(50);
			tree.Insert(30);
			tree.Insert(20);
			tree.Insert(40);
			tree.Insert(70);
			tree.Insert(60);
			tree.Insert(80);

			Assert.NotNull(tree.Search(50));
			Assert.NotNull(tree.Search(30));
			Assert.NotNull(tree.Search(20));
			Assert.NotNull(tree.Search(40));
			Assert.NotNull(tree.Search(70));
			Assert.NotNull(tree.Search(60));
			Assert.NotNull(tree.Search(80));
			Assert.Null(tree.Search(100));
		}

		[Fact]
		public void TestRemove()
		{
			BinaryTree tree = new BinaryTree();
			tree.Insert(50);
			tree.Insert(30);
			tree.Insert(20);
			tree.Insert(40);
			tree.Insert(70);
			tree.Insert(60);
			tree.Insert(80);

			tree.Remove(20);
			Assert.Null(tree.Search(20));
			tree.Remove(30);
			Assert.Null(tree.Search(30));
			tree.Remove(50);
			Assert.Null(tree.Search(50));
		}

		[Fact]
		public void TestPreOrderTraversal()
		{
			BinaryTree tree = new BinaryTree();
			tree.Insert(50);
			tree.Insert(30);
			tree.Insert(20);
			tree.Insert(40);
			tree.Insert(70);
			tree.Insert(60);
			tree.Insert(80);

			string expected = "50 30 20 40 70 60 80";
			Assert.Equal(expected, tree.PreOrderTraversal());
		}

		[Fact]
		public void TestInOrderTraversal()
		{
			BinaryTree tree = new BinaryTree();
			tree.Insert(50);
			tree.Insert(30);
			tree.Insert(20);
			tree.Insert(40);
			tree.Insert(70);
			tree.Insert(60);
			tree.Insert(80);

			string expected = "20 30 40 50 60 70 80";
			Assert.Equal(expected, tree.InOrderTraversal());
		}

		[Fact]
		public void TestPostOrderTraversal()
		{
			BinaryTree tree = new BinaryTree();
			tree.Insert(50);
			tree.Insert(30);
			tree.Insert(20);
			tree.Insert(40);
			tree.Insert(70);
			tree.Insert(60);
			tree.Insert(80);

			string expected = "20 40 30 60 80 70 50";
			Assert.Equal(expected, tree.PostOrderTraversal());
		}
	}
}
