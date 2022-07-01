using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
    public class Manager : IObserver
    {
        private ISubject _subject;
        private const string StandardReply = "Hi, this is the manager. I'm terribly sorry about your experience, this feedback is greatly valued and we will try to improve in the future.";

        public Manager(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Act(string message)
        {
            if (message.StartsWith("Manager")) 
            {
                Console.WriteLine(StandardReply);
            }
        }
    }
}
