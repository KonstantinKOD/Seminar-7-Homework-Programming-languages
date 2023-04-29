// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateArray(int length, int length2)
{
    int[,] Array = new int[length, length2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 100);
        }
    }
    return Array;
    System.Console.WriteLine(Array);
}

int[,] PrintArray(int[,] Array)
{
    System.Console.WriteLine("Двумерный массив с случайным набором значений");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i, j] + ": ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return Array;
}

int InputNumber(string arg)
{
    int number;
    System.Console.Write($"Введите {arg}: ");
    while (!int.TryParse(Console.ReadLine(), out number) && number > 0)
    {
        System.Console.WriteLine("Введите цифру");
    }
    return number;
}

bool SearchEnteringNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                System.Console.WriteLine($"Элемент с этим значением в строке {i + 1}, и столбце {j + 1}");
                return true;
            }
        }

    }
    System.Console.WriteLine("Такого элемента не существует");
    return false;
}


System.Console.WriteLine();
int[,] array = CreateArray(5, 5);
PrintArray(array);
int num = InputNumber("искомое число");
System.Console.WriteLine();
SearchEnteringNumber(array, num);
System.Console.WriteLine();