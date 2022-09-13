using StatePattern.States;

namespace StatePattern.Models
{
    public class Machine
    {
        private static readonly InitialState InitialState = new InitialState();
        private static readonly BrokenState BrokenState = new BrokenState();
        private static readonly WorkingState WorkingState = new WorkingState();

        private IMachineState? _currentState;

        public Machine()
        {
            InitialState.BrokenState = BrokenState;
            InitialState.WorkingState = WorkingState;
            BrokenState.InitialState = InitialState;
            WorkingState.BrokenState = BrokenState;
            _currentState = InitialState;
        }

        public void PrintState()
        {
            _currentState?.PrintState();
        }

        public void Work()
        {
            PrintState();
            _currentState = _currentState?.Work();
        }
    }
}
