using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

for (var i = 0; i < 10; i++)
{
	CalculateChanges();
}

static void CalculateChanges()
{
	// reproducible with C# as well as VB.NET
	var tree1 = GetTree("tree1.cs");
	var tree2 = GetTree("tree2.cs");

	var treeChanges = tree2.GetChanges(tree1);

	Console.WriteLine($"Number of changes: {treeChanges.Count}");
}

static SyntaxTree GetTree(string file)
{
	return CSharpSyntaxTree.ParseText(File.ReadAllText(file));
}