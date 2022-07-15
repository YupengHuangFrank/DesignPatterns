using FactoryPattern.Factory;
using FactoryPattern.Models;

namespace FactoryPattern.Application
{
    public class Application
    {
        private readonly IFactory _factory;
        private ISerializer? _serializer;

        public Application(IFactory factory)
        {
            _factory = factory;
        }

        public void CreateSerializer()
        {
            _serializer = _factory.CreateSerializer();
        }

        public void SerializeAndDeserializeStudents(List<Student> students, string fileName)
        {
            if (_serializer == null) return;
            _serializer.Serialize(students, fileName);
            Console.WriteLine("Serialized!");
            var result  = _serializer.Deserialize(fileName);
            Console.WriteLine("Deserialized to: ");
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Id}, {student.Name}, {student.Id}");
            }
        }
    }
}
