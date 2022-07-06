using DecoraterPattern.Models.Base;

namespace DecoraterPattern.Models.Decorators
{
    public class StringLeft : ITransformationPipeline
    {
        private ITransformationPipeline _pipeline;
        private int _argument;

        public StringLeft(ITransformationPipeline pipeline, int argument) 
        {
            _pipeline = pipeline;
            _argument = argument;
        }

        public string Transform(string input)
        {
            var result = _pipeline.Transform(input);
            return result.Substring(0, _argument);
        }
    }
}
