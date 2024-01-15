using Task_1.Mediator;
using Task_1.Models;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IItem amulet = new Item("Амулет", 1);
            IItem coin = new Item("Монета", 33);
            IItem book = new Item("Книга", 1);
            List<IItem> items = [amulet, coin, book];

            Table table = new("Стол", items);
            Inventory inventory = new("Инвентарь", new());

            Controller mediator = new Controller(table, inventory);

            while (table.Items.Count > 0)
            {
                table.ShowInfo();
                inventory.ShowInfo();
                Console.WriteLine("Чтобы взять предмет из стола введите индекс предмета.\n");

                int index = GetIndex(table.Items.Count);

                table.AddItemTo(index);
            }

            inventory.ShowInfo();

            Console.WriteLine("На столе больше нет предметов! Нажмите любую кнопку чтобы завершить.\n");
            Console.ReadLine();
        }

        private static int GetIndex(int count)
        {
            int number;

            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    number = int.Parse(input);

                    if (number < 0 || number >= count)
                    {
                        Console.WriteLine("Неверный индекс, введите правильный индекс предмета.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введённые данные не являются числом.");
                }
            }

            return number;
        }
    }
}
