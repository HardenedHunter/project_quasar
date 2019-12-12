using System;
using System.Collections.Generic;

namespace Development
{
    public class Quest
    {
        public string Title { get; }
        public string Description { get; }
        public bool IsCompleted { get; private set; }

        Loot Reward { get; }
        public int Id { get; }

        public Quest(string title, string description, Loot reward, int id)
        {
            Title = title ?? throw new ArgumentNullException();
            Description = description ?? throw new ArgumentNullException();
            Reward = reward ?? throw new ArgumentNullException("Loot object expected but null found. [Quest Constructor]");
            IsCompleted = false;
            Id = id;
        }

        Loot Complete()
        {
            IsCompleted = true;
            return Reward;
        }
    }
}