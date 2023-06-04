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

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));

            void HomeworhNumbers(int NumHomewrk)
            {
                Console.Clear();
                switch (NumHomewrk)
                {
                    case 1:
                        HW1.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 2:
                        HW2.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 3:
                        HW3.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 4:
                        HW4.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 5:
                        HW5.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 6:
                        HW6.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 7:
                        HW7.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 8:
                        HW8.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;

                    case 9:
                        HW9.Run();
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;
                    
                    default:
                        Console.WriteLine("Invalid value entered, please try again");
                        HomeworhNumbers(Metod.InputNumInt("Enter the homework number you want to run (1-9) = "));
                        break;
                }
            }
        }
    }
}
