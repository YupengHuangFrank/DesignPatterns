namespace IteratorPattern.Models
{
    public class Tree : TreePart
    {
        private readonly List<TreePart> _parts;

        public Tree(int id) : base()
        {
            Id = id;
            _parts = new List<TreePart>();
        }

        public void Add(TreePart part)
        {
            _parts.Add(part);
        }

        public void Remove(TreePart part)
        {
            _parts.Remove(part);
        }

        public override TreePart? GetTree(int id)
        {
            foreach (var part in _parts)
            {
                if (part.Id == id)
                {
                    return part;
                }

                var child = part.GetTree(id);
                if (child != null)
                {
                    return child;
                }
            }
            return null;
        }

        public override void Print()
        {
            Console.WriteLine(Id);
            foreach (var treePart in _parts)
            {
                treePart.Print();
            }
        }
    }
}
