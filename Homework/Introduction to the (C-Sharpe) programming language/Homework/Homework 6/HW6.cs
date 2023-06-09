using System;
using MyMetods;

namespace Homework_6
{
    public class HW6
    {
        public static void Run()
        {
            int[] MyArray;

            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine(" Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь." +
                                  "\n\t0, 7, 8, -2, -2 -> 2" +
                                  "\n\t1, -7, 567, 89, 223-> 3\n\n");

                MyArray = Metod.InputArrayInt(Metod.InputNumInt("Enter size array: "));
                Metod.ArrayIntPrint(MyArray);
                Console.WriteLine($"Number of positive numbers in the array = {Metod.CountPositiveNumbers(MyArray)}");
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine(" Напишите программу, которая найдёт точку пересечения двух прямых" +
                                  "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем." +
                                  "\n\tb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)\n\n");


                const int COEFFICENT = 0;
                const int CONSTANT = 1;
                const int X_COORD = 0;
                const int Y_COORD = 1;
                const int LINE1 = 1;
                const int LINE2 = 2;


                double[] LineData1 = InputLineData(LINE1);
                double[] LineData2 = InputLineData(LINE2);


                if (ValidateLines(LineData1, LineData2))
                {
                    double[] coord = FindCoords(LineData1, LineData2);
                    Console.WriteLine($"Точка пересичения уравнений " +
                        $"\nY = {LineData1[COEFFICENT]} * x + {LineData1[CONSTANT]} и Y = {LineData2[COEFFICENT]} * x + {LineData2[CONSTANT]} ");
                    Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})\n\n");
                }


                bool ValidateLines(double[] lineData1, double[] lineData2)
                {

                    if (lineData1[COEFFICENT] == lineData2[COEFFICENT])
                    {
                        if (lineData1[CONSTANT] == lineData2[CONSTANT])
                        {
                            Console.WriteLine("Прямые совпадают ");
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Прямые паралельны ");
                            return false;
                        }
                    }
                    return true;
                }


                double[] FindCoords(double[] lineData1, double[] lineData2)
                {
                    double[] coord = new double[2];
                    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICENT] - lineData1[COEFFICENT]);
                    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
                    return coord;
                }


                double[] InputLineData(int NumberOfLine)
                {
                    double[] LineData = new double[2];
                    LineData[COEFFICENT] = Metod.InputNumDouble($"Введите коэффицент для {NumberOfLine} прямой ");
                    LineData[CONSTANT] = Metod.InputNumDouble($"Введите константу для {NumberOfLine} прямой ");
                    return LineData;
                }
            }
        }
    }
}
