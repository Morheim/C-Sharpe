using System;
using MyMetods;

namespace Homework_9
{
    public class HW9
    {
        public static void Run()
        {
            ///TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(1, true);
                Console.WriteLine(" Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. (Выполнить с помощью рекурсии.)" +
                                  "\n\tN = 5 -> 5, 4, 3, 2, 1" +
                                  "\n\tN = 8 -> 8, 7, 6, 5, 4, 3, 2, 1\n\n");
                

                Console.WriteLine(Metod.NaturalNumber(Metod.SetPositiveNum("Enter a positive number: "), 1));
            }

            ///TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(2);
                Console.WriteLine(" Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N." +
                                  "\n\n\tM = 1; N = 15 -> 120:" +
                                  "\n\tM = 4; N = 8. -> 30\n\n");

                Console.WriteLine(Metod.SumOfElements(m: Metod.InputNumInt("Enter M = "),
                                                      n: Metod.InputNumInt("Enter N = ")));
            }

            ///TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Metod.Task(3);
                Console.WriteLine(" Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n." +
                                  "\n\n\tm = 2, n = 3 -> A(m,n) = 9" +
                                  "\n\tm = 3, n = 2 -> A(m,n) = 29\n\n");


                int m = Metod.InputNumInt("Input M: ");
                int n = Metod.InputNumInt("Input N: ");

                Console.WriteLine($"A({m},{n}) = {Metod.Akkerman(m, n)}");
            }
        }
    }
}
