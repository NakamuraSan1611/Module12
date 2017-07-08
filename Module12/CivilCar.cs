using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    class CivilCar : Car
    {
        private double tirePoints;
        public CivilCar(string name, double speed) : base(name, speed)
        {
            this.tirePoints = GetRandomNumber(-10, 10);
        }
        public override void showInfo()
        {
            Console.WriteLine("\nBrand name: {0}\t Max speed: {1}", name, speed);
            Console.WriteLine("Specials:\nTire points: {0}", tirePoints);
        }
        public override double move(StartRace method)
        {
            double res = 100 + (-speed + tirePoints) / 10;
            method(res.ToString());
            return res;
        }
        public override void endOfGame()
        {
            Console.WriteLine("{0} финишировал!", name);
        }
    }
}
