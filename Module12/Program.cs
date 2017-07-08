using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace Module12
{
    delegate void StartRace(string message);
    delegate void UI();
    class MyEvent
    {
        // Объявляем событие
        public event UI UserEvent;

        // Используем метод для запуска события
        public void OnUserEvent()
        {
            UserEvent();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Module12


            StartRace start = ComputeTime;
            List<Car> carList = new List<Car>();
            carList.Add(new SportsCar("BMW M3", 350));
            carList.Add(new Autobus("Belaz", 130));
            carList.Add(new CivilCar("Honda", 240));
            carList.Add(new Trucks("Volvo", 180));
            foreach (var item in carList)
            {
                item.showInfo();
            }
            int count = 0;
            double[] results = new double[carList.Count];
            foreach (var item in carList)
            {
                results[count] = item.move(start);
                count++;
            }

            MyEvent evt = new MyEvent();
            foreach (var item in carList)
            {
                evt.UserEvent += item.endOfGame;
            }

            evt.OnUserEvent();

            // не допилил
            //Console.WriteLine("Start game!");
            //Console.ReadKey();
            //drawGame(ref results);
            //Console.WriteLine();
        }
        //static void drawGame(ref double[] res)
        //{
        //    for (int j = 0; j < 20; j++)
        //    {
        //        for (int i = 0; i < 2; i++)
        //        {
        //            Console.WriteLine(" * * *");
        //            Console.WriteLine("   *");
        //        }
        //        Thread.Sleep(24);
        //        Console.Clear();
        //        for (int k = 0; k < j; k++)
        //            Console.WriteLine();
        //    }
        //}
        static void ComputeTime(string msg)
        {
            Console.WriteLine("Время автомобиля {0}", msg);
        }
    }
}
