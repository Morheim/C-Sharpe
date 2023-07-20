using System;

namespace Homework_10
{
    public class HW10
    {
        public static void Run()
        {
            // Ввод начального массива
            Console.WriteLine("Введите элементы начального массива через запятую:");
            string input = Console.ReadLine();
            string[] originalArray = input.Split(',');

            // Создание нового массива из строк, длина которых меньше, либо равна 3 символам
            string[] newArray = new string[originalArray.Length];
            int j = 0;
            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    newArray[j] = originalArray[i];
                    j++;
                }
            }

            // Вывод результата
            Console.WriteLine("Начальный массив: [" + string.Join(", ", originalArray) + "]");
            Console.Write("Новый массив: [");
            for (int i = 0; i < j; i++)
            {
                Console.Write(newArray[i]);
                if (i < j - 1) Console.Write(", ");
            }
            Console.Write("]");
        }
    }
}
