using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAChallenge.Entities
{
    public class Fill
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        
        public List<Medicine> Inventory  = new List<Medicine>();

        public Fill (string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
            for (int i = 65; i <= 68; i++)
            {
                Inventory.Add(new Medicine($"Medication {(char)i}"));
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, X: {X}, Y: {Y}, Medicine 1: {Inventory[0]}, Medicine 2: {Inventory[1]}, Medicine 3: {Inventory[2]}";
        }
    }
}
