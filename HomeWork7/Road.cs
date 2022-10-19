using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Road    {
        private Cars[] Cars;
        public Road(params Cars[] cars)
        {
            Cars = cars;
            foreach (var car in Cars)
            {
                EDrive += car.Drive;
                EReSpeed += car.ReSpeed;
            }
        }
        public delegate void Drive(int millisecond);
        public event Drive EDrive;
        public delegate void ReSpeed();
        public event ReSpeed EReSpeed;
        public void Track()
        {
            bool route = true;
            while (route)
            {
                EReSpeed?.Invoke();
                EDrive?.Invoke(10);

                Info();

                foreach (var car in Cars)
                {
                    if (route) 
                    { 
                        route = !car.Finish(); 
                    }
                    if (!route)
                    {
                        Console.SetCursorPosition(40,1);
                        Console.Write("Winner");
                        Console.Read();
                        break;
                    }
                }
            }
        }
        public void Info()
        {
         
            Console.Clear();
            Array.Sort(Cars);
            Console.Write("\n");
            for (var i = 0; i < Cars.Length; i++)
            {
               
                Console.WriteLine((i + 1 < 10 ? "\t" : "")+Cars[i].Model + $"\t{Cars[i].Speed}km/h\t{Math.Round(Cars[i].Distance)}km");
            }

            Thread.Sleep(100);
        }
    }
}
