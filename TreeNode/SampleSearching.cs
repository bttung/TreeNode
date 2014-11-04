using System;

class SampleSearching
{
	static void Main(string[] args)
	{
		TreeNode<string> treeRoot = SampleData.GetSet1();
		TreeNode<string> found = treeRoot.FindTreeNode(node => node.Data != null && node.Data.Contains("21100"));

		Console.WriteLine("Found: " + found);
	}
}
