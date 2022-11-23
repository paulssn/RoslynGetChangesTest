using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.VisualBasic;

for (var i = 0; i < 10; i++)
{
	CalculateChanges();
}

static void CalculateChanges()
{
	var tree1 = GetTree("tree1.vb");
	var tree2 = GetTree("tree2.vb");

	// Subsequent calls of GetChanges lead to potentially different results
	var treeChanges = tree2.GetChanges(tree1);

	Console.WriteLine($"Number of changes: {treeChanges.Count}");
}

static SyntaxTree GetTree(string file)
{
	return VisualBasicSyntaxTree.ParseText(File.ReadAllText(file));
}