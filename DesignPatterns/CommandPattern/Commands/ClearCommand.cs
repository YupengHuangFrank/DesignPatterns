using CommandPattern.Exceptions;
using CommandPattern.Models;

namespace CommandPattern.Commands
{
    public class ClearCommand : ICommand
    {
        private readonly HealthWorker _healthWorker;

        public ClearCommand(HealthWorker healthWorker)
        {
            _healthWorker = healthWorker;
        }

        public void Execute()
        {
            this._healthWorker.Clear();
        }

        public void Undo()
        {
            _healthWorker.Restart();
        }
    }
}
