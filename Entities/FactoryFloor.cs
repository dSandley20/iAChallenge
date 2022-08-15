using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAChallenge.Entities
{
    public class FactoryFloor
    {
        public Dictionary<string, Fill> Fills = new Dictionary<string, Fill>();
        
        /*
        [0] - Medicine A
        [1] - Medicine B
        [2] - Medicine C
         */
        public List<string> LowestPrices = new() { "-10,-10", "-10,-10", "-10,-10"};
        
        public int CurrentId = 0;

        public FactoryFloor()
        {
           GenerateWorld();
        }

        public void GenerateWorld()
        {
            Fills.Clear();
            CurrentId = 0;
            LowestPrices = new() { "-10,-10", "-10,-10", "-10,-10" };

            for (int x = -10; x <= 10; x++)
            {
                for (int y = -10; y <= 10; y++)
                {
                    Fill newFill = new Fill($"Central Fill {CurrentId}", x, y);
                    Fills.Add($"{x},{y}", newFill);
                    if (Fills[LowestPrices[0]].Inventory[0].Price > newFill.Inventory[0].Price) LowestPrices[0] = $"{x},{y}";
                    if (Fills[LowestPrices[1]].Inventory[1].Price > newFill.Inventory[1].Price) LowestPrices[1] = $"{x},{y}";
                    if (Fills[LowestPrices[2]].Inventory[2].Price > newFill.Inventory[2].Price) LowestPrices[2] = $"{x},{y}";
                    CurrentId++;
                }
            }
        }

        public void RetreiveFillUnsorted(string location)
        {
            var LowestPriceA = location;
            var LowestPriceB = location;
            var LowestPriceC = location;

            for (int x = -10; x <= 10; x++)
            {
                for (int y = -10; y <= 10; y++)
                {
                    if (Fills[$"{x},{y}"].Inventory[0].Price < Fills[LowestPriceA].Inventory[0].Price) LowestPriceA = $"{x},{y}";
                    if (Fills[$"{x},{y}"].Inventory[1].Price < Fills[LowestPriceB].Inventory[1].Price) LowestPriceB = $"{x},{y}";
                    if (Fills[$"{x},{y}"].Inventory[2].Price < Fills[LowestPriceC].Inventory[2].Price) LowestPriceC = $"{x},{y}";
                }
            }

            LogResults(LowestPriceA, LowestPriceB, LowestPriceC, location);
        }

        public void RevtreiveFillStored(string location)
        {
            Fill SelectedMill = Fills[location];
            LogResults(LowestPrices[0], LowestPrices[1], LowestPrices[2], location);
        }

        int FindDistanceBetweenFills(Fill start, Fill destination)
        {
            return Math.Abs(start.X - destination.X) + Math.Abs(start.Y - destination.Y);
        }

        string FormatResult(Fill mill, int inventorySpot ,int distance)
        {
            return $"{mill.Name} - {mill.Inventory[inventorySpot]}, Distance {distance} ";
        }

        void LogResults(string medicineLocationA, string medicineLocationB, string medicineLocationC, string startingLocation )
        {
            Console.WriteLine($"Closest Central Fills to ({startingLocation}):");
            Console.WriteLine(FormatResult(Fills[medicineLocationA], 0, FindDistanceBetweenFills(Fills[startingLocation], Fills[medicineLocationA])));
            Console.WriteLine(FormatResult(Fills[medicineLocationB], 1, FindDistanceBetweenFills(Fills[startingLocation], Fills[medicineLocationB])));
            Console.WriteLine(FormatResult(Fills[medicineLocationC], 2, FindDistanceBetweenFills(Fills[startingLocation], Fills[medicineLocationC])));
        }
    }
}
