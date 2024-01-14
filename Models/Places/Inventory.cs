using Task_1.Mediator;
using Task_1.Models;

namespace Task_1
{
    public class Inventory : Itemable
    {
        public override string Name { get; }

        public Inventory(string name, List<IItem> items, IMediator mediator = null) : base(mediator)
        {
            Name = name;
            Items = items;
        }
    }
}
