using ObserverPattern.Observers;

namespace ObserverPattern.Subject
{
    public class CustomerComplaint : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _message;
        
        public CustomerComplaint() 
        {
            _observers = new List<IObserver>();
            _message = "";
        }

        public void BroadCast()
        {
            if (_message != null)
            {
                foreach (var observer in _observers)
                {
                    observer.Act(_message);
                }
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
            if (person == PersonEnum.Manager) 
            {
                _message = String.Concat("Manager", _message);
            }
            if (person == PersonEnum.TechnicalSupport)
            {
                _message = String.Concat("Technical Support", _message);
            }
            BroadCast();
        }
    }
}
