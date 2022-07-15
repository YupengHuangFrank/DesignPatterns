using FactoryPattern.Models;

namespace FactoryPattern.Factory
{
    public class JsonFactory : IFactory
    {
        public ISerializer CreateSerializer()
        {
            return new JsonSerializer();
        }
    }
}
