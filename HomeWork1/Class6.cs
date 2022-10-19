using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Class6
    {
        public static void Work6()  
        {
            Console.WriteLine("Задание 6\n    Пользователь вводит с клавиатуры показания температуры.\n  " +
                "В зависимости от выбора пользователя программа переводит температуру\n" +
                " из Фаренгейта в Цельсий или наоборот.");
            

            Console.WriteLine("1 for convert to Farenheit, 2 for convert to Celcius");
            int choise = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input thermometer readings ");
            int tes = Int32.Parse(Console.ReadLine());

            if (choise == 1)
            {
            
                Console.WriteLine(" {0} in Farenheit ",tes *1.8+ 32);
            }
            else if (choise == 2)
            {
            
                Console.WriteLine(" {0} in Celcius ",(tes -32) /1.8);
            }
        }

    }
}
