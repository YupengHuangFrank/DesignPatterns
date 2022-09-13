namespace StatePattern.States
{
    public class WorkingState : IMachineState
    {
        public BrokenState? BrokenState { get; set; }
        private readonly Random _random = new Random();

        public void PrintState()
        {
            Console.WriteLine("Working State");
        }

        public IMachineState? Work()
        {
            if (_random.Next(0, 10) == 5)
            {
                if (BrokenState == null)
                    Console.WriteLine("No broken state set for working state");
                return BrokenState;
            }
            Console.WriteLine("Keep working");
            return this;
        }
    }
}
