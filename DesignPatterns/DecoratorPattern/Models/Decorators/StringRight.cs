using DecoratorPattern.Models.Base;

namespace DecoratorPattern.Models.Decorators
{
    public class StringRight : ITransformationPipeline
    {
        private readonly ITransformationPipeline _pipeline;
        private readonly int _argument;

        public StringRight(ITransformationPipeline pipeline, int argument) 
        {
            _pipeline = pipeline;
            _argument = argument;
        }

        public string Transform(string input)
        {
            var result = _pipeline.Transform(input);
            return result.Substring(result.Length - _argument, result.Length - 1);
        }
    }
}
