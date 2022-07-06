using DecoraterPattern.Models.Base;

namespace DecoraterPattern.Models.Decorators
{
    public class StringRight : ITransformationPipeline
    {
        private ITransformationPipeline _pipeline;
        private int _argument;

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
