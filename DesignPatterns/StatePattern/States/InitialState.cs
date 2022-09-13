namespace StatePattern.States
{
    public class InitialState : IMachineState
    {
        public BrokenState? BrokenState { get; set; }
        public WorkingState? WorkingState { get; set; }
        private readonly Random _random = new Random();

        public void PrintState()
        {
            Console.WriteLine("Initial State");
        }

        public IMachineState? Work()
        {
            if (_random.Next(0, 10) == 5)
            {
                if (BrokenState == null)
                    Console.WriteLine("No broken state set for initial state");
                return BrokenState;
            }
            if (WorkingState == null)
                Console.WriteLine("No working state set for initial state");
            return WorkingState;
        }
    }
}
