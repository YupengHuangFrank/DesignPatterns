using AdapterPattern.Interfaces;

namespace AdapterPattern.Models
{
    public class Stack<T> : IStack<T>
    {
        private readonly List<T> _stack;

        public Stack() {
            _stack = new List<T>();
        }

        public void Push(T item)
        {
            _stack.Add(item);
        }

        public T Pop()
        {
            var result = _stack[^1];
            _stack.RemoveAt(_stack.Count - 1);
            return result;
        }

        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }
    }
}
