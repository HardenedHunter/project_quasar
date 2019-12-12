using System.Collections.Generic;

namespace Development
{
    class DefaultDictionary<TKey, TValue> : Dictionary<TKey, TValue> where TValue : new()
    {
        public new TValue this[TKey key]
        {
            get => base[key];
            set
            {
                if (!ContainsKey(key))
                    Add(key, value);
            }
        }
    }
}