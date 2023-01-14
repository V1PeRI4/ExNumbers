using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNumbers
{
    internal class NumberComparison
    {
        public static void Calc()
        {
            Program.PrintLine();

            Console.WriteLine("Введите 2 числа");
            double firstNum = InputNumbers.NumberEntry();
            double secondNum = InputNumbers.NumberEntry();

            Сomparisons(firstNum, secondNum);

            Program.PrintLine();
        }

        private static void Сomparisons(double firstNum, double secondNum)
        {
            if (firstNum == secondNum)
                Console.WriteLine($"{firstNum} = {secondNum}");
            else if (firstNum > secondNum)
                Console.WriteLine($"{firstNum} > {secondNum}");
            else
                Console.WriteLine($"{secondNum} > {firstNum}");
        }
    }
}
