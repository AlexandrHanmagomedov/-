using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Class3
    {
        public static void Work3()
        {
            Console.WriteLine("Задание 3\nПользователь вводит с клавиатуры четыре цифры.\n" +
                "Необходимо создать число, содержащее эти цифры.\n" +
                "Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578. ");
            Console.WriteLine("input digit 1 ");
            string digit1 = Console.ReadLine();
            Console.WriteLine("input digit 2 ");
            string digit2 = Console.ReadLine();
            Console.WriteLine("input digit 3 ");
            string digit3 = Console.ReadLine();
            Console.WriteLine("input digit 4 ");
            string digit4 = Console.ReadLine();



            Console.WriteLine(" {0} result", digit1 +digit2+digit3+digit4);


        }
    }
}
