using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNumbers
{
    public static class InputNumbers
    {
        public static double NumberEntry()
        {
            bool isNum = false;
            double num = 0;
            do
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    isNum = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (isNum == false);
            return num;
        }

        public static int NumberEntryInt()
        {
            bool isNum = false;
            int num = 0;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    isNum = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (isNum == false);
            return num;
        }
    }
}
