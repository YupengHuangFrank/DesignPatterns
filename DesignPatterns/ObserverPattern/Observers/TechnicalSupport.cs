using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
    public class TechnicalSupport : IObserver
    {
        private const string StandardResponse = "This is technical support, I'm here to help.";
        public readonly List<string> Complaints;

        public TechnicalSupport(ISubject subject) 
        {
            subject.RegisterObserver(this);
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
    }
}
