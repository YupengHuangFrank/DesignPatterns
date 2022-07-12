using DecoratorPattern.Models.Base;

namespace DecoratorPattern.Models.Decorators
{
    public class StringConcat : ITransformationPipeline
    {
        private readonly ITransformationPipeline _pipeline;
        private readonly string _argument;

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
