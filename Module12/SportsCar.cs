using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    class SportsCar : Car
    {
        
        private double intake { get; set; }
        private double turbochargerBoost { get; set; }
        public SportsCar(string name, double speed) : base(name, speed)
        {
            this.intake = GetRandomNumber(5, 10);
            this.turbochargerBoost = GetRandomNumber(15, 30);
        }
        public override void showInfo()
        {
            Console.WriteLine("\nBrand name: {0}\t Max speed: {1}", name, speed);
            Console.WriteLine("Specials:\nIntake: {0}\t Turbo boost: {1}\n", intake, turbochargerBoost);
        }
        public override double move(StartRace method)
        {
            double res = 100 + (-intake - turbochargerBoost - speed) / 10;
            method(res.ToString());
            return res;
        }
        public override void endOfGame()
        {
            Console.WriteLine("{0} финишировал!", name);
        }
    }
}
