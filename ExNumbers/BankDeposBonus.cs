using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNumbers
{
    public static class BankDeposBonus
    {
        public static void CalcDepos()
        {
            Program.PrintLine();

            double SumDepos = 0;
            Console.Write("Введите первоначальный депозит:  ");

            SumDepos = InputNumbers.NumberEntry();
            SumDepos = CalcPersent(SumDepos);
            Console.WriteLine($"Сумма депозита с процентами и бонус 15 у.е.: {SumDepos}");

            Program.PrintLine();
        }

        private static double CalcPersent(double SumDepos)
        {
            if (SumDepos < 100 && SumDepos > 0)
                return SumDepos * 1.07 + 15;
            else if (SumDepos > 100 && SumDepos < 200)
                return SumDepos * 1.09 + 15;
            else if (SumDepos > 200)
                return SumDepos * 1.12 + 15;
            else
                return 0;
        }

    }
}
