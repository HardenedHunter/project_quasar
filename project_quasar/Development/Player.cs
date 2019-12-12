using System;
using System.Collections;
using System.Collections.Generic;

namespace Development
{
    public class Player
    {
        private readonly Storage _inventory;
        private readonly List<Quest> _quests;
        private int _gold;

        public IEnumerable<KeyValuePair<int, int>> Items => _inventory.Items;
        public IEnumerable<Quest> Quests => _quests;

        public Player()
        {
            Gold = 0;
            _inventory = new Storage();
            _quests = new List<Quest>();
        }

        public int Gold
        {
            get => _gold;
            set =>
                _gold = value < 0
                    ? throw new ArgumentException("Attempted to set player's gold below 0. [Player.Gold]'")
                    : value;
        }
    }
}