using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class HealthWorker
    {
        public SanitizationProgressEnum SanitizationProgress { get; private set; }

        public HealthWorker()
        {
            SanitizationProgress = SanitizationProgressEnum.UnSanitized;
        }

        public void Prepare()
        {
            Console.WriteLine("PreSanitizing");
            SanitizationProgress = SanitizationProgressEnum.PreSanitization;
        }

        public void Sanitize()
        {
            Console.WriteLine("Sanitizing");
            SanitizationProgress = SanitizationProgressEnum.Sanitization;
        }

        public void Post()
        {
            Console.WriteLine("PostSanitizing");
            SanitizationProgress = SanitizationProgressEnum.PostSanitization;
        }

        public void Clear()
        {
            Console.WriteLine("Clear!");
            SanitizationProgress = SanitizationProgressEnum.Clear;
        }

        public void Restart()
        {
            Console.WriteLine("Oops, restart");
            SanitizationProgress = SanitizationProgressEnum.UnSanitized;
        }
    }
}
