using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
    public class TechinicalSupport : IObserver
    {
        private ISubject _subject;
        private const string StandardResponse = "This is technical support, I'm here to help.";

        public TechinicalSupport(ISubject subject) 
        {
            _subject = subject;
            subject.RegisterObserver(this);
        }
        public void Act(string message)
        {
            if (message.StartsWith("Technical Support")) 
            {
                Console.WriteLine(StandardResponse);
            }
        }
    }
}
