using System;
using MyMetods;
using Homework_1;
using Homework_2;
using Homework_3;
using Homework_4;
using Homework_5;
using Homework_6;
using Homework_7;
using Homework_8;
using Homework_9;
using Homework_10;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(" Список домашних заданий по темам урока \n\n"+
                " 1) Знакомство с языком программирования С#\n" +
                " 2) Базовые алгоритмы\n" +
                " 3) Базовые алгоритмы. Продолжение\n" +
                " 4) Функции\n" +
                " 5) Функции и одномерные массивы\n" +
                " 6) Одномерные массивы. Продолжение\n" +
                " 7) Двумерные массивы\n" +
                " 8) Двумерные массивы. Продолжение\n" +
                " 9) Рекурсия\n" +
                " 10) Итоговая контрольная работа по основному блоку \n");

            string Mesadge = "\n Enter the homework number you want to run (1-10) = ";

            HomeworkNumbers(Metod.InputNumInt(Mesadge));

            void HomeworkNumbers(int NumHomewrk)
            {
                Console.Clear();
                switch (NumHomewrk)
                {
                    case 1:
                        HW1.Run();
                        Main(args);
                        break;

                    case 2:
                        HW2.Run();
                        Main(args);
                        break;

                    case 3:
                        HW3.Run();
                        Main(args);
                        break;

                    case 4:
                        HW4.Run();
                        Main(args);
                        break;

                    case 5:
                        HW5.Run();
                        Main(args);
                        break;

                    case 6:
                        HW6.Run();
                        Main(args);
                        break;

                    case 7:
                        HW7.Run();
                        Main(args);
                        break;

                    case 8:
                        HW8.Run();
                        Main(args);
                        break;

                    case 9:
                        HW9.Run();
                        Main(args);
                        break;

                    case 10:
                        HW10.Run();
                        Main(args);
                        break;
                    
                    default:
                        Console.WriteLine("\n Invalid value entered, please try again\n");
                        Console.ReadKey();
                        Main(args);
                        break;
                }
            }
        }
    }
}
