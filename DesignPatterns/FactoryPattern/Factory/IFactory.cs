using FactoryPattern.Models;

namespace FactoryPattern.Factory
{
    public interface IFactory
    {
        ISerializer CreateSerializer();
    }
}
