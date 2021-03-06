﻿using System;
using System.Text;

class SampleIterating
{
	static void IteratingTest()
	{
		TreeNode<string> treeRoot = SampleData.GetSet1();
		foreach (TreeNode<string> node in treeRoot)
		{
			string indent = CreateIndent(node.Level);
			Console.WriteLine(indent + (node.Data ?? "null"));
		}
	}

	private static String CreateIndent(int depth)
	{
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < depth; i++)
		{
			sb.Append(' ');
		}
		return sb.ToString();
	}
}