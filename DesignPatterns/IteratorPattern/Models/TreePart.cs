namespace IteratorPattern.Models
{
    public abstract class TreePart
    {
        public int Id { get; set; }

        public abstract TreePart? GetTree(int id);

        public abstract void Print();
    }
}
