using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(1, true);
                Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее." +
                    "\n\ta = 5; b = 7 -> max = 7" +
                    "\n\ta = 2 b = 10 -> max = 10" +
                    "\n\ta = -9 b = -3 -> max = -3");

                Console.Write("\nВведите число a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nВведите число b: ");
                b = Convert.ToInt32(Console.ReadLine());

                if(a > b)
                {
                    Console.Write($"\nЧисло (а = {a}) больше (b = {b})");
                }
                else
                {
                    Console.Write($"\nЧисло (b = {b}) больше (a = {a})");
                }
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(2);
                Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел." +
                    "\n\t2, 3, 7 -> 7" +
                    "\n\t44 5 78-> 78" +
                    "\n\t22 3 9-> 22");

                Console.Write("\nВведите число a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nВведите число b: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nВведите число c: ");
                c = Convert.ToInt32(Console.ReadLine());

                int max = a;
                if(b > max)
                {
                    max = b;
                }
                if(c > max)
                {
                    max = c;
                }
                Console.Write("\nМаксимальное число, из трёх введённых (a, b, c) = " + max);
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(3);
                Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт," +
                    " является ли число чётным (делится ли оно на два без остатка)." +
                    "\n\t4 -> да" +
                    "\n\t-3 -> нет" +
                    "\n\t7 -> нет");

                Console.Write("\nВведите число a: ");
                a = Convert.ToInt32(Console.ReadLine());

                int WithoutResidue = a % 2;

                if (WithoutResidue == 0)
                {
                    Console.Write("\nДа");
                }
                else
                {
                    Console.Write("\nНет");
                }


            }

            //TASK4/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                DZ(4);
                Console.WriteLine("Напишите программу, которая на вход принимает число (N)," +
                    " а на выходе показывает все чётные числа от 1 до N." +
                    "\n\t5 -> 2, 4" +
                    "\n\t8 -> 2, 4, 6, 8");

                Console.Write("\nВведите число a: ");
                a = Convert.ToInt32(Console.ReadLine());

                int EvenNumber = 2;

                Console.Write("чётные числа от 0 до " + a + " = ");

                if (a > 1)
                {
                    while (EvenNumber <= a)
                    {
                        Console.Write(+ EvenNumber + ", ");
                        EvenNumber = EvenNumber + 2;
                    }
                }
                Console.WriteLine();

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