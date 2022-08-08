using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Exceptions
{
    public class InfectedException : Exception
    {
        public InfectedException(string message) : base(message)
        {

        }
    }
}
