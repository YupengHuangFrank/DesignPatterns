using ObserverPattern.Observers;

namespace ObserverPattern.Subject
{
    public class CustomerComplaint : ISubject
    {
        private readonly List<IObserver> _observers;
        private string _message;
        
        public CustomerComplaint() 
        {
            _observers = new List<IObserver>();
            _message = "";
        }

        public void BroadCast()
        {
            if (_message == "") return;
            foreach (var observer in _observers)
            {
                observer.Act(_message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void LiveComplaint(PersonEnum person) 
        {
            Console.WriteLine("Please enter your complaint");
            var complaint = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback!");
            _message = person switch
            {
                PersonEnum.Manager => String.Concat("Manager", complaint),
                PersonEnum.TechnicalSupport => String.Concat("Technical Support", complaint),
                _ => _message
            };
            BroadCast();
        }
    }
}
