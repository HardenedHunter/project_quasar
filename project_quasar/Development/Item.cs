using System;

namespace Development
{
    public class Item
    {
        private int _price;

        public string Title { get; }
        public string Description { get; }
        public int Id { get; }
        public bool IsQuest { get; }

        public Item(string title, string description, int price, int id, bool isQuest = false)
        {
            Title = title ?? throw new ArgumentNullException();
            Description = description ?? throw new ArgumentNullException();
            Price = price;
            Id = id;
            IsQuest = isQuest;
        }

        public int Price
        {
            get => _price;
            set => _price = value > 0 ? value : throw new ArgumentException();
        }
    }
}