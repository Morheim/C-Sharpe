using System;
using MyMetods;

namespace Homework_3
{
    public class HW3
    {
        public static void Run()
        {
            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом." +
                    "\n\t14212->нет" +
                    "\n\t12821->да" +
                    "\n\t23432->да\n\n");

                int Number = Metod.InputNumInt("Enter a five-digit number: ");
                if (Number < 10000 || Number >= 100000)
                {
                    Console.WriteLine("You entered the wrong number, repeat the input");
                    return;
                }
                else
                {
                    Metod.CheckingNumberIntenger(Number);
                }
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве." +
                    "\n\tA(3, 6, 8); B(2, 1, -7), -> 15.84" +
                    "\n\tA(7, -5, 0); B(1, -1, 9)-> 11.53\n\n");

                int x1 = Metod.SetAxisCoordinate("x", "A");
                int y1 = Metod.SetAxisCoordinate("y", "A");
                int z1 = Metod.SetAxisCoordinate("z", "A");
                int x2 = Metod.SetAxisCoordinate("x", "B");
                int y2 = Metod.SetAxisCoordinate("y", "B");
                int z2 = Metod.SetAxisCoordinate("z", "B");

                double DistanceBetweenCoordinates = Math.Round(Metod.Distance(x1, x2, y1, y2, z1, z2), 2);
                Console.WriteLine("\nDistance between coordinates" +
                    $"\n|x1 ({x1})| y1 ({y1})| z1 ({z1})|" +
                    $"\n---------------------------------" +
                    $"\n|x2 ({x2})| y2 ({y2})| z2 ({z2})|" +
                    $"\n\nEqual to: {DistanceBetweenCoordinates}");
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(3);
                Console.WriteLine("Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N." +
                    "\n\t3-> 1, 8, 27" +
                    "\n\t5-> 1, 8, 27, 64, 125\n\n");

                int Number = Metod.InputNumInt("Enter a five-digit number: ");
                for (int i = 1; i <= Number; i++)
                {
                    Console.WriteLine(Metod.MyPow(i, 3));
                }
            }

            Metod.End();
        }
    }
}
