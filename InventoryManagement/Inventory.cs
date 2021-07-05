using System;
using System.IO;
using Newtonsoft.Json;
namespace InventoryManagement
{
    class Inventory
    {
        static void Main(string[] args)
        {
            Inventorymanager manager = new Inventorymanager();
            string file = @"C:\Users\DELL\Desktop\InventoryManagement\InventoryManagement\Json.json";
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(file));
            Console.WriteLine("Display inventory Press 1-Rice Inventory 2-Wheat Inventory 3-Pulse Inventory ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    manager.DisplayInventory(utility.RiceList);
                    break;
                case 2:
                    manager.DisplayInventory(utility.WheatList);
                    break;
                case 3:
                    manager.DisplayInventory(utility.PulseList);
                    break;
            }
        }
    }
}
