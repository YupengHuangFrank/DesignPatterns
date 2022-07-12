using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public class Bfs : ISearchStrategy
    {
        public Node Search(int id, Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current.Id == id) 
                {
                    return current;
                }
                foreach (var child in current.ChildNodes) 
                {
                    queue.Enqueue(child);
                }
            }
            throw new Exception($"The node with id {id} is not found");
        }
    }
}
