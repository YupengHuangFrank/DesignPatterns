using StrategyPattern.Strategies;

namespace StrategyPattern.Models
{
    public class Context : IContext
    {
        private ISearchStrategy? searchStrategy;

        public void SetStrategy(ISearchStrategy strategy)
        {
            searchStrategy = strategy;
        }

        public Node ExecuteStrategy(int id, Node root)
        {
            if (searchStrategy == null) 
            {
                throw new InvalidOperationException("There is no strategy for the context");
            }
            return searchStrategy.Search(id, root);
        }
    }
}
