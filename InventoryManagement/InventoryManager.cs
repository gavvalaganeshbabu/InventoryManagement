using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace InventoryManagement
{
    internal class InventoryManager
    {
        public Inventory inventory;
        public InventoryManager()
        {
            inventory = new Inventory();
        }
        public void Add()
        {
            Console.WriteLine("What needs to be added: \nR for Rice, \nP for pulse, \nW for Wheat");
            string input = Console.ReadLine(); // "Ashok" [1,2,3,4,5]
            char firstChar = input[0];// Q
            switch (firstChar)
            {
                case 'R':
                    var seeds = TakeUserInput();
                    inventory.Rice.Add(seeds);
                    break;
                case 'P':
                    inventory.Pulses.Add(TakeUserInput());
                    break;
                case 'W':
                    inventory.Wheat.Add(TakeUserInput());
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        public void SaveToFile()
        {
            string path = @"D:\BridzeLabz\Inventory.jason";
            var jsonInventory = JsonConvert.SerializeObject(inventory, Formatting.Indented);
            File.WriteAllText(path, jsonInventory);
            Console.WriteLine("Saved Successfully ");

        }
        public void LoadFromFile()
        {
            string path = @"D:\BridzeLabz\Inventory.jason";
            var json = File.ReadAllText(path);
            inventory = JsonConvert.DeserializeObject<Inventory>(json);
            PrintInventory();
            Console.WriteLine("Loaded Successfully ");
        }
        public void Edit()
        {
            Console.WriteLine("Enter the brand for which you want to edit");
            string brand = Console.ReadLine(); //a
            Seeds s = TakeUserInput();

            for (int i = 0; i < inventory.Rice.Count; i++)
            {
                if (inventory.Rice[i].Brand.Equals(brand))
                {
                    inventory.Rice[i] = s;
                }
            }
        }
        public void remove()
        {
            Console.WriteLine("Enter Which seed you want to remove:\n1 for Rice\n2 for pulse\n 3 wheat");
            var input = Console.ReadLine()[0];
            switch (input)
            {
                case '1':
                    Console.WriteLine("Enter Brand you want to remove:");
                    String brand = Console.ReadLine();
                    Seeds s1 = null;
                    foreach (var item in inventory.Rice)
                    {
                        if (item.Brand.Equals(brand))
                        {
                            s1 = item;
                        }
                    }
                    if (s1 != null)
                    {
                        inventory.Rice.Remove(s1);
                        Console.WriteLine("Deleted..!");
                    }
                    else
                    {
                        Console.WriteLine($"No brand found matching \"{brand}\"");
                    }
                    break;
                case '2':
                    Console.WriteLine("Enter Brand you want to remove:");
                    String brand2 = Console.ReadLine();
                    Seeds s2 = null;
                    foreach (var item in inventory.Pulses)
                    {
                        if (item.Brand.Equals(brand2))
                        {
                            s2 = item;
                        }
                    }
                    if (s2 != null)
                    {
                        inventory.Pulses.Remove(s2);
                        Console.WriteLine("Deleted..!");
                    }
                    else
                    {
                        Console.WriteLine($"No brand found matching \"{brand2}\"");
                    }
                    break;
                case '3':
                    Console.WriteLine("Enter Brand you want to remove:");
                    String brand3 = Console.ReadLine();
                    Seeds s3 = null;
                    foreach (var item in inventory.Wheat)
                    {
                        if (item.Brand.Equals(brand3))
                        {
                            s3 = item;
                        }
                    }
                    if (s3 != null)
                    {
                        inventory.Wheat.Remove(s3);
                        Console.WriteLine("Deleted..!");
                    }
                    else
                    {
                        Console.WriteLine($"No brand found matching \"{brand3}\"");
                    }
                    break;
                default:
                    break;
            }
        }

        public void PrintInventory()
        {
            Console.WriteLine(inventory.ToString());
        }
        private Seeds TakeUserInput()
        {
            Console.WriteLine("Enter Brand Name:");
            string BrandName = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            string WeightStr = Console.ReadLine();
            Console.WriteLine("Enter Price Per Kg:");
            string PriceStr = Console.ReadLine();
            Seeds s = new Seeds();
            s.Brand = BrandName;
            s.weight = int.Parse(WeightStr);
            s.PricePerKg = int.Parse(PriceStr);
            Console.WriteLine("Successully added..");
            return s;
        }
    }
}
