using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Class7
    {
        public static void Work7()
        {
            Console.WriteLine("Задание 7\n" +
                "Пользователь вводит с клавиатуры два числа.\n" +
                "Нужно показать все четные числа в указанном диапазоне.\n" +
                "Если границы диапазона указаны неправильно требуется произвести нормализацию границ.\n" +
                "Например, пользователь ввел 20 и 11, требуется нормализация,\n" +
                "после которой начало диапазона станет равно 11, а конец 20.");

            int temp=0;
            Console.WriteLine("\n Input first digit");
            int fd=Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Input second digit");
            int sd=Int32.Parse(Console.ReadLine());

            if (fd > sd)
            {
                Console.WriteLine("swap");
                temp = fd;
                fd = sd;
                sd = temp;

            }

            else if(fd == sd) {
                Console.WriteLine("nothing");
            }

            Console.WriteLine("Нужно показать все четные числа в указанном диапазоне.");
            while (fd <= sd)
            {               
                if (fd % 2 != 1)
                {
                    Console.Write(fd + ", ");
                }
                fd++;
            } 
        }
    }
}
