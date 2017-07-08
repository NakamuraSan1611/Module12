using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Module12
{
    abstract class Car
    {
        protected string name { get; set; }
        protected double speed { get; set; }
        protected Car(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }
        public abstract double move(StartRace method);
        public abstract void showInfo();
        public abstract void endOfGame();
        // нормальный рандом
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        protected static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }
    }
}