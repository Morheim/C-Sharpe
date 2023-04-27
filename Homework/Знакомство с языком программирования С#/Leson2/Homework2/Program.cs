using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(1, true);
                Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа." +
                    "\n\t456 -> 5" +
                    "\n\t782 -> 8" +
                    "\n\t918 -> 1\n\n");

                int Number = PrintNum("Enter a three-digit number: ");
                if (Number < 100 || Number >= 1000)
                {
                    Console.WriteLine("You entered the wrong number, repeat the input");
                    return;
                }

                Console.WriteLine($"Entered number = {Number}");
                int SecondDigit = Number / 10 % 10;
                Console.WriteLine($"The second digit = {SecondDigit}");

            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(2);
                Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет." +
                    "\n\t645 -> 5" +
                    "\n\t78 -> третьей цифры нет" +
                    "\n\t32679 -> 6\n");

                int Number = PrintNum("Enter a number: ");
                if (CheckingANumberForThreeDigits(Number))
                {
                    Console.WriteLine(ReductionToThreeDigits(Number));
                }
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(3);
                Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным." +
                    "\n\t6 -> да" +
                    "\n\t7 -> да" +
                    "\n\t1 -> нет\n");

                int Weekday = PrintNum("Enter the day of the week: ");
                if (IsValidateWeekday(Weekday))
                {
                    if(IsWeekend(Weekday))
                    {
                        Console.WriteLine("Day off of the week");
                    }
                    else
                    {
                        Console.WriteLine("Working day of the week");
                    }
                }
            }

            /*______________________________________________________________________________________________________________________________________*/
            int PrintNum(string Messadge)
            {
                Console.Write(Messadge);
                string NumString = Console.ReadLine();
                int NumInt = Convert.ToInt32(NumString);
                return NumInt;
            }

            int ReductionToThreeDigits(int Number)
            {
                while (Number > 999)
                {
                    Number /= 10;
                }
                return Number % 10;
            }

            bool CheckingANumberForThreeDigits(int Number)
            {
                if (Number < 100)
                {
                    Console.WriteLine("There is no third digit");
                    return false;
                }
                return true;
            }

            bool IsWeekend(int Weekday)
            {
                if (Weekday > 5)
                {
                    return true;
                }
                return false;
            }

            bool IsValidateWeekday(int Number)
            {
                if (Number > 0 && Number <= 7)
                {
                    return true;
                }

                Console.WriteLine("It's not a day of the week");
                return false;
            }
            /*______________________________________________________________________________________________________________________________________*/
            void DZ(int num, bool TheFirstNumber = false)
            {
                if (!TheFirstNumber)
                {
                    Console.Write("\n\n\npress Enter to proceed to the next task\n\n");
                    Console.ReadKey();
                }
                Console.Write($"\n+++++++++++++++++++DZ{num}+++++++++++++++++++\n\n\n");
            }
        }
    }
}
