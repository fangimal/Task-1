namespace Task_1.Mediator
{
    public class Controller : IMediator
    {
        private Table _table;
        private Inventory _inventory;

        public Controller(Table table, Inventory inventory)
        {
            _table = table;
            _inventory = inventory;
            table.SetMediator(this);
            inventory.SetMediator(this);
        }

        public void TakeItem(Itemable itemable, int index)
        {
            if (itemable is Table table)
            {
                _inventory.AddItem(_table.Items[index]);
                _table.RemoveItem(index);
            }

            if (itemable is Inventory inventory)
            {
                _table.AddItem(_table.Items[index]);
                _inventory.RemoveItem(index);
            }
        }
    }
}
