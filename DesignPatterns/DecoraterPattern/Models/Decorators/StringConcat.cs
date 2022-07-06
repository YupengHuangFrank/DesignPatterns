using DecoraterPattern.Models.Base;

namespace DecoraterPattern.Models.Decorators
{
    public class StringConcat : ITransformationPipeline
    {
        private ITransformationPipeline _pipeline;
        private string _argument;

        public StringConcat(ITransformationPipeline pipeline, string argument) 
        {
            _pipeline = pipeline;
            _argument = argument;
        }

        public string Transform(string input)
        {
            var result = _pipeline.Transform(input);
            return String.Concat(result, _argument);
        }
    }
}
