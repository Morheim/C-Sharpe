using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Task(1, true);
                Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом." +
                    "\n\t14212->нет" +
                    "\n\t12821->да" +
                    "\n\t23432->да\n\n");

                int Number = PrintNum("Enter a five-digit number: ");
                if (Number < 10000 || Number >= 100000)
                {
                    Console.WriteLine("You entered the wrong number, repeat the input");
                    return;
                }
                else
                {
                    CheckingNumberIntenger(Number);
                }

                /*Console.Write("Enter a number: ");
                string Number = Console.ReadLine();

                if (Number.Length == 5)
                {
                    CheckingNumberString(Number);
                }
                else
                {
                    Console.WriteLine("Enter the correct number");
                }*/
            }

            //TASK2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Task(2);
                Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве." +
                    "\n\tA(3, 6, 8); B(2, 1, -7), -> 15.84" +
                    "\n\tA(7, -5, 0); B(1, -1, 9)-> 11.53\n\n");

                int x1 = SetAxisCoordinate("x", "A");
                int y1 = SetAxisCoordinate("y", "A");
                int z1 = SetAxisCoordinate("z", "A");
                int x2 = SetAxisCoordinate("x", "B");
                int y2 = SetAxisCoordinate("y", "B");
                int z2 = SetAxisCoordinate("z", "B");

                double DistanceBetweenCoordinates = Math.Round(Distance(x1, x2, y1, y2, z1, z2), 2);
                Console.WriteLine("\nDistance between coordinates" +
                    $"\n|x1 ({x1})| y1 ({y1})| z1 ({z1})|" +
                    $"\n---------------------------------" +
                    $"\n|x2 ({x2})| y2 ({y2})| z2 ({z2})|" +
                    $"\n\nEqual to: {DistanceBetweenCoordinates}");
            }

            //TASK3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            {
                Task(3);
                Console.WriteLine("Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N." +
                    "\n\t3-> 1, 8, 27" +
                    "\n\t5-> 1, 8, 27, 64, 125\n\n");

                int Number = PrintNum("Enter a five-digit number: ");
                for (int i = 1; i <= Number; i++)
                {
                    Console.WriteLine(MyPow(i, 3));
                }
            }
            
            /*Metods_________________________________________________________________________________________________________________________________*/
            int PrintNum(string Messadge)
            {
                Console.Write(Messadge);
                string NumString = Console.ReadLine();
                int NumInt = Convert.ToInt32(NumString);
                return NumInt;
            }

            void CheckingNumberIntenger(int Number)
            {
                Console.WriteLine($"Enter a number = {Number}");
                int NumberOne = Number / 10000;
                int NumberTwo = Number / 1000 % 10;
                int NumberFour = Number / 10 % 10;
                int NumberFive = Number % 10;
                if (NumberOne == NumberFive && NumberTwo == NumberFour)
                {
                    Console.WriteLine($"\nYour number {Number} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"\nYour number {Number} is not a palindrome.");
                }
            }

            /*void CheckingNumberString(string Number)
            {

                if (Number[0] == Number[4] || Number[1] == Number[3])
                {
                    Console.WriteLine($"\nYour number {Number} is a palindrome.");
                }
                else Console.WriteLine($"\nYour number {Number} is not a palindrome.");
            }*/

            int SetAxisCoordinate(string Axis, string PointName)
            {
                Console.Write($"Enter the coordinate {Axis}, Point name {PointName}: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            double MySqrt(double Number)
            {
                double t;
                double SquareRoot = Number / 2;
                do
                {
                    t = SquareRoot;
                    SquareRoot = (t + (Number / t)) / 2;
                } while ((t - SquareRoot) != 0);

                return SquareRoot;
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

            double Distance(double x1, double x2,
                            double y1, double y2,
                            double z1, double z2)
            {

                return MySqrt(MyPow(x2 - x1, 2) +
                              MyPow(y2 - y1, 2) +
                              MyPow(z2 - z1, 2));

                /*return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                                 Math.Pow((y2 - y1), 2) +
                                 Math.Pow((z2 - z1), 2));*/
            }

            /*_______________________________________________________________________________________________________________________________________*/
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
