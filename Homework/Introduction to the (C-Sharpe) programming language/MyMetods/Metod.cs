using System;

namespace MyMetods
{
    public class Metod
    {
        public static int InputNumInt(string Messadge)
        {
            Console.Write(Messadge);
            string NumString = Console.ReadLine();
            int NumInt = Convert.ToInt32(NumString);
            return NumInt;
        }

        public static double InputNumDouble(string Messadge)
        {
            Console.Write(Messadge);
            string NumString = Console.ReadLine();
            double NumDouble = Convert.ToDouble(NumString);
            return NumDouble;
        }

        public static bool InputBoolean(string Messadge)
        {
            Console.Write(Messadge);
            string NumString = Console.ReadLine();
            switch (NumString)
            {
                case "Yes":
                    return true;
                case "yes":
                    return true;
                case "No":
                    return false;
                case "no":
                    return false;
                default:
                    InputBoolean(Messadge);
                    break;
            }
            return false;
        }

        public static int[] InputArrayInt(int Size)
        {
            int[] Array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Array[i] = InputNumInt($"Enter the {i + 1} element: ");
            }
            return Array;
        }

        public static int[] GenerateArrayInt(int Size, int MinValue, int MaxValue)
        {
            int[] Array = new int[Size];
            Random Random = new Random();
            for (int i = 0; i < Size; i++)
            {
                Array[i] = Random.Next(MinValue, MaxValue + 1);
            }
            return Array;
        }

        public static double[] GenerateArrayDouble(int Size, int MinValue, int MaxValue, bool IsRealNumber = false, int decimals = 0)
        {
            double[] Array = new double[Size];
            Random Random = new Random();
            for (int i = 0; i < Size; i++)
            {
                Array[i] = Random.Next(MinValue, MaxValue + 1);
                if (IsRealNumber)
                {
                    Array[i] += Math.Round(Random.NextDouble(), decimals);
                }
            }
            return Array;
        }

