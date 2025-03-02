using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomItemMenu
{
    internal class MenuItem
    {
        public Random randomizer = new Random();
        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[randomizer.Next(Condiments.Length)];
            string randomBread = Breads[randomizer.Next(Breads.Length)];

             Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal bucks = randomizer.Next(2, 5);
            decimal cents = randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.1M);
            Price = price.ToString("c");                                 
        }

    }
}
