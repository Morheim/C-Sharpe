using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Task(1, true);
                Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B." +
                    "\n\t3, 5 -> 243 (3⁵)" +
                    "\n\t2, 4 -> 16\n\n");
                int A = PrintNum("Enter the number: ");
                int B = PrintNum($"Enter the number B to raise the number (A = {A}) to B: ");

                Console.WriteLine($"number (A = {A}) to the power of (B = {B}) = { MyPow(A, B)}");

            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Task(2);
                Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе." +
                    "\n\t452 -> 11" +
                    "\n\t82 -> 10" +
                    "\n\t9012 -> 12\n\n");

                int Number = PrintNum("Enter the number: ");
                Console.WriteLine($"The sum of all numbers in the given number {Number} = {SumAllDigit(Number)}");

            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Task(3);
                Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран." +
                    "\n\t1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]" +
                    "\n\t6, 1, 33 -> [6, 1, 33]\n\n");
                int Size = PrintNum("Enter the size of the array: ");
                int MinValue = PrintNum("Enter the minimum value for the range of the random number: ");
                int MaxValue = PrintNum("Enter the maximum value for the range of the random number: ");
                int[] Array = GenerateArray(Size, MinValue, MaxValue);

                PrintArray(Array);
            }

            /*______________________________________________________________________________________________________________________________________*/
            int PrintNum(string Messadge)
            {
                Console.Write(Messadge);
                string NumString = Console.ReadLine();
                int NumInt = Convert.ToInt32(NumString);
                return NumInt;
            }

            double MyPow(double x, double y)
            {
                double Product = x;
                for (int i = 1; i < y; i++)
                {
                    Product *= x;
                }
                return Product;
            }

            int SumAllDigit(int Number)
            {
                int Result = 0;
                while (Number > 0)
                {
                    Result += Number % 10;
                    Number = Number / 10;
                }
                return Result;
            }

            int[] GenerateArray(int Size, int MinValue, int MaxValue)
            {
                int[] Array = new int[Size];
                Random Random = new Random();
                for(int i = 0; i < Size; i++)
                {
                    Array[i] = Random.Next(MinValue, MaxValue + 1);
                }
                return Array;
            }

            void PrintArray(int[] Array)
            {
                Console.Write("[");
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    Console.Write($"{Array[i]}, ");
                }
                Console.Write($"{Array[Array.Length - 1]}");
                Console.WriteLine("]");
            }

            /*______________________________________________________________________________________________________________________________________*/
            void Task(int TaskNum, bool IsFirstTask = false)
            {
                if (!IsFirstTask)
                {
                    Console.Write("\n\n\npress Enter to proceed to the next task\n\n");
                    Console.ReadKey();
                }
                Console.Write($"\n+++++++++++++++++++ Task {TaskNum} +++++++++++++++++++\n\n\n");
            }
        }
    }
}
