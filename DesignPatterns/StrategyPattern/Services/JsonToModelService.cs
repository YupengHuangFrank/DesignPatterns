using StrategyPattern.Models;
using System.Text.Json;

namespace StrategyPattern.Services
{
    public class JsonToModelService
    {
        public static Node Deserialize(string fileName) 
        {
            string json = File.ReadAllText(fileName);
            var result = JsonSerializer.Deserialize<Node>(json);
            if (result == null) 
            {
                throw new Exception("Deserialization unsuccessful");
            }
            return result;
        }
    }
}
