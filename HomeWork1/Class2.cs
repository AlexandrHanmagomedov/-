using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Class2
    {
        public static void Work2()
        {
            Console.WriteLine("Задание 2\n" +
                "Пользователь вводит с клавиатуры два числа.\n" +
                "Первое число — это значение, второе число процент, который необходимо посчитать.\n" +
                "Например, мы ввели с клавиатуры 90 и 10.\n" +
                "Требуется вывести на экран 10 процентов от 90.Результат: 9. ");
            Console.WriteLine("input number");
            float number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input percent");
            float percent = Int32.Parse(Console.ReadLine());
            Console.WriteLine( " {0} %",number/100f*percent);

        }
    }
}
