using BinaryTreeImplementationAlgo;


BinaryTree tree = new BinaryTree();


tree.Insert(11);
tree.Insert(33);
tree.Insert(1);
tree.Insert(2);
tree.Insert(6);
tree.Insert(5);
tree.Insert(55);
tree.Insert(21);
tree.Insert(32);
Console.WriteLine($"{tree.InOrderTraversal()}");
Console.WriteLine($"{tree.PostOrderTraversal()}");
Console.WriteLine($"{tree.PreOrderTraversal()}");
tree.Remove(2);
Console.WriteLine($"{tree.InOrderTraversal()}");
Console.WriteLine($"{tree.PostOrderTraversal()}");
Console.WriteLine($"{tree.PreOrderTraversal()}");
