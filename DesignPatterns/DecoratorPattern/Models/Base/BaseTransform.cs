namespace DecoraterPattern.Models.Base
{
    public class BaseTransform : ITransformationPipeline
    {
        public string Transform(string input)
        {
            return input.ToLower();
        }
    }
}
