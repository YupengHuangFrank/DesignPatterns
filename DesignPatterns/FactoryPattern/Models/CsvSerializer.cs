using System.Text;
using static System.Int32;

namespace FactoryPattern.Models
{
    public class CsvSerializer : ISerializer
    {
        private const char StringDelimiter = ',';
        private const string CsvExtensionName = ".csv";

        public void Serialize(List<Student> students, string fileName)
        {
            var fullName = fileName + CsvExtensionName;
            using(var sw = new StreamWriter(fullName))
            {
                var header = CreateHeader(typeof(Student));
                sw.WriteLine(header);
                foreach (var student in students)
                {
                    sw.WriteLine(CreateStudentString(student));
                }
            }
        }

        public List<Student> Deserialize(string fileName)
        {
            var fullName = fileName + CsvExtensionName;
            var result = new List<Student>();
            using (var sr = new StreamReader(fullName))
            {
                if (sr.Peek() < 0) return result;
                sr.ReadLine(); //Skips over the header
                while (sr.Peek() >= 0)
                {
                    var student = CreateStudent(sr.ReadLine());
                    result.Add(student);
                }
            }
            return result;
        }

        private static string CreateHeader(Type studentType)
        {
            var properties = studentType.GetProperties();
            var stringBuilder = new StringBuilder();
            for (var i=0; i < properties.Length; i++)
            {
                stringBuilder.Append(properties[i].Name);
                if (i < properties.Length - 1)
                {
                    stringBuilder.Append(StringDelimiter);
                }
            }
            return stringBuilder.ToString();
        }

        private static string CreateStudentString(Student student)
        {
            return $"{student.Id}, {student.Name}, {student.Age}";
        }

        private static Student CreateStudent(string student)
        {
            var result = new Student();
            var properties = student.Split(StringDelimiter);
            if (properties.Length != 3) throw new Exception("Invalid student");

            result.Id = Parse(properties[0]);
            result.Name = properties[1]; 
            result.Age = Parse(properties[2]);
            return result;
        }
    }
}
