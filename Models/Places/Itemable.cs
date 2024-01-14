using Task_1.Mediator;
using Task_1.Models;

namespace Task_1
{
    public abstract class Itemable
    {
        public abstract string Name { get; }

        public List<IItem> Items { get; set; } = null;

        protected IMediator mediator;


        protected Itemable(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(int index)
        {
            if (Items.Count > 0)
            {
                Items.RemoveAt(index);
            }
        }

        public void ShowInfo()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine(Name + " пуст.\n");
            }
            else
            {
                Console.WriteLine(Name + ":");

                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"индекс: {i}. " + Items[i].Name + ", количество - " + Items[i].Count);
                }

                Console.WriteLine();
            }
        }
    }

}
