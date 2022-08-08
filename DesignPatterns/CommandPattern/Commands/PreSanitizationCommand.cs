using CommandPattern.Exceptions;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class PreSanitizationCommand : ICommand
    {
        private readonly HealthWorker _healthWorker;

        public PreSanitizationCommand(HealthWorker healthWorker)
        {
            _healthWorker = healthWorker;
        }

        public void Execute()
        {
            this._healthWorker.Prepare();
            if (Virus.Infected(SanitizationProgressEnum.PreSanitization))
            {
                throw new InfectedException("The Health Worker is infected during PreSanitization");
            }
        }

        public void Undo()
        {
            _healthWorker.Restart();
        }
    }
}
