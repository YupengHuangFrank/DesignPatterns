namespace ObserverPattern.Observers
{
    public interface IObserver
    {
        void Act(string message);
        void Unsubscribe();
    }
}
