using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    class Trucks : Car
    {
        private double load;
        public Trucks(string name, double speed) : base(name, speed)
        {
            this.load = GetRandomNumber(5, 50);
        }
        public override void showInfo()
        {
            Console.WriteLine("\nBrand name: {0}\t Max speed: {1}", name, speed);
            Console.WriteLine("Specials:\nMax Load: {0}", load);
        }
        public override double move(StartRace method)
        {
            double res = 100 + (-speed + load * 0.8) / 10;
            method(res.ToString());
            return res;
        }
        public override void endOfGame()
        {
            Console.WriteLine("{0} финишировал!", name);
        }
    }
}
