using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Reflection;
namespace HomeWork1
{
    internal class Class5
    {
        public static void Work5()
        {
            Console.WriteLine(" Задание 5\n Пользователь вводит с клавиатуры дату.\n" +
                "Приложение должно отобразить название сезона и дня недели.\n" +
                "Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.");
            Console.WriteLine("Input Date (dd.mm.yyyy)");
            CultureInfo culture = CultureInfo.InvariantCulture;

            DateTime dt = new DateTime();
            dt = DateTime.Parse(Console.ReadLine());
            string[] cultureNames = {"ru-RU"};
            foreach (var cultureName in cultureNames)
            {
                Console.WriteLine("{2}",culture.Name,culture.DateTimeFormat.LongDatePattern,dt.ToString("D", culture));
            }
            if (dt.Month ==12|| dt.Month <= 2|| dt.Month == 2)
            {
                Console.WriteLine("LadyWinter");
            }
            else if (dt.Month >= 3 && dt.Month <= 5)
            {
                Console.WriteLine("Spring");
            }
            else if(dt.Month >= 6 && dt.Month <= 8)
            {
                Console.WriteLine("Summer");
            }
            else if(dt.Month >= 9 && dt.Month <= 11)
            {
                Console.WriteLine("Autumn");
            }
        }
    }
}

    

