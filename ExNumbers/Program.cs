using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            bool isWork = true;
            bool clearConsole = false;  // Переменная для определения первый ли раз запускается задания

            do
            {
                if (clearConsole == true)
                {
                    Console.WriteLine("Для продолжения нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.Write("Введите номер задание: \n" +
                    "\t1) Сравнение двух чисел \n" +
                    "\t2) Число больше 5 и меньше 10 \n" +
                    "\t3) Число либо равно 5, либо равно 10 \n" +
                    "\t4) Вычисление вклада по процентам \n" +
                    "\t5) Вычисление вклада по процентам с бонусами \n" +
                    "\t0) Выйти с консоли\n" +
                    "Выбранный номер: ");
                num = InputNumbers.NumberEntryInt();

                switch (num)
                {
                    case 1:
                        NumberComparison.Calc();
                        clearConsole = true;
                        break;
                    case 2:
                        NumberBetweenFiveTen.Calc();
                        clearConsole = true;
                        break;
                    case 3:
                        NumFiveOrTen.Calc();
                        clearConsole = true;
                        break;
                    case 4:
                        BankDepos.CalcDepos();
                        clearConsole = true;
                        break;
                    case 5:
                        BankDeposBonus.CalcDepos();
                        clearConsole = true;
                        break;
                    case 0:
                        isWork = false;
                        break;
                    default:
                        PrintLine();
                        Console.WriteLine("Введите корректный номер задания!");
                        clearConsole = true;
                        PrintLine();
                        break;
                }
            }
            while (isWork);

        }

        public static void PrintLine()
        {
            Console.WriteLine("---------------------------------------");
        }

        
    }
}
