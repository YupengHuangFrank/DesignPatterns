using StrategyPattern.Strategies;

namespace StrategyPattern.Models
{
    public class Context : IContext
    {
        private ISearchStrategy? _searchStrategy;

        public void SetStrategy(ISearchStrategy strategy)
        {
            _searchStrategy = strategy;
        }

        public Node ExecuteStrategy(int id, Node root)
        {
            if (_searchStrategy == null) 
            {
                throw new InvalidOperationException("There is no strategy for the context");
            }
            return _searchStrategy.Search(id, root);
        }
    }
}
