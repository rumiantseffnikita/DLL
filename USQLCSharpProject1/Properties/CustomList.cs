using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USQLCSharpProject1.Properties
{
    public class CustomList<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");
            _items.Add(item);
        }

        public bool Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");
            return _items.Remove(item);
        }

        public bool Contains(T item)
        {
            if(item == null)
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");
            return _items.Contains(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона");
            return _items[index];
        }

        public void Clear()
        {
            _items.Clear();
        }

        public int Count => _items.Count;
    }
}
