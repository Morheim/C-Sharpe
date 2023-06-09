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
            string Mesadge = "\n Enter the homework number you want to run (1-9) = ";

            HomeworhNumbers(Metod.InputNumInt(Mesadge));

            void HomeworhNumbers(int NumHomewrk)
            {
                Console.Clear();
                switch (NumHomewrk)
                {
                    case 1:
                        HW1.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 2:
                        HW2.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 3:
                        HW3.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 4:
                        HW4.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 5:
                        HW5.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 6:
                        HW6.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 7:
                        HW7.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 8:
                        HW8.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;

                    case 9:
                        HW9.Run();
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;
                    
                    default:
                        Console.WriteLine("\n Invalid value entered, please try again\n");
                        HomeworhNumbers(Metod.InputNumInt(Mesadge));
                        break;
                }
            }
        }
    }
}
