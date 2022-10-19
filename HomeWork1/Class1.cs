using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
 class Class1
 {
        public static void Work1()
        {
            Console.WriteLine(" Задание 1\n" +
                "Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.\n" +
                "Если число кратно 3(делится на 3 без остатка) нужно вывести слово Fizz.\n" +
                "Если число кратно 5 нужно вывести слово Buzz.\n" +
                "Если число кратно 3 и 5 нужно вывести Fizz Buzz.\n" +
                "Если число не кратно не 3 и 5 нужно вывести само число.\n"+
                "Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.");
            int? number = null;
            Console.WriteLine("input number");
            number = number ?? 50;
            number = Int32.Parse( Console.ReadLine());
            if (number > 100||number<=0)
            {
                Console.WriteLine("Wrong number");
                return;
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if(number%3==0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }



        }

       

    }
}
