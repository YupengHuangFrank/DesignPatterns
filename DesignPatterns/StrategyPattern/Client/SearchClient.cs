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
            if (strategy == StrategyEnum.Bfs) 
            {
                Context.SetStrategy(new Bfs());
            }

            else if (strategy == StrategyEnum.Dfs)
            {
                Context.SetStrategy(new Dfs());
            }

            return Context.ExecuteStrategy(id, node);
        }
    }
}
