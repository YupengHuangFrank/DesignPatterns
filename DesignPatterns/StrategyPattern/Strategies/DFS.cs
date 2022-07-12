using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public class Dfs : ISearchStrategy
    {
        public Node Search(int id, Node root)
        {
            var list= new LinkedList<Node>();
            list.AddFirst(root);
            while (list.Count > 0)
            {
                Node node = list.First();
                if (node.Id == id) 
                {
                    return node;
                }
                list.RemoveFirst();
                for (int i = node.ChildNodes.Count - 1; i >= 0; i--) 
                {
                    list.AddFirst(node.ChildNodes[i]);
                }
            }
            throw new Exception($"The node with id {id} is not found");
        }
    }
}
