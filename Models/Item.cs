using Task_1.Models;

namespace Task_1
{
    public class Item : IItem
    {
        public int Count { get; set; }
        public string Name { get; }

        public Item(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
