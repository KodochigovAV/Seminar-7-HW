// Задача 2: Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

int Find(int[,] array, int row, int column)
{
    int answer = array[row, column];
    return answer;
}

int row = Prompt("Row -> ");
int column = Prompt("Column -> ");
int min = 1;
int max = 10;
int[,] array = CreateArray(5, 5, min, max);
if (array.GetLength(1) <= column || array.GetLength(0) <= row)
{
    System.Console.WriteLine("Out of bound");
    Environment.Exit(0);
}
PRINT(array);
System.Console.WriteLine();
System.Console.WriteLine($"Number -> {array[row, column]}");