using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Class4
    {
        public static void Work4()
        {
            Console.WriteLine(" Задание 4\nПользователь вводит шестизначное число." +
                "После чего пользователь вводит номера разрядов для обмена цифр.\n" +
                "Например, если пользователь ввёл один и шесть — это значит,\n" +
                " что надо обменять местами первую и шестую цифры.Число 723895 должно превратиться в 523897.\n" +
                "Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.");

            Console.WriteLine("Input 6 digit ");
            
            string number = Console.ReadLine();
            if (number.Length != 6) {
                throw new ArgumentException("Если пользователь ввел " +
                    "не шестизначное число требуется вывести сообщение об ошибке. ");
            }
            
            Console.WriteLine("Input first Discharge 1-6 ");
            int fd = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input second Discharge 1-6 ");
            int sd = Int32.Parse(Console.ReadLine());
            if(Math.Min(fd-1, sd-1) < 0||Math.Max(fd-1,sd-1)>5){
                throw new IndexOutOfRangeException("out of randge index");
            }
            Console.WriteLine(number+" "+fd+" "+sd);

            char[]digits=number.ToCharArray();
           
            (digits[sd-1], digits[fd-1]) = (digits[fd-1], digits[sd-1]);

            Console.WriteLine(new string (digits));

        }


    }
}
