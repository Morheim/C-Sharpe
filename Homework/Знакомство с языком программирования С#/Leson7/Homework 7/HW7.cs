using System;
using MyMetods;

namespace Homework_7
{
    public class HW7
    {
        public static void Run()
        {
            double[,] Array2DDouble;
            int[,] Array2DInt;

            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine(" Задайте двумерный массив размером m×n, заполненный случайными вещественными числами." +
                                  "\n\tm = 3, n = 4." +
                                  "\n\t0,5 7 - 2 - 0,2" +
                                  "\n\t1 - 3,3 8 - 9,9" +
                                  "\n\t8 7,8 - 7,1 9\n\n");


                Array2DDouble = Metod.Generate2DArrayDouble(Rows: Metod.InputNumInt("Enter size (Rows) array: "),
                                                            Columns: Metod.InputNumInt("Enter size (Сolumns) array: "),
                                                            MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                            MaxValue: Metod.InputNumInt("Enter random MaxValue: "),
                                                            IsRealNumber: Metod.InputBoolean("To fill in real numbers, enter (Yes) or (No): "),
                                                            decimals: 2);
                Metod.Array2DDoublePrint(Array2DDouble);
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine(" Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," +
                                  "и возвращает значение этого элемента или же указание, что такого элемента нет." +
                                  "\nНапример, задан массив:" +
                                  "\n\t1 4 7 2" +
                                  "\n\t5 9 2 3" +
                                  "\n\t8 4 2 4" +
                                  "\n\t17->такого числа в массиве нет\n\n");


                Array2DDouble = Metod.Generate2DArrayDouble(Rows: Metod.InputNumInt("Enter size (Rows) array: "),
                                                            Columns: Metod.InputNumInt("Enter size (Сolumns) array: "),
                                                            MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                            MaxValue: Metod.InputNumInt("Enter random MaxValue: "),
                                                            IsRealNumber: Metod.InputBoolean("To fill in real numbers, enter (Yes) or (No): "),
                                                            decimals: 2);
                Metod.Array2DDoublePrint(Array2DDouble);
                Metod.FindNumber2DArray(Array2DDouble, Metod.InputNumInt("\nEnter what number you want to find in the array: "));

            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                //Metod.Task(3);
                Console.WriteLine("Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце." +
                                  "\nНапример, задан массив:" +
                                  "\n\t1 4 7 2" +
                                  "\n\t5 9 2 3" +
                                  "\n\t8 4 2 4" +
                                  "\n\tСреднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.\n\n");


                Array2DInt = Metod.Generate2DArrayInt(Rows: Metod.InputNumInt("Enter size (Rows) array: "),
                                                      Columns: Metod.InputNumInt("Enter size (Сolumns) array: "),
                                                      MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                      MaxValue: Metod.InputNumInt("Enter random MaxValue: "));
                Metod.Array2DIntPrint(Array2DInt);
                Console.Write("\nСреднее арифметическое каждого столбца: ");
                Metod.ArrayDoublePrint(Metod.GetAverageByColumns(Array2DInt));
            }
        }
    }
}
