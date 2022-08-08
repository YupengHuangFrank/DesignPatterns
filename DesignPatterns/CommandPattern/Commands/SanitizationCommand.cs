using CommandPattern.Exceptions;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class SanitizationCommand : ICommand
    {
        private readonly HealthWorker _healthWorker;

        public SanitizationCommand(HealthWorker healthWorker)
        {
            _healthWorker = healthWorker;
        }

        public void Execute()
        {
            this._healthWorker.Sanitize();
            if (Virus.Infected(SanitizationProgressEnum.Sanitization))
            {
                throw new InfectedException("The Health Worker is infected during Sanitization");
            }
        }

        public void Undo()
        {
            _healthWorker.Restart();
        }
    }
}
