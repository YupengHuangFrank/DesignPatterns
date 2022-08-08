using CommandPattern.Exceptions;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class PostSanitizationCommand : ICommand
    {
        private readonly HealthWorker _healthWorker;

        public PostSanitizationCommand(HealthWorker healthWorker)
        {
            _healthWorker = healthWorker;
        }

        public void Execute()
        {
            this._healthWorker.Post();
            if (Virus.Infected(SanitizationProgressEnum.PostSanitization))
            {
                throw new InfectedException("The Health Worker is infected during PostSanitization");
            }
        }

        public void Undo()
        {
            _healthWorker.Restart();
        }
    }
}
