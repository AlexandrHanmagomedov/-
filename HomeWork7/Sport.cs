using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Sport : Cars
    {
        public Sport() : base("Sport", 300, 30) { }
        //    public string Number { get; set; }
        //    double CurrentDistanse;
        //    int CurrentSpeed { get; set; }
        //    bool isFinish = false;

        //    public event EventHandler Done;

        //    public Sport(string name, string number, int speed) : base(name, speed)
        //    {
        //        Number = number;
        //    }

        //    public double GetCurrentDistanse
        //    {
        //        get { return CurrentDistanse; }
        //    }
        //    public override void Finish()
        //    {
        //        if ((isFinish == true) && Done != null)
        //        {
        //            Done(this, EventArgs.Empty);
        //        }
        //    }

        //    public override void Move()
        //    {
        //        CurrentSpeed = Random.Next(0, Speed);
        //        CurrentDistanse += CurrentSpeed * Program.MetersPerSekond;
        //        if (CurrentDistanse >= Program.MetersTotal)
        //        {
        //            isFinish = true;
        //        }
        //    }

        //    public void StartRace()
        //    {
        //        CurrentDistanse = 0;
        //        CurrentDistanse = 0;
        //    }
        //    public override void PrintCar()
        //    {
        //        base.PrintCar();
        //        Console.Write($" number{Number}");
        //    }
        //    public override void ToStart()
        //    {
        //        PrintCar();
        //    }

        //}
    }
}
