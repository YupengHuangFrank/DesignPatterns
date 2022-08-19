using AdapterPattern.Interfaces;

namespace AdapterPattern.Models
{
    public class QueueAdapter<T> : IStack<T>
    {
        private readonly Queue<T> _queue1;
        private readonly Queue<T> _queue2;
        
        public QueueAdapter()
        {
            _queue1 = new Queue<T>();
            _queue2 = new Queue<T>();
        }

        public void Push(T item)
        {
            while (!_queue1.IsEmpty())
            {
                _queue2.Enqueue(_queue1.Dequeue());
            }
            _queue1.Enqueue(item);
            while (!_queue2.IsEmpty())
            {
                _queue1.Enqueue(_queue2.Dequeue());
            }
        }

        public T Pop()
        {
            return _queue1.Dequeue();
        }

        public bool IsEmpty()
        {
            return _queue1.IsEmpty();
        }
    }
}
