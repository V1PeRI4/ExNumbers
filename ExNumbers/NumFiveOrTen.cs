using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ExNumbers
{
    public static class NumFiveOrTen
    {
        public static void Calc()
        {
            Program.PrintLine();

            Console.WriteLine("Введите число");
            double num = InputNumbers.NumberEntry();

            Сomparisons(num);

            Program.PrintLine();
        }

        private static void Сomparisons(double num)
        {
            if (num == 5 || num == 10)
                Console.WriteLine($"Число либо равно 5, либо равно 10");
            else
                Console.WriteLine($"Неизвестное число");
        }
    }
}
