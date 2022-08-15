using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAChallenge.Entities
{
    public class Medicine
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Medicine(string name)
        {
            var random = new Random();
            Name = name;
            Price = random.NextInt64(1, 1000) + random.NextDouble();
        }

        public override string ToString()
        {
            return $"{Price.ToString("C2")}, {Name}";
        }

    }
}
