// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] CreateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PRINT(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double AvgSum(int[,] array)
{
    double avgSum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avgSum = avgSum + array[i, j];
        }
        System.Console.Write($"{avgSum/array.GetLength(1)} ");
        break;
    }
    System.Console.WriteLine();
    return avgSum;
}

int[,] array = CreateArray(6, 6, 1, 10);
PRINT(array);
System.Console.WriteLine(AvgSum(array));