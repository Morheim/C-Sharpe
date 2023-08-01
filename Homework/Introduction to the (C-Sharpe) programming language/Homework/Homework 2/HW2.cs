using System;
using MyMetods;

namespace Homework_2
{
    public class HW2
    {
        public static void Run()
        {
            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа." +
                    "\n\t456 -> 5" +
                    "\n\t782 -> 8" +
                    "\n\t918 -> 1\n\n");

                int Number = Metod.InputNumInt("Enter a three-digit number: ");
                if (Number < 100 || Number >= 1000)
                {
                    Console.WriteLine("You entered the wrong number, repeat the input");
                    return;
                }

                Console.WriteLine($"Enter a number = {Number}");
                int SecondDigit = Number / 10 % 10;
                Console.WriteLine($"The second digit = {SecondDigit}");

            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет." +
                    "\n\t645 -> 5" +
                    "\n\t78 -> третьей цифры нет" +
                    "\n\t32679 -> 6\n");

                int Number = Metod.InputNumInt("Enter a number: ");
                if (Metod.CheckingANumberForThreeDigits(Number))
                {
                    Console.WriteLine(Metod.ReductionToThreeDigits(Number));
                }
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(3);
                Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным." +
                    "\n\t6 -> да" +
                    "\n\t7 -> да" +
                    "\n\t1 -> нет\n");

                int Weekday = Metod.InputNumInt("Enter the day of the week: ");
                if (Metod.IsValidateWeekday(Weekday))
                {
                    if (Metod.IsWeekend(Weekday))
                    {
                        Console.WriteLine("Day off of the week");
                    }
                    else
                    {
                        Console.WriteLine("Working day of the week");
                    }
                }
            }

            Metod.End();
        }
    }
}
