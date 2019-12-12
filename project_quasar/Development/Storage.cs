using System;
using System.Collections.Generic;

namespace Development
{
    public class Storage: IStorage
    {
        private readonly DefaultDictionary<int, int> _items;

        public IEnumerable<KeyValuePair<int, int>> Items => _items;

        public Storage()
        {
            _items = new DefaultDictionary<int, int>();
        }

        public void Add(int id, int quantity)
        {
            _items[id] += quantity;
        }

        public void Delete(int id, int quantity = 1) //TODO
        {
            if (!_items.TryGetValue(id, out int curQuantity))
                throw new ArgumentException("Requested item has not been found. [Storage.Delete]");
            if (quantity > curQuantity)
                throw new ArgumentException("Attempted to delete more items than there actually is. [Storage.Delete]");
            if (quantity == curQuantity)
                _items.Remove(id);
            else
                _items[id] -= quantity;
        }

        public bool Contains(int id)
        {
            return _items.ContainsKey(id);
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}