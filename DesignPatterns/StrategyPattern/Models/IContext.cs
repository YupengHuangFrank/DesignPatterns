using StrategyPattern.Strategies;

namespace StrategyPattern.Models
{
    public interface IContext
    {
        void SetStrategy(ISearchStrategy strategy);
        Node ExecuteStrategy(int id, Node root);

    }
}
