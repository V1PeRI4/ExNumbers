using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ExNumbers
{
    public static class NumberBetweenFiveTen
    {
        public static void Calc()
        {
            Program.PrintLine();

            double numString = 0;

            Console.WriteLine("Введите число");
            numString = InputNumbers.NumberEntry();

            Сomparisons(numString);

            Program.PrintLine();
        }

        private static void Сomparisons(double num)
        {
            if (num > 5 && num < 10)
                Console.WriteLine($"Число больше 5 и меньше 10");
            else
                Console.WriteLine($"Неизвестное число");
        }
       
    }
}
