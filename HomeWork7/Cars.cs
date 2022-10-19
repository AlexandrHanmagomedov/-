using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal abstract class Cars : IComparable<Cars>
    {
        public static  Random Rand = new Random(Guid.NewGuid().GetHashCode());

        public string Model { get; set; }
        public int Speed { get;set; }
        public double Distance { get;set; }
        protected int MaxSpeed;
        protected double TotalMeters;
        protected Cars(string model, int maxSpeed, double range)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            TotalMeters = range;
        }
        public void ReSpeed()
        {
            int oldSpeed = Speed;
            int boost = (int)(oldSpeed * (TotalMeters / 100));

            if (Speed <= 10)
            {
                boost = MaxSpeed / 10;
                do
                {
                    Speed = Rand.Next(oldSpeed, oldSpeed + boost);
                } while (0 >= Speed || Speed >= MaxSpeed);
            }
            else if (Speed >= MaxSpeed - MaxSpeed / 10)
            {
                do
                {
                    Speed = Rand.Next(oldSpeed - boost, oldSpeed);
                } while (0 >= Speed || Speed >= MaxSpeed);
            }
            else
            {
                do
                {
                    Speed = Rand.Next(oldSpeed - boost, oldSpeed + boost) + oldSpeed / 15;
                } while (0 >= Speed || Speed >= MaxSpeed);
            }
        }
        public void Drive(int millisecond)
        {
            double second = millisecond / 1000D;
            Distance += Speed * 10000 / 3600D * second;
        }
        public bool Finish()
        {
            return Distance >= 100;
        }
        public int CompareTo(Cars other)
        {
            return this.Distance < other.Distance ? 1 : this.Distance > other.Distance ? -1 : 0;
        }
    }
}