        public static int[,] Generate2DArrayInt(int Rows, int Columns,  int MinValue, int MaxValue)
        {
            int[,] Array = new int[Rows, Columns];
            Random Random = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Array[i, j] = Random.Next(MinValue, MaxValue + 1);
                }
            }
            return Array;
        }

        public static double[,] Generate2DArrayDouble(int Rows, int Columns, int MinValue, int MaxValue, bool IsRealNumber = false, int decimals = 0)
        {
            double[,] Array = new double[Columns, Rows];
            Random Random = new Random();
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Array[i, j] = Random.Next(MinValue, MaxValue + 1);
                    if (IsRealNumber)
                    {
                        Array[i, j] += Math.Round(Random.NextDouble(), decimals);
                    }
                }
            }
            return Array;
        }

        public static int[,,] Generate3DArrayInt(int Rows, int Columns, int Layers, int MinValue, int MaxValue)
        {
            int[,,] Array = new int[Rows, Columns, Layers];
            Random Random = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    for (int k = 0; k < Layers; k++)
                    {
                        Array[i, j, k] = Random.Next(MinValue, MaxValue + 1);
                    }
                }
            }
            return Array;
        }

        public static void ArrayIntPrint(int[] Array)
        {
            Console.Write("[");
            for (int i = 0; i < Array.Length - 1; i++)
            {
                Console.Write($"{Array[i]}|\t");
            }
            Console.WriteLine($"{Array[Array.Length - 1]}]\n");
        }

        public static void ArrayDoublePrint(double[] Array)
        {
            Console.Write("[");
            for (int i = 0; i < Array.Length - 1; i++)
            {
                Console.Write($"{Array[i]}|\t");
            }
            Console.WriteLine($"{Array[Array.Length - 1]}]\n");
        }

        public static void Array2DIntPrint(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"|{Array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void Array2DDoublePrint(double[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"|{Array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void Array3DIntPrint(int[,,] Array)
        {
            Console.WriteLine("\n|((Numbers)(Y,X,Z))|\n");
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        Console.Write($"|(({Array[i, j, k]})(Y{j},X{k},Z{i}))\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
        }

        public static int CountPositiveNumbers(int[] Array)
        {
            int Count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0)
                {
                    Count++;
                }
            }
            return Count;
        }

        public static void FindNumber2DArray(double[,] Array, double FindTheNumber)
        {
            bool Find = false;
            Console.WriteLine($"The number ({FindTheNumber}) ");
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] == FindTheNumber)
                    {
                        Console.WriteLine($"\tFound at coordinates [{i}] [{j}]");
                        Find = true;
                    }
                }
            }
            if (!Find)
            {
                Console.WriteLine($"\twas not found in the array");
            }
        }

        public static double[] GetAverageByColumns(int[,] Array)
        {
            double[] AverageByColumns = new double[Array.GetLength(1)];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    AverageByColumns[j] += Convert.ToDouble(Array[i, j]);
                }
            }
            for (int i = 0; i < AverageByColumns.Length; i++)
            {
                AverageByColumns[i] /= Array.GetLength(0);
            }
            return AverageByColumns;
        }

        public static int ReductionToThreeDigits(int Number)
        {
            while (Number > 999)
            {
                Number /= 10;
            }
            return Number % 10;
        }

        public static bool CheckingANumberForThreeDigits(int Number)
        {
            if (Number < 100)
            {
                Console.WriteLine("There is no third digit");
                return false;
            }
            return true;
        }

        public static bool IsWeekend(int Number)
        {
            if (Number > 5)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidateWeekday(int Number)
        {
            if (Number > 0 && Number <= 7)
            {
                return true;
            }

            Console.WriteLine("It's not a day of the week");
            return false;
        }

        public static void CheckingNumberIntenger(int Number)
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

        public static void CheckingNumberString(string Number)
        {

            if (Number[0] == Number[4] || Number[1] == Number[3])
            {
                Console.WriteLine($"\nYour number {Number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\nYour number {Number} is not a palindrome.");
            }
        }

        public static int SetAxisCoordinate(string Axis, string PointName)
        {
            Console.Write($"Enter the coordinate {Axis}, Point name {PointName}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double MySqrt(double Number)
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

        public static double MyPow(double x, double y)
        {
            double Product = x;
            for (int i = 1; i < y; i++)
            {
                Product *= x;
            }
            return Product;
        }

        public static double Distance(double x1, double x2,
                                      double y1, double y2,
                                      double z1, double z2)
        {
            return MySqrt(MyPow(x2 - x1, 2) +
                          MyPow(y2 - y1, 2) +
                          MyPow(z2 - z1, 2));
        }

        public static int SumAllDigit(int Number)
        {
            int Result = 0;
            while (Number > 0)
            {
                Result += Number % 10;
                Number = Number / 10;
            }
            return Result;
        }

        public static void OrderArrayLinesMaxToMin(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(1) - 1; k++)
                    {
                        if (Array[i, k] < Array[i, k + 1])
                        {
                            int Temp = Array[i, k + 1];
                            Array[i, k + 1] = Array[i, k];
                            Array[i, k] = Temp;
                        }
                    }
                }
            }
        }

        public static int SumRowElements(int[,] Array, int i)
        {
            int SumRow = Array[i, 0];
            for (int j = 1; j < Array.GetLength(1); j++)
            {
                SumRow += Array[i, j];
            }
            return SumRow;
        }

        public static void MinSumRow(int[,] Array)
        {
            int MinSum = 0;
            int SumRow = SumRowElements(Array, 0);
            for (int i = 1; i < Array.GetLength(0); i++)
            {
                int TempSum = Metod.SumRowElements(Array, i);
                if (SumRow > TempSum)
                {
                    SumRow = TempSum;
                    MinSum = i;
                }
            }
            Console.WriteLine($"\n ({MinSum + 1}) the string with the smallest sum ({SumRow}) of the elements ");
        }

        public static void MultiplyMatrix(int[,] MatFirst, int[,] MatSecomd, int[,] MatResult)
        {
            for (int i = 0; i < MatResult.GetLength(0); i++)
            {
                for (int j = 0; j < MatResult.GetLength(1); j++)
                {
                    int Sum = 0;
                    for (int k = 0; k < MatFirst.GetLength(1); k++)
                    {
                        Sum += MatFirst[i, k] * MatSecomd[k, j];
                    }
                    MatResult[i, j] = Sum;
                }
            }
        }

        public static int[,] SpirallyFilledArray(int[,] array)
        {
            int temp = 1;
            int i = 0;
            int j = 0;
            while (temp <= array.GetLength(0) * array.GetLength(1))
            {
                array[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= array.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > array.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
            return array;
        }

        public static int SetPositiveNum(string Mesadge)
        {
            int n = InputNumInt(Mesadge); ;
            if (n < 1)
            {
                Console.WriteLine("Error: Incorrect number entered (try again)");
                SetPositiveNum(Mesadge);
            }
            return n;
        }

        public static int NaturalNumber(int n, int m)
        {
            if (n == m)
            {
                return n;
            }
            else
            {
                Console.Write($"{NaturalNumber(n, m + 1)}, ");
            }
            return m;
        }

        public static int SumOfElements(int m ,int n)
        {
            if (n == m)
            {
                return m;
            }
            else
            {
                return SumOfElements(m + 1, n) + m;
            }
        }

        public static int Akkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Akkerman(m - 1, 1);
            }
            else
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }
        }

        public static string[] SetArrayStr(string Mesadge = "Enter the elements of the initial array separated by commas: ", char SplitChar = ',')
        {
            Console.WriteLine(Mesadge);
            string input = Console.ReadLine();
            string[] originalArray = input.Split(SplitChar);
            return originalArray;
        }

        public static string[] GetStrArrayMaxChar(string[] originalArray)
        {
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

            Console.WriteLine("Initial array: [" + string.Join(", ", originalArray) + "]");
            Console.Write("New array: [");
            for (int i = 0; i < j; i++)
            {
                Console.Write(newArray[i]);
                if (i < j - 1) Console.Write(", ");
            }
            Console.Write("]");

            return newArray;
        }

        /*______________________________________________________________________________________________________________________________________*/
        public static void Task(int TaskNum, bool IsFirstTask = false)
        {
            if (!IsFirstTask)
            {
                Console.Write("\n\n\npress Enter to proceed to the next task\n\n");
                Console.ReadKey();
                Console.Clear();
            }
            Console.Write($"\n+++++++++++++++++++ Task {TaskNum} +++++++++++++++++++\n\n\n");
        }
        public static void End()
        {
            Console.Write($"\n\n\n+++++++++++++++++++++++ END +++++++++++++++++++++++\n");
             Console.Write($"To return to the start menu, press any key ");

            Console.ReadKey();
        }
    }
}
