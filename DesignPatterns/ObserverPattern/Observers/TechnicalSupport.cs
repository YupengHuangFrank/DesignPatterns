using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
    public class TechnicalSupport : IObserver
    {
        private const string StandardResponse = "This is technical support, I'm here to help.";
        public readonly List<string> Complaints;
        private ISubject? _subject;

        public TechnicalSupport(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
            Complaints = new List<string>();
        }
        public void Act(string message)
        {
            if (message.StartsWith("Technical Support")) 
            {
                Console.WriteLine(StandardResponse);
            }
            Complaints.Add(message);
        }

        public void Unsubscribe()
        {
            _subject?.RemoveObserver(this);
            _subject = null;
        }
    }
}
