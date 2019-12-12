namespace Development
{
    interface IStorage
    {
        void Add(int id, int quantity);
        void Delete(int id, int quantity);
        bool Contains(int id);
        void Clear();
    }
}