using System;
using System.Collections.Generic;

namespace ListLibrary
{
    public class CustomList<T>
    {
        private List<T> _items = new List<T>();

        // Добавление элемента
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");

            _items.Add(item);
        }

        // Удаление элемента
        public bool Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");

            return _items.Remove(item);
        }

        // Поиск элемента
        public bool Contains(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");

            return _items.Contains(item);
        }

        // Получение элемента по индексу
        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона");

            return _items[index];
        }

        // Очистка списка
        public void Clear()
        {
            _items.Clear();
        }

        // Количество элементов
        public int Count => _items.Count;
    }
}