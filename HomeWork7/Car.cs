//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork7
//{
//    internal abstract class Car
//    {
//        public int Speed { get; set; }
//        public string Name { get; set; }

//        public Random Random=new Random(Guid.NewGuid().GetHashCode());

//        public Car(string name,int speed)
//        {
//            Name = name;
//            Speed = speed;
//        }

//        public abstract void Move();
//        public abstract void Finish();
//        public virtual void PrintCar()
//        {
//            Console.Write($"\n{Name}");
//        }

//        public virtual void ToStart()
//        {
//            PrintCar();
//        }

//    }
//}
