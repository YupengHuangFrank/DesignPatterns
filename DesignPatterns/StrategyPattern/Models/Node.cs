namespace StrategyPattern.Models
{
    public class Node
    {
        public int Id { get; set; }
        public List<Node> ChildNodes { get; set; }

        public void Add(Node node)
        {
            ChildNodes.Add(node);
        }
    }
}
