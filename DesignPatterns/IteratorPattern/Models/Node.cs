namespace IteratorPattern.Models
{
    public class Node : TreePart
    {
        public Node(int id)
        {
            this.Id = id;
        }

        public override TreePart? GetTree(int id)
        {
            return id == Id ? this : null;
        }

        public override void Print()
        {
            Console.WriteLine(Id);
        }
    }
}
