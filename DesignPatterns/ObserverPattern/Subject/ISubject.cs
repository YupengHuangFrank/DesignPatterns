using ObserverPattern.Observers;

namespace ObserverPattern.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void BroadCast();
    }
}
