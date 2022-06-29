using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public interface ISearchStrategy
    {
        Node Search(int id, Node root);
    }
}
