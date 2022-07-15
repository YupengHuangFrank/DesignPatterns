using System.Text.Json;

namespace FactoryPattern.Models
{
    public class JsonSerializer : ISerializer
    {
        private const string JsonExtensionName = ".json";

        public void Serialize(List<Student> students, string fileName)
        {
            var fullName = fileName + JsonExtensionName;
            var result = System.Text.Json.JsonSerializer.Serialize(students);
            using (var sw = new StreamWriter(fullName))
            {
                sw.Write(result);
            }
        }

        public List<Student> Deserialize(string fileName)
        {
            var fullname = fileName + JsonExtensionName;
            var students = File.ReadAllText(fullname);
            var result = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(students);
            if (result == null)
            {
                throw new Exception("Unsuccessful deserialization");
            }
            return result;
        }
    }
}
