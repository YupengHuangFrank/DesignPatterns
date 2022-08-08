using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public static class Virus
    {
        public static bool Infected(SanitizationProgressEnum progress)
        {
            switch (progress)
            {
                case SanitizationProgressEnum.PreSanitization:
                    return Chance(30);
                case SanitizationProgressEnum.Sanitization:
                    return Chance(20);
                case SanitizationProgressEnum.PostSanitization:
                    return Chance(10);
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private static bool Chance(int percentage)
        {
            if (percentage is < 0 or > 100)
                throw new ArgumentOutOfRangeException("Percentage has to be between 0-100");
            var r = new Random();
            var rInt = r.Next(0, 100);
            return rInt < percentage;
        }
    }
}
