using FactoryPattern.Models;

namespace FactoryPattern.Factory
{
    public class CsvFactory : IFactory
    {
        public ISerializer CreateSerializer()
        {
            return new CsvSerializer();
        }
    }
}
