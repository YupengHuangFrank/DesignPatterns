namespace StrategyPattern.Models
{
    public class Node
    {
        public int Id { get; set; }
        public List<Node> ChildNodes { get; set; }

        public Node()
        { 
            ChildNodes = new List<Node>();
        }

        public void Add(Node node)
        {
            ChildNodes.Add(node);
        }
    }
}
