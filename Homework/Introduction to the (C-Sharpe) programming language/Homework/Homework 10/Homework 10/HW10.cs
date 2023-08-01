using System;
using MyMetods;


namespace Homework_10
{
    public class HW10
    {
        public static void Run()
        {
            Metod.Task(1, true);
            Console.WriteLine(" Написать программу, которая из имеющегося массива строк формирует новый массив из строк,\n" +
                " длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,\n" +
                " либо задать на старте выполнения алгоритма.\n" +
                " При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.\n" +
                              "\n\tN = 5 -> 5, 4, 3, 2, 1" +
                              "\n\tN = 8 -> 8, 7, 6, 5, 4, 3, 2, 1\n\n");


            string[] OriginalArray = Metod.SetArrayStr();
            Console.Clear();
            Metod.GetStrArrayMaxChar(OriginalArray);

            Metod.End();
        }
    }
}
