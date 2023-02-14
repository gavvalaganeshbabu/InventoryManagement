using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    internal class Inventory
    {
        public Inventory()
        {
            Rice = new List<Seeds>();
            Pulses = new List<Seeds>();
            Wheat = new List<Seeds>();
        }
        public List<Seeds> Rice { get; set; }
        public List<Seeds> Pulses { get; set; }
        public List<Seeds> Wheat { get; set; }
        public override string ToString()
        {
            string result = "";
            result = result + "\nRice: \n";
            foreach (Seeds seed in Rice)
            {
                result = result+ seed.ToString();
            }
            result =result+ "\nWheat: \n";
            foreach (Seeds s in Wheat)
            {
                result =result+ s.ToString();
            }
            result =result+ "\nPulse: \n";
            foreach (Seeds s in Pulses)
            {
                result =result+ s.ToString();
            }
            return result;
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return $"Id is: {Id} Name is: {Name}";
        }
    }
}
