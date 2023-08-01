using System;
using MyMetods;

namespace Homework_8
{
    public class HW8
    {
        public static void Run()
        {
            int[,] Array2DInt;

            ///TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine(" Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива." +
                                  "\n\n\tНапример, задан массив:" +
                                  "\n\t1 4 7 2" +
                                  "\n\t5 9 2 3" +
                                  "\n\t8 4 2 4" +
                                  "\n\n\tВ итоге получается вот такой массив:" +
                                  "\n\t7 4 2 1" +
                                  "\n\t9 5 3 2" +
                                  "\n\t8 4 4 2\n\n");


                Array2DInt = Metod.Generate2DArrayInt(Rows: Metod.InputNumInt("Enter size (Rows) array: "),
                                                      Columns: Metod.InputNumInt("Enter size (Сolumns) array: "),
                                                      MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                      MaxValue: Metod.InputNumInt("Enter random MaxValue: ")
                                                      );
                Metod.Array2DIntPrint(Array2DInt);
                Metod.OrderArrayLinesMaxToMin(Array2DInt);
                Console.WriteLine("\nLine-by-line ordered 2D array\n");
                Metod.Array2DIntPrint(Array2DInt);
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine(" Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов." +
                                  "\n\n\tНапример, задан массив:" +
                                  "\n\t1 4 7 2" +
                                  "\n\t5 9 2 3" +
                                  "\n\t8 4 2 4" +
                                  "\n\t5 2 6 7" +
                                  "\n\n\tПрограмма считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка\n\n");


                Array2DInt = Metod.Generate2DArrayInt(Rows: Metod.InputNumInt("Enter size (Rows) array: "),
                                                      Columns: Metod.InputNumInt("Enter size (Сolumns) array: "),
                                                      MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                      MaxValue: Metod.InputNumInt("Enter random MaxValue: ")
                                                      );
                Metod.Array2DIntPrint(Array2DInt);
                Metod.MinSumRow(Array2DInt);
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(3);
                Console.WriteLine(" Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц." +
                                  "\n\n\tНапример, даны 2 матрицы:" +
                                  "\n\t2 4 | 3 4" +
                                  "\n\t3 2 | 3 3" +
                                  "\n\n\tРезультирующая матрица будет:" +
                                  "\n\t18 20" +
                                  "\n\t15 18\n\n");

                int a = Metod.InputNumInt("Enter the number of columns of the first matrix: ");
                int b = Metod.InputNumInt("Enter the number of columns of the first matrix (and rows of the second): ");
                int c = Metod.InputNumInt("Enter the number of columns of the second matrix: ");

                int MinRand = Metod.InputNumInt("Enter random Min Value: ");
                int MaxRand = Metod.InputNumInt("Enter random Max Value: ");


                int[,] MatFirst = Metod.Generate2DArrayInt(Columns: a, Rows: b, MinValue: MinRand, MaxValue: MaxRand);
                Console.WriteLine($"\n\n First martrix");
                Metod.Array2DIntPrint(MatFirst);


                int[,] MatSecomd = Metod.Generate2DArrayInt(Columns: b, Rows: c, MinValue: MinRand, MaxValue: MaxRand);
                Console.WriteLine($"\n\n Secomd martrix:");
                Metod.Array2DIntPrint(MatSecomd);


                int[,] MatResult = Metod.Generate2DArrayInt(Columns: a,Rows: c, MinValue: MinRand, MaxValue: MaxRand);
                Metod.MultiplyMatrix(MatFirst, MatSecomd, MatResult);
                Console.WriteLine($"\n\n The product of the first and second matrices:");
                Metod.Array2DIntPrint(MatResult);
            }

            //TASK4/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(4);
                Console.WriteLine(" Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента." +
                                  "\n\n\tМассив размером 2 x 2 x 2" +
                                  "\n\t66(0,0,0) 25(0,1,0)" +
                                  "\n\t34(1,0,0) 41(1,1,0)" +
                                  "\n\t27(0,0,1) 90(0,1,1)" +
                                  "\n\t26(1,0,1) 55(1,1,1)\n\n");


                int[,,]Array3DInt = Metod.Generate3DArrayInt(Rows: Metod.InputNumInt("Enter size (Rows/Y) array: "),
                                                             Columns: Metod.InputNumInt("Enter size (Columns/X) array: "),
                                                             Layers: Metod.InputNumInt("Enter size (Layers/Z) array: "),
                                                             MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                             MaxValue: Metod.InputNumInt("Enter random MaxValue: "));
                Metod.Array3DIntPrint(Array3DInt);
            }

            //TASK5/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(5);
                Console.WriteLine(" Напишите программу, которая заполнит спирально массив 4 на 4." +
                                  "\n\n\tНапример, на выходе получается вот такой массив:" +
                                  "\n\t01 02 03 04" +
                                  "\n\t12 13 14 05" +
                                  "\n\t11 16 15 06" +
                                  "\n\t10 09 08 07\n\n");


                int n = Metod.InputNumInt("Enter size (Rows) array: ");
                Array2DInt = Metod.Generate2DArrayInt(Columns: n,
                                                      Rows: n,
                                                      MinValue: Metod.InputNumInt("Enter random MinValue: "),
                                                      MaxValue: Metod.InputNumInt("Enter random MaxValue: ")
                                                      );

                Console.WriteLine("\nGenerated array\n");
                Metod.Array2DIntPrint(Array2DInt);


                Console.WriteLine("\nSpirally filled array\n");
                Metod.Array2DIntPrint(Metod.SpirallyFilledArray(Array2DInt));
            }

            Metod.End();
        }
    }
}
