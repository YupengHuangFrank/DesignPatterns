namespace StatePattern.States
{
    public interface IMachineState
    {
        void PrintState();
        IMachineState? Work();
    }
}
