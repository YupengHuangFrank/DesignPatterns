namespace DecoratorPattern.Models.Base
{
    public interface ITransformationPipeline
    {
        string Transform(string input);
    }
}
