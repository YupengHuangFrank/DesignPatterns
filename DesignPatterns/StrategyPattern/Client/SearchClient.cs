using StrategyPattern.Models;
using StrategyPattern.Strategies;

namespace StrategyPattern.Client
{
    public class SearchClient
    {
        public readonly IContext Context;

        public SearchClient(IContext context) 
        { 
            Context = context; 
        }

        public Node ExecuteSearch(int id, Node node, StrategyEnum strategy) 
        {
            if (strategy == StrategyEnum.BFS) 
            {
                Context.SetStrategy(new BFS());
            }

            else if (strategy == StrategyEnum.DFS)
            {
                Context.SetStrategy(new DFS());
            }

            return Context.ExecuteStrategy(id, node);
        }
    }
}
