using System.Runtime.InteropServices;

namespace AdapterPattern.Models
{
    public class Queue<T>
    {
        private readonly List<T> _queue;

        public Queue()
        {
            _queue = new List<T>();
        }

        public void Enqueue(T item)
        {
            _queue.Add(item);
        }

        public T Dequeue()
        {
            var result = _queue[0];
            _queue.RemoveAt(0);
            return result;
        }

        public bool IsEmpty()
        {
            return _queue.Count == 0;
        }
    }
}
