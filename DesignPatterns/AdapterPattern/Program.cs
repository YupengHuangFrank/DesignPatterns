using AdapterPattern.Models;

var stack = new AdapterPattern.Models.Stack<int>();
var fakeStack = new QueueAdapter<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

fakeStack.Push(1);
fakeStack.Push(2);
fakeStack.Push(3);
fakeStack.Push(4);
fakeStack.Push(5);

while (!stack.IsEmpty())
{
    Console.WriteLine(stack.Pop());
}

while (!fakeStack.IsEmpty())
{
    Console.WriteLine(fakeStack.Pop());
}


