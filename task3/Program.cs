// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int lines = 5;
int columns = 5;
int[,] array = new int[lines, columns];

int[,] CreateArray(int lines, int columns)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(0,11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+": ");
        }
        System.Console.WriteLine("]");
    }
}

System.Console.WriteLine();
PrintArray(CreateArray(5,5));
System.Console.WriteLine();

int ArithmeticMeanInArray(int[,] array)
{
    System.Console.WriteLine("-----Сумма каждого столбца-----");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i,j];
        }
        System.Console.Write(summ / array.GetLength(0) + " | ");
    }
    return array[4,4];
}

ArithmeticMeanInArray(array);
System.Console.WriteLine();