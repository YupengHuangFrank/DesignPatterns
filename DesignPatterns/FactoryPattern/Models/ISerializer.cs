using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    public interface ISerializer
    {
        void Serialize(List<Student> students, string fileName);
        List<Student> Deserialize(string fileName);
    }
}
