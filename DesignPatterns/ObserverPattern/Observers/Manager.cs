using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
    public class Manager : IObserver
    {
        private const string StandardReply = "Hi, this is the manager. I'm terribly sorry about your experience, this feedback is greatly valued and we will try to improve in the future.";
        public readonly List<string> Complaints;
        private ISubject? _subject;

        public Manager(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
            Complaints = new List<string>();
        }
        public void Act(string message)
        {
            if (message.StartsWith("Manager")) 
            {
                Console.WriteLine(StandardReply);
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
