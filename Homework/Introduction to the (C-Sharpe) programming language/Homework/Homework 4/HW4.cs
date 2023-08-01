using System;
using MyMetods;

namespace Homework_4
{
    public class HW4
    {
        public static void Run()
        {
            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B." +
                    "\n\t3, 5 -> 243 (3⁵)" +
                    "\n\t2, 4 -> 16\n\n");
                int A = Metod.InputNumInt("Enter the number: ");
                int B = Metod.InputNumInt($"Enter the number B to raise the number (A = {A}) to B: ");

                Console.WriteLine($"number (A = {A}) to the power of (B = {B}) = { Metod.MyPow(A, B)}");

            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе." +
                    "\n\t452 -> 11" +
                    "\n\t82 -> 10" +
                    "\n\t9012 -> 12\n\n");

                int Number = Metod.InputNumInt("Enter the number: ");
                Console.WriteLine($"The sum of all numbers in the given number {Number} = {Metod.SumAllDigit(Number)}");

            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(3);
                Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран." +
                    "\n\t1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]" +
                    "\n\t6, 1, 33 -> [6, 1, 33]\n\n");
                int[] Array = Metod.GenerateArrayInt(Size: Metod.InputNumInt("Enter the size of the array: "),
                                                     MinValue: Metod.InputNumInt("Enter the minimum value for the range of the random number: "),
                                                     MaxValue: Metod.InputNumInt("Enter the maximum value for the range of the random number: ")
                                                     );
                Metod.ArrayIntPrint(Array);
            }

            Metod.End();
        }
    }
}
