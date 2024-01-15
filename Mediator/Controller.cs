namespace Task_1.Mediator
{
    public class Controller : IMediator
    {
        private Itemable _place;
        private Inventory _inventory;

        public Controller(Itemable place, Inventory inventory)
        {
            _place = place;
            _inventory = inventory;
            place.SetMediator(this);
            inventory.SetMediator(this);
        }

        public void TakeItem(Itemable itemable, int index)
        {
            if (itemable is Table table)
            {
                _inventory.AddItem(_place.Items[index]);
                _place.RemoveItem(index);
            }

            if (itemable is Inventory inventory)
            {
                _place.AddItem(_place.Items[index]);
                _inventory.RemoveItem(index);
            }
        }
    }
}
