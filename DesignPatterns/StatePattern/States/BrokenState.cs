namespace StatePattern.States
{
    public class BrokenState : IMachineState
    {
        public InitialState? InitialState { get; set; }

        public void PrintState()
        {
            Console.WriteLine("Broken State");
        }

        public IMachineState? Work()
        {
            if (InitialState == null)
                Console.WriteLine("No initial state set for broken state");
            return InitialState;
        }
    }
}
