using System;
using MyMetods;

namespace Homework_5
{
    public class HW5
    {
        public static void Run()
        {
            double[] MyArray;

            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве." +
                                  "\n\t[345, 897, 568, 234] -> 2\n\n");


                MyArray = Metod.GenerateArrayDouble(Size: Metod.InputNumInt("Enter size array: "),
                                                    MinValue: 1,
                                                    MaxValue: 10
                                                    );
                Metod.ArrayDoublePrint(MyArray);

                int EvenNumbers = 0;

                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i] % 2 == 0)
                    {
                        EvenNumbers++;
                    }
                }
                Console.WriteLine($"\n\tSum of even numbers in an array = {EvenNumbers}");
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях." +
                                  "\n\t[3, 7, 23, 12] -> 19" +
                                  "\n\t[-4, -6, 89, 6] -> 0\n\n");


                MyArray = Metod.GenerateArrayDouble(Size: Metod.InputNumInt("Enter size array: "),
                                                    MinValue: 1,
                                                    MaxValue: 10
                                                    );
                Metod.ArrayDoublePrint(MyArray);

                double SumOfOddPositions = 0;

                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        SumOfOddPositions += MyArray[i];
                    }
                }
                Console.WriteLine($"\n\tsum of numbers in odd array positions = {SumOfOddPositions}");
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(3);
                Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива." +
                                  "\n\t[345, 897, 568, 234] -> 2\n\n");


                MyArray = Metod.GenerateArrayDouble(Size: Metod.InputNumInt("Enter size array: "),
                                                    MinValue: 100,
                                                    MaxValue: 999,
                                                    IsRealNumber: true,
                                                    decimals: 2
                                                    );
                Metod.ArrayDoublePrint(MyArray);

                double MaxNum = MyArray[0];
                double MinNum = MyArray[0];

                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i] > MaxNum)
                    {
                        MaxNum = MyArray[i];
                    }
                    else
                    {
                        if (MyArray[i] < MinNum)
                        {
                            MinNum = MyArray[i];
                        }
                    }
                }
                Console.WriteLine($"\tMaxNum = {MaxNum}\n\n\tMinNum = {MinNum}\n\n\tnumber difference {MaxNum - MinNum}\n\n");
            }
        }
    }
}
