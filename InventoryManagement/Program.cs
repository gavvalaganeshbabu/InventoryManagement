using Newtonsoft.Json;
using System;

namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to Inventory Management Application ");
            InventoryManager inventoryManager = new InventoryManager();
            while (true)
            {
                Console.WriteLine("Enter: \n1. for Adding\n2. for Printing Inventory\n3. for Remove\n5. to Save to the File\n6. Load From File");
                int Userinput = int.Parse(Console.ReadLine());
                switch (Userinput)
                {
                    case 1:
                        inventoryManager.Add();
                        Console.WriteLine(JsonConvert.SerializeObject(inventoryManager.inventory, Formatting.Indented));
                        break;
                    case 2:
                        inventoryManager.PrintInventory();
                        break;
                    case 3:
                        inventoryManager.remove();
                        break;
                    case 4:
                        inventoryManager.Edit();
                        break;
                    case 5:
                        inventoryManager.SaveToFile();
                        break;
                    case 6:
                        inventoryManager.LoadFromFile();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }
    }
}
