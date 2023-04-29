// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


internal class Program
{
    private static void Main(string[] args)
    {
        int lines = 5;
        int columns = 5;
        int[,] array = new int[lines, columns];

        int[,] CreateArray(int lines, int columns)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 11);
                }
            }
            return array;
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + ": ");
                }
                Console.WriteLine("]");
            }
        }

        Console.WriteLine();
        PrintArray(CreateArray(5, 5));
        Console.WriteLine();

        void ArithmeticMeanInArray(int[,] array)
        {
            Console.WriteLine("-----Сумма каждого столбца-----");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                double summ = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    summ += array[i, j];
                }
                Console.Write(summ / array.GetLength(0) + " | ");
            }
        }

        ArithmeticMeanInArray(array);
    }
}