using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Program
    {
        public static double MetersPerSekond { get; set; }=1.0/60;
        public static double MetersTotal { get; set; } = 100;
        static void Main(string[] args)
        {

            Cars[] cars = new Cars[]{new Bus(),new Truck(),new Sport(),new Jiguli() };

            Road road = new Road(cars);
            road.Track();
            
        }
    }

}
