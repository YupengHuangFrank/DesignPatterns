using IteratorPattern.Models;

var a = new Tree(1);
var b = new Tree(2);
var c = new Tree(3);
var d = new Node(4);
var e = new Node(5);
var f = new Node(6);
var g = new Node(7);

a.Add(b);
a.Add(c);
b.Add(d);
b.Add(e);
c.Add(f);
c.Add(g);

var getTreeResult = a.GetTree(5);
Console.WriteLine(getTreeResult == null ? "No Id" : getTreeResult.Id);

a.Print();