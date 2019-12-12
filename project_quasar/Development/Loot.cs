using System;
using System.Collections.Generic;

namespace Development
{
    public class Loot
    {
        private readonly Storage _storage;
        public IEnumerable<KeyValuePair<int, int>> Items => _storage.Items;
        public int Gold { get; }

        public Loot(Storage storage, int gold)
        {
            Gold = gold > 0
                ? gold
                : throw new ArgumentException("Attempted to create loot with negative gold amount. [Loot Constructor]");
            _storage = storage ?? throw new ArgumentNullException("Storage object expected but null found. [Loot Constructor]");
        }
    }
}