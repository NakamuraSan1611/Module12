using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    class Autobus : Car
    {
        private int numOfPlaces;
        public Autobus(string name, double speed) : base(name, speed)
        {
            numOfPlaces = GetRandomNumber(10, 20);
        }
        public override void showInfo()
        {
            Console.WriteLine("\nBrand name: {0}\t Max speed: {1}", name, speed);
            Console.WriteLine("Specials:\nNumber of places: {0}", numOfPlaces);
        }
        public override double move(StartRace method)
        {
            double res = 100 + (-speed + numOfPlaces * 0.5) / 10;
            method(res.ToString());
            return res;
        }
        public override void endOfGame()
        {
            Console.WriteLine("{0} финишировал!", name);
        }
    }
}
