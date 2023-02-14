using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    internal class Seeds
    {
        public string Brand { get; set; }
        public int weight { get; set; }
        public int PricePerKg { get; set; }
        public override string ToString()
        {
            return $"Brand: {Brand}\n Weight: {weight}\n PricePerKg: {PricePerKg}";
        }
    }
}
